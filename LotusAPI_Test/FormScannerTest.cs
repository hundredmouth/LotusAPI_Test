using Abeo.Controls;
using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.MV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusAPI_Test {
    public partial class FormScannerTest : Form {
        PointcloudViewer _pcv = null;
        AbeoScan _scanner = null;

        public FormScannerTest() {
            InitializeComponent();

            //setup registry key (to store environment setting)
            Registry.SetApplicationName(Application.ProductName);

            //initialize logger
            Logger.Add(new LogViewLogger(lv));

            //init pointcloud viewer
            _pcv = new PointcloudViewer(pcv);

            //init library
            Library.Initialize();


            this.FormClosed += FormScannerTest_FormClosed;

        }

        private void FormScannerTest_FormClosed(object sender, FormClosedEventArgs e) {
            _scanner?.Disconnect();
        }

        private void bt_Connect_Click(object sender, EventArgs e) {
            try {
                var f = new FormAbeoscanConnect();

                if(f.ShowDialog() == DialogResult.OK) {
                    _scanner = f.Scanner;
                }

                if(_scanner.IsConnected) {
                    //change button color
                    bt_Connect.ContentBackColor = SolarizedColorPalette.Green;
                    bt_Connect.ForeColor = SolarizedColorPalette.Base03;

                    Logger.Info("Connected to scanner " + _scanner.Signature);

                    //load default profile
                    _scanner.LoadProfile("Default");
                }

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        void AssertScanner() {
            if(_scanner == null) throw new Exception("Invalid scanner!");
            if(!_scanner.IsConnected) throw new Exception("Scanner is not connected!");
        }
        private void bt_Scan_Click(object sender, EventArgs e) {
            try {
                AssertScanner();

                //grab a pointcloud
                var pc = _scanner.Scan();

                //clear display
                _pcv.Clear();

                //add to viewer
                _pcv.Add(pc, Color.Gray);

                //and display
                _pcv.Render();

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void bt_ScannerSetting_Click(object sender, EventArgs e) {
            try {
                AssertScanner();
                var f = new Abeo.Controls.Common.FormObjectEditor(_scanner);
                if(f.ShowDialog() == DialogResult.OK) {
                    _scanner.Invalidate();
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void bt_ClearDisplay_Click(object sender, EventArgs e) {
            _pcv.Clear();
            _pcv.Render();
        }
    }
}
