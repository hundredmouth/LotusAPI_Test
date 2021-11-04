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

namespace SearchAlignTest {
    public partial class FormSearchAndAlign : Form {
        PointcloudViewer _pcv = null;
        Pointcloud _model = null;
        Pointcloud _scene = null;
        PatternSearch3D _finder = new PatternSearch3D();
        ICPAligner _aligner = new ICPAligner();

        public FormSearchAndAlign() {
            InitializeComponent();

            //setup registry key (to store environment setting)
            Registry.SetApplicationName(Application.ProductName);

            //initialize logger
            Logger.Add(new LogViewLogger(lv));

            //init pointcloud viewer
            _pcv = new PointcloudViewer(pcv);

            //init library
            Library.Initialize();



        }

        private void bt_LoadModel_Click(object sender, EventArgs e) {
            try {
                _model = new Pointcloud(DialogUtils.OpenPLYFile("Load model file"));
                _pcv.Add(_model, Color.Yellow);
                _pcv.Render();
                Train();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
        private void bt_LoadScene_Click(object sender, EventArgs e) {
            try {
                _scene = new Pointcloud(DialogUtils.OpenPLYFile("Load scene file"));
                _pcv.Add(_scene, Color.Gray);
                _pcv.Render();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        void AssertModel() { if(_model == null) throw new Exception("Model is null!"); }
        void AssertScene() { if(_model == null) throw new Exception("Scene is null!"); }
        void AssertFinder() { if(_finder.Trained == false) throw new Exception("Finder is not trained!"); }


        void Train() {
            try {
                Logger.Debug("Training current model...");
                AssertModel();
                _finder.Model = _model;
                _finder.Train();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void bt_SearchSetting_Click(object sender, EventArgs e) {
            try {
                var f = new Abeo.Controls.Common.FormObjectEditor(_finder);
                if(f.ShowDialog() == DialogResult.OK) {
                    Train();
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
        private void bt_AlignSetting_Click(object sender, EventArgs e) {
            try {
                var f = new Abeo.Controls.Common.FormObjectEditor(_aligner);
                f.ShowDialog();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void bt_Search_Click(object sender, EventArgs e) {
            try {
                Logger.Debug("Finding model in scene...");
                AssertModel();
                AssertScene();
                AssertFinder();

                var Hs = _finder.FindMatches(_scene);

                if(Hs.Length == 0) throw new Exception("Failed to find object in scene.");

                //take first result
                var H = Hs[0];

                //make a copy of model to transform
                var model = _model.Clone() as Pointcloud;
                model.Matrix = H;

                Logger.Debug("Fine aligning result...");

                var err = _aligner.Apply(_scene, model);

                Logger.Warn("Alignment error = " + err.ToString("F3"));

                //get align matrix
                H = model.Matrix;

                Logger.Info("Align matrix = " + H);

                //apply transform and display
                model.ApplyTransform();

                _pcv.Add(model, Color.Lime);

                _pcv.Render();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void bt_ClearDisplay_Click(object sender, EventArgs e) {
            _pcv.Clear();
            _pcv.Render();
        }

    }
}
