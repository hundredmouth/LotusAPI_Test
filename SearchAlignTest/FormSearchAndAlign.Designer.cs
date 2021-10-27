
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
            this.bt_ClearDisplay = new Abeo.Controls.Roundable.RoundButton();
            this.bt_Search = new Abeo.Controls.Roundable.RoundButton();
            this.bt_LoadScene = new Abeo.Controls.Roundable.RoundButton();
            this.bt_LoadModel = new Abeo.Controls.Roundable.RoundButton();
            this.lv = new LotusAPI.Controls.LogView();
            this.bt_SearchSetting = new Abeo.Controls.Roundable.RoundButton();
            this.bt_AlignSetting = new Abeo.Controls.Roundable.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcv)).BeginInit();
            this.flatPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcv
            // 
            this.pcv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcv.DrawFPS = false;
            this.pcv.Location = new System.Drawing.Point(0, 45);
            this.pcv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pcv.Name = "pcv";
            this.pcv.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.pcv.RenderContextType = SharpGL.RenderContextType.FBO;
            this.pcv.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.pcv.Size = new System.Drawing.Size(1151, 419);
            this.pcv.TabIndex = 4;
            // 
            // flatPanel1
            // 
            this.flatPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flatPanel1.Controls.Add(this.bt_AlignSetting);
            this.flatPanel1.Controls.Add(this.bt_SearchSetting);
            this.flatPanel1.Controls.Add(this.bt_ClearDisplay);
            this.flatPanel1.Controls.Add(this.bt_Search);
            this.flatPanel1.Controls.Add(this.bt_LoadScene);
            this.flatPanel1.Controls.Add(this.bt_LoadModel);
            this.flatPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatPanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel1.Location = new System.Drawing.Point(0, 0);
            this.flatPanel1.Name = "flatPanel1";
            this.flatPanel1.Size = new System.Drawing.Size(1151, 45);
            this.flatPanel1.TabIndex = 3;
            // 
            // bt_ClearDisplay
            // 
            this.bt_ClearDisplay.BackColor = System.Drawing.Color.Transparent;
            this.bt_ClearDisplay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_ClearDisplay.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_ClearDisplay.BorderRadius = 3;
            this.bt_ClearDisplay.BorderThickness = 1;
            this.bt_ClearDisplay.Checked = false;
            this.bt_ClearDisplay.CheckEnable = false;
            this.bt_ClearDisplay.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_ClearDisplay.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_ClearDisplay.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_ClearDisplay.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_ClearDisplay.ControlToBringToFront = null;
            this.bt_ClearDisplay.DebugMode = false;
            this.bt_ClearDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_ClearDisplay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_ClearDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_ClearDisplay.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_ClearDisplay.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_ClearDisplay.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_ClearDisplay.Icon = null;
            this.bt_ClearDisplay.IconPortion = 0.3F;
            this.bt_ClearDisplay.IconSize = 24;
            this.bt_ClearDisplay.IconVisible = false;
            this.bt_ClearDisplay.Image = null;
            this.bt_ClearDisplay.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_ClearDisplay.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_ClearDisplay.IsExclusive = false;
            this.bt_ClearDisplay.Location = new System.Drawing.Point(1011, 0);
            this.bt_ClearDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.bt_ClearDisplay.Name = "bt_ClearDisplay";
            this.bt_ClearDisplay.Size = new System.Drawing.Size(140, 45);
            this.bt_ClearDisplay.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_ClearDisplay.TabIndex = 3;
            this.bt_ClearDisplay.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_ClearDisplay.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_ClearDisplay.TagOffset = 5;
            this.bt_ClearDisplay.TagVisible = false;
            this.bt_ClearDisplay.TagWidth = 5;
            this.bt_ClearDisplay.Text = "Clear display";
            this.bt_ClearDisplay.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_ClearDisplay.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ClearDisplay.Click += new System.EventHandler(this.bt_ClearDisplay_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.Transparent;
            this.bt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_Search.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_Search.BorderRadius = 3;
            this.bt_Search.BorderThickness = 1;
            this.bt_Search.Checked = false;
            this.bt_Search.CheckEnable = false;
            this.bt_Search.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Search.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_Search.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Search.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_Search.ControlToBringToFront = null;
            this.bt_Search.DebugMode = false;
            this.bt_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Search.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Search.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Search.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Search.Icon = null;
            this.bt_Search.IconPortion = 0.3F;
            this.bt_Search.IconSize = 24;
            this.bt_Search.IconVisible = false;
            this.bt_Search.Image = null;
            this.bt_Search.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_Search.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_Search.IsExclusive = false;
            this.bt_Search.Location = new System.Drawing.Point(260, 0);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(170, 45);
            this.bt_Search.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_Search.TabIndex = 2;
            this.bt_Search.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_Search.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_Search.TagOffset = 5;
            this.bt_Search.TagVisible = false;
            this.bt_Search.TagWidth = 5;
            this.bt_Search.Text = "Search and Align";
            this.bt_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Search.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_LoadScene
            // 
            this.bt_LoadScene.BackColor = System.Drawing.Color.Transparent;
            this.bt_LoadScene.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_LoadScene.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_LoadScene.BorderRadius = 3;
            this.bt_LoadScene.BorderThickness = 1;
            this.bt_LoadScene.Checked = false;
            this.bt_LoadScene.CheckEnable = false;
            this.bt_LoadScene.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_LoadScene.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_LoadScene.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_LoadScene.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_LoadScene.ControlToBringToFront = null;
            this.bt_LoadScene.DebugMode = false;
            this.bt_LoadScene.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_LoadScene.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_LoadScene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_LoadScene.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_LoadScene.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_LoadScene.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_LoadScene.Icon = null;
            this.bt_LoadScene.IconPortion = 0.3F;
            this.bt_LoadScene.IconSize = 24;
            this.bt_LoadScene.IconVisible = false;
            this.bt_LoadScene.Image = null;
            this.bt_LoadScene.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_LoadScene.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_LoadScene.IsExclusive = false;
            this.bt_LoadScene.Location = new System.Drawing.Point(120, 0);
            this.bt_LoadScene.Margin = new System.Windows.Forms.Padding(8);
            this.bt_LoadScene.Name = "bt_LoadScene";
            this.bt_LoadScene.Size = new System.Drawing.Size(140, 45);
            this.bt_LoadScene.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_LoadScene.TabIndex = 1;
            this.bt_LoadScene.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_LoadScene.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_LoadScene.TagOffset = 5;
            this.bt_LoadScene.TagVisible = false;
            this.bt_LoadScene.TagWidth = 5;
            this.bt_LoadScene.Text = "Load scene";
            this.bt_LoadScene.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_LoadScene.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_LoadScene.Click += new System.EventHandler(this.bt_LoadScene_Click);
            // 
            // bt_LoadModel
            // 
            this.bt_LoadModel.BackColor = System.Drawing.Color.Transparent;
            this.bt_LoadModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_LoadModel.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_LoadModel.BorderRadius = 3;
            this.bt_LoadModel.BorderThickness = 1;
            this.bt_LoadModel.Checked = false;
            this.bt_LoadModel.CheckEnable = false;
            this.bt_LoadModel.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_LoadModel.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.bt_LoadModel.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_LoadModel.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_LoadModel.ControlToBringToFront = null;
            this.bt_LoadModel.DebugMode = false;
            this.bt_LoadModel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_LoadModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_LoadModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_LoadModel.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_LoadModel.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_LoadModel.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_LoadModel.Icon = null;
            this.bt_LoadModel.IconPortion = 0.3F;
            this.bt_LoadModel.IconSize = 24;
            this.bt_LoadModel.IconVisible = false;
            this.bt_LoadModel.Image = null;
            this.bt_LoadModel.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_LoadModel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_LoadModel.IsExclusive = false;
            this.bt_LoadModel.Location = new System.Drawing.Point(0, 0);
            this.bt_LoadModel.Margin = new System.Windows.Forms.Padding(8);
            this.bt_LoadModel.Name = "bt_LoadModel";
            this.bt_LoadModel.Size = new System.Drawing.Size(120, 45);
            this.bt_LoadModel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_LoadModel.TabIndex = 0;
            this.bt_LoadModel.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_LoadModel.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_LoadModel.TagOffset = 5;
            this.bt_LoadModel.TagVisible = false;
            this.bt_LoadModel.TagWidth = 5;
            this.bt_LoadModel.Text = "Load model";
            this.bt_LoadModel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_LoadModel.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_LoadModel.Click += new System.EventHandler(this.bt_LoadModel_Click);
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.lv.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.lv.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.lv.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.lv.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.lv.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.lv.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.lv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv.Font = new System.Drawing.Font("Consolas", 9F);
            this.lv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.LineBuffer = 1000;
            this.lv.Location = new System.Drawing.Point(0, 464);
            this.lv.Name = "lv";
            this.lv.ReadOnly = true;
            this.lv.ShowDateTime = true;
            this.lv.Size = new System.Drawing.Size(1151, 262);
            this.lv.TabIndex = 5;
            this.lv.Text = "";
            this.lv.UpdateInterval = 100;
            // 
            // bt_SearchSetting
            // 
            this.bt_SearchSetting.BackColor = System.Drawing.Color.Transparent;
            this.bt_SearchSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_SearchSetting.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_SearchSetting.BorderRadius = 3;
            this.bt_SearchSetting.BorderThickness = 1;
            this.bt_SearchSetting.Checked = false;
            this.bt_SearchSetting.CheckEnable = false;
            this.bt_SearchSetting.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_SearchSetting.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_SearchSetting.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_SearchSetting.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_SearchSetting.ControlToBringToFront = null;
            this.bt_SearchSetting.DebugMode = false;
            this.bt_SearchSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_SearchSetting.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_SearchSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_SearchSetting.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_SearchSetting.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_SearchSetting.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_SearchSetting.Icon = null;
            this.bt_SearchSetting.IconPortion = 0.3F;
            this.bt_SearchSetting.IconSize = 24;
            this.bt_SearchSetting.IconVisible = false;
            this.bt_SearchSetting.Image = null;
            this.bt_SearchSetting.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_SearchSetting.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_SearchSetting.IsExclusive = false;
            this.bt_SearchSetting.Location = new System.Drawing.Point(430, 0);
            this.bt_SearchSetting.Margin = new System.Windows.Forms.Padding(8);
            this.bt_SearchSetting.Name = "bt_SearchSetting";
            this.bt_SearchSetting.Size = new System.Drawing.Size(130, 45);
            this.bt_SearchSetting.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_SearchSetting.TabIndex = 5;
            this.bt_SearchSetting.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_SearchSetting.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_SearchSetting.TagOffset = 5;
            this.bt_SearchSetting.TagVisible = false;
            this.bt_SearchSetting.TagWidth = 5;
            this.bt_SearchSetting.Text = "Search setting";
            this.bt_SearchSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_SearchSetting.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchSetting.Click += new System.EventHandler(this.bt_SearchSetting_Click);
            // 
            // bt_AlignSetting
            // 
            this.bt_AlignSetting.BackColor = System.Drawing.Color.Transparent;
            this.bt_AlignSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_AlignSetting.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_AlignSetting.BorderRadius = 3;
            this.bt_AlignSetting.BorderThickness = 1;
            this.bt_AlignSetting.Checked = false;
            this.bt_AlignSetting.CheckEnable = false;
            this.bt_AlignSetting.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_AlignSetting.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_AlignSetting.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_AlignSetting.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_AlignSetting.ControlToBringToFront = null;
            this.bt_AlignSetting.DebugMode = false;
            this.bt_AlignSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_AlignSetting.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_AlignSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_AlignSetting.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_AlignSetting.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_AlignSetting.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_AlignSetting.Icon = null;
            this.bt_AlignSetting.IconPortion = 0.3F;
            this.bt_AlignSetting.IconSize = 24;
            this.bt_AlignSetting.IconVisible = false;
            this.bt_AlignSetting.Image = null;
            this.bt_AlignSetting.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_AlignSetting.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_AlignSetting.IsExclusive = false;
            this.bt_AlignSetting.Location = new System.Drawing.Point(560, 0);
            this.bt_AlignSetting.Margin = new System.Windows.Forms.Padding(8);
            this.bt_AlignSetting.Name = "bt_AlignSetting";
            this.bt_AlignSetting.Size = new System.Drawing.Size(130, 45);
            this.bt_AlignSetting.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_AlignSetting.TabIndex = 6;
            this.bt_AlignSetting.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_AlignSetting.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_AlignSetting.TagOffset = 5;
            this.bt_AlignSetting.TagVisible = false;
            this.bt_AlignSetting.TagWidth = 5;
            this.bt_AlignSetting.Text = "Align setting";
            this.bt_AlignSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_AlignSetting.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_AlignSetting.Click += new System.EventHandler(this.bt_AlignSetting_Click);
            // 
            // FormSearchAndAlign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1151, 726);
            this.Controls.Add(this.pcv);
            this.Controls.Add(this.flatPanel1);
            this.Controls.Add(this.lv);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSearchAndAlign";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcv)).EndInit();
            this.flatPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LotusAPI.Controls.PointcloudView pcv;
        private Abeo.Controls.FlatPanel flatPanel1;
        private Abeo.Controls.Roundable.RoundButton bt_ClearDisplay;
        private Abeo.Controls.Roundable.RoundButton bt_Search;
        private Abeo.Controls.Roundable.RoundButton bt_LoadScene;
        private Abeo.Controls.Roundable.RoundButton bt_LoadModel;
        private LotusAPI.Controls.LogView lv;
        private Abeo.Controls.Roundable.RoundButton bt_AlignSetting;
        private Abeo.Controls.Roundable.RoundButton bt_SearchSetting;
    }
}

