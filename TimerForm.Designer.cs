namespace Windows_Power
{
    partial class frmTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.label3 = new System.Windows.Forms.Label();
            this.labTMin = new System.Windows.Forms.Label();
            this.labTSec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labTHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpDownSec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.UpDownMin = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // labTMin
            // 
            resources.ApplyResources(this.labTMin, "labTMin");
            this.labTMin.ForeColor = System.Drawing.Color.Black;
            this.labTMin.Name = "labTMin";
            this.labTMin.Tag = "0";
            // 
            // labTSec
            // 
            resources.ApplyResources(this.labTSec, "labTSec");
            this.labTSec.ForeColor = System.Drawing.Color.Black;
            this.labTSec.Name = "labTSec";
            this.labTSec.Tag = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpDownHour
            // 
            resources.ApplyResources(this.UpDownHour, "UpDownHour");
            this.UpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.UpDownHour.Name = "UpDownHour";
            this.UpDownHour.Tag = "Hour";
            this.UpDownHour.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // labTHour
            // 
            resources.ApplyResources(this.labTHour, "labTHour");
            this.labTHour.ForeColor = System.Drawing.Color.Black;
            this.labTHour.Name = "labTHour";
            this.labTHour.Tag = "0";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // UpDownSec
            // 
            resources.ApplyResources(this.UpDownSec, "UpDownSec");
            this.UpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.UpDownSec.Name = "UpDownSec";
            this.UpDownSec.Tag = "Sec";
            this.UpDownSec.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Name = "label";
            // 
            // UpDownMin
            // 
            resources.ApplyResources(this.UpDownMin, "UpDownMin");
            this.UpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.UpDownMin.Name = "UpDownMin";
            this.UpDownMin.Tag = "Min";
            this.UpDownMin.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnRest, "btnRest");
            this.btnRest.ForeColor = System.Drawing.Color.Black;
            this.btnRest.Name = "btnRest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // frmTimer
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Windows_Power.Properties.Resources.App_Background_;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labTMin);
            this.Controls.Add(this.labTSec);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.UpDownHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpDownSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.UpDownMin);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmTimer";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Label labTHour;
        public System.Windows.Forms.Label labTMin;
        public System.Windows.Forms.Label labTSec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRest;
        public System.Windows.Forms.NumericUpDown UpDownMin;
        public System.Windows.Forms.NumericUpDown UpDownHour;
        public System.Windows.Forms.NumericUpDown UpDownSec;
    }
}

