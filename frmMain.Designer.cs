namespace Windows_Power
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labMin = new System.Windows.Forms.Label();
            this.labSec = new System.Windows.Forms.Label();
            this.labHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyBeforeChange = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInfo
            // 
            this.pbInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbInfo.Image = global::Windows_Power.Properties.Resources.information;
            this.pbInfo.Location = new System.Drawing.Point(33, 23);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(47, 57);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 0;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ShutDown",
            "Reboot",
            "Sleep"});
            this.comboBox1.Location = new System.Drawing.Point(200, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Your Power State";
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSetTimer.Enabled = false;
            this.btnSetTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTimer.Location = new System.Drawing.Point(200, 292);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(331, 43);
            this.btnSetTimer.TabIndex = 3;
            this.btnSetTimer.Text = "Set Timer";
            this.btnSetTimer.UseVisualStyleBackColor = false;
            this.btnSetTimer.Click += new System.EventHandler(this.CallTimerFormButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(459, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 53);
            this.label3.TabIndex = 29;
            this.label3.Text = ":";
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Enabled = false;
            this.labMin.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold);
            this.labMin.ForeColor = System.Drawing.Color.Black;
            this.labMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labMin.Location = new System.Drawing.Point(341, 200);
            this.labMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(71, 53);
            this.labMin.TabIndex = 28;
            this.labMin.Text = "00";
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Enabled = false;
            this.labSec.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold);
            this.labSec.ForeColor = System.Drawing.Color.Black;
            this.labSec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labSec.Location = new System.Drawing.Point(532, 200);
            this.labSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(71, 53);
            this.labSec.TabIndex = 27;
            this.labSec.Text = "00";
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Enabled = false;
            this.labHour.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold);
            this.labHour.ForeColor = System.Drawing.Color.Black;
            this.labHour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labHour.Location = new System.Drawing.Point(157, 200);
            this.labHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(71, 53);
            this.labHour.TabIndex = 31;
            this.labHour.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(249, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 53);
            this.label2.TabIndex = 30;
            this.label2.Text = ":";
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("SF Mono", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStop.Location = new System.Drawing.Point(310, 384);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 49);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyBeforeChange
            // 
            this.notifyBeforeChange.Text = "notifyBeforeChange";
            this.notifyBeforeChange.Visible = true;
            this.notifyBeforeChange.BalloonTipClicked += new System.EventHandler(this.notifyBeforeChange_BalloonTipClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSetTimer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Power.Properties.Resources.App_Background_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(772, 484);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.labSec);
            this.Controls.Add(this.labHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pbInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Power";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labHour;
        public System.Windows.Forms.Label labMin;
        public System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyBeforeChange;
        public System.Windows.Forms.Button btnStop;
    }
}