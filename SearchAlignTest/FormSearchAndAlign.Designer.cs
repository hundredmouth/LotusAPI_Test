
namespace SearchAlignTest {
    partial class FormSearchAndAlign {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pcv = new LotusAPI.Controls.PointcloudView();
            this.flatPanel1 = new Abeo.Controls.FlatPanel();
            this.flatButton2 = new Abeo.Controls.FlatButton();
            this.flatButton1 = new Abeo.Controls.FlatButton();
            this.bt_Load_Scan = new Abeo.Controls.FlatButton();
            this.bt_Load_Model = new Abeo.Controls.FlatButton();
            this.lv = new LotusAPI.Controls.LogView();
            this.flatPanel2 = new Abeo.Controls.FlatPanel();
            this.flatButton3 = new Abeo.Controls.FlatButton();
            this.flatButton4 = new Abeo.Controls.FlatButton();
            this.flatPanel3 = new Abeo.Controls.FlatPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pcv)).BeginInit();
            this.flatPanel1.SuspendLayout();
            this.flatPanel2.SuspendLayout();
            this.flatPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcv
            // 
            this.pcv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcv.DrawFPS = false;
            this.pcv.Location = new System.Drawing.Point(0, 0);
            this.pcv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pcv.Name = "pcv";
            this.pcv.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.pcv.Padding = new System.Windows.Forms.Padding(1);
            this.pcv.RenderContextType = SharpGL.RenderContextType.FBO;
            this.pcv.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.pcv.Size = new System.Drawing.Size(1151, 506);
            this.pcv.TabIndex = 4;
            // 
            // flatPanel1
            // 
            this.flatPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.flatPanel1.Controls.Add(this.flatButton4);
            this.flatPanel1.Controls.Add(this.flatButton3);
            this.flatPanel1.Controls.Add(this.flatButton2);
            this.flatPanel1.Controls.Add(this.flatButton1);
            this.flatPanel1.Controls.Add(this.bt_Load_Scan);
            this.flatPanel1.Controls.Add(this.bt_Load_Model);
            this.flatPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatPanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel1.Location = new System.Drawing.Point(0, 0);
            this.flatPanel1.Name = "flatPanel1";
            this.flatPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.flatPanel1.Size = new System.Drawing.Size(1151, 49);
            this.flatPanel1.TabIndex = 3;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.flatButton2.BorderColor = System.Drawing.Color.White;
            this.flatButton2.BorderSize = 1;
            this.flatButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatButton2.Location = new System.Drawing.Point(440, 1);
            this.flatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.flatButton2.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton2.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Size = new System.Drawing.Size(154, 47);
            this.flatButton2.TabIndex = 21;
            this.flatButton2.Text = "4. 3D패턴설정";
            this.flatButton2.UseVisualStyleBackColor = false;
            this.flatButton2.Click += new System.EventHandler(this.bt_SearchSetting_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.flatButton1.BorderColor = System.Drawing.Color.White;
            this.flatButton1.BorderSize = 1;
            this.flatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatButton1.Location = new System.Drawing.Point(335, 1);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.flatButton1.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(105, 47);
            this.flatButton1.TabIndex = 20;
            this.flatButton1.Text = "3. 매칭";
            this.flatButton1.UseVisualStyleBackColor = false;
            this.flatButton1.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Load_Scan
            // 
            this.bt_Load_Scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bt_Load_Scan.BorderColor = System.Drawing.Color.White;
            this.bt_Load_Scan.BorderSize = 1;
            this.bt_Load_Scan.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Load_Scan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Load_Scan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_Load_Scan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.bt_Load_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Load_Scan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bt_Load_Scan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_Load_Scan.Location = new System.Drawing.Point(167, 1);
            this.bt_Load_Scan.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Load_Scan.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_Load_Scan.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.bt_Load_Scan.Name = "bt_Load_Scan";
            this.bt_Load_Scan.Size = new System.Drawing.Size(168, 47);
            this.bt_Load_Scan.TabIndex = 18;
            this.bt_Load_Scan.Text = "2. 스캔 불러오기";
            this.bt_Load_Scan.UseVisualStyleBackColor = false;
            this.bt_Load_Scan.Click += new System.EventHandler(this.bt_LoadScene_Click);
            // 
            // bt_Load_Model
            // 
            this.bt_Load_Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bt_Load_Model.BorderColor = System.Drawing.Color.White;
            this.bt_Load_Model.BorderSize = 1;
            this.bt_Load_Model.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Load_Model.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Load_Model.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_Load_Model.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.bt_Load_Model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Load_Model.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bt_Load_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_Load_Model.Location = new System.Drawing.Point(1, 1);
            this.bt_Load_Model.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Load_Model.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_Load_Model.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.bt_Load_Model.Name = "bt_Load_Model";
            this.bt_Load_Model.Size = new System.Drawing.Size(166, 47);
            this.bt_Load_Model.TabIndex = 19;
            this.bt_Load_Model.Text = "1. 모델 불러오기";
            this.bt_Load_Model.UseVisualStyleBackColor = false;
            this.bt_Load_Model.Click += new System.EventHandler(this.bt_LoadModel_Click);
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.lv.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.lv.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.lv.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.lv.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.lv.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.lv.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.Font = new System.Drawing.Font("Consolas", 9F);
            this.lv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.LineBuffer = 1000;
            this.lv.Location = new System.Drawing.Point(1, 1);
            this.lv.Name = "lv";
            this.lv.ReadOnly = true;
            this.lv.ShowDateTime = true;
            this.lv.Size = new System.Drawing.Size(1149, 218);
            this.lv.TabIndex = 5;
            this.lv.Text = "";
            this.lv.UpdateInterval = 100;
            // 
            // flatPanel2
            // 
            this.flatPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flatPanel2.Controls.Add(this.lv);
            this.flatPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatPanel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel2.Location = new System.Drawing.Point(0, 506);
            this.flatPanel2.Name = "flatPanel2";
            this.flatPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.flatPanel2.Size = new System.Drawing.Size(1151, 220);
            this.flatPanel2.TabIndex = 6;
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.flatButton3.BorderColor = System.Drawing.Color.White;
            this.flatButton3.BorderSize = 1;
            this.flatButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flatButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatButton3.Location = new System.Drawing.Point(594, 1);
            this.flatButton3.Margin = new System.Windows.Forms.Padding(0);
            this.flatButton3.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton3.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Size = new System.Drawing.Size(154, 47);
            this.flatButton3.TabIndex = 22;
            this.flatButton3.Text = "5. ICP설정";
            this.flatButton3.UseVisualStyleBackColor = false;
            this.flatButton3.Click += new System.EventHandler(this.bt_AlignSetting_Click);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.flatButton4.BorderColor = System.Drawing.Color.White;
            this.flatButton4.BorderSize = 1;
            this.flatButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flatButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flatButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatButton4.Location = new System.Drawing.Point(996, 1);
            this.flatButton4.Margin = new System.Windows.Forms.Padding(0);
            this.flatButton4.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatButton4.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Size = new System.Drawing.Size(154, 47);
            this.flatButton4.TabIndex = 23;
            this.flatButton4.Text = "화면 지우기";
            this.flatButton4.UseVisualStyleBackColor = false;
            this.flatButton4.Click += new System.EventHandler(this.bt_ClearDisplay_Click);
            // 
            // flatPanel3
            // 
            this.flatPanel3.BackColor = System.Drawing.Color.Black;
            this.flatPanel3.Controls.Add(this.flatPanel1);
            this.flatPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatPanel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel3.Location = new System.Drawing.Point(0, 0);
            this.flatPanel3.Name = "flatPanel3";
            this.flatPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.flatPanel3.Size = new System.Drawing.Size(1151, 50);
            this.flatPanel3.TabIndex = 6;
            // 
            // FormSearchAndAlign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1151, 726);
            this.Controls.Add(this.flatPanel3);
            this.Controls.Add(this.pcv);
            this.Controls.Add(this.flatPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSearchAndAlign";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcv)).EndInit();
            this.flatPanel1.ResumeLayout(false);
            this.flatPanel2.ResumeLayout(false);
            this.flatPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LotusAPI.Controls.PointcloudView pcv;
        private Abeo.Controls.FlatPanel flatPanel1;
        private LotusAPI.Controls.LogView lv;
        private Abeo.Controls.FlatButton bt_Load_Scan;
        private Abeo.Controls.FlatPanel flatPanel2;
        private Abeo.Controls.FlatButton flatButton1;
        private Abeo.Controls.FlatButton bt_Load_Model;
        private Abeo.Controls.FlatButton flatButton2;
        private Abeo.Controls.FlatButton flatButton4;
        private Abeo.Controls.FlatButton flatButton3;
        private Abeo.Controls.FlatPanel flatPanel3;
    }
}

