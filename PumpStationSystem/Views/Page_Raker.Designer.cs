namespace PumpStationSystem
{
    partial class Page_Raker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Raker));
            this.pbCMD = new System.Windows.Forms.PictureBox();
            this.btFaultVSD = new System.Windows.Forms.Button();
            this.pbFaultVSD = new System.Windows.Forms.PictureBox();
            this.btRunFeedback = new System.Windows.Forms.Button();
            this.pbRunFeedback = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.tbFaultVSBModbus = new System.Windows.Forms.TextBox();
            this.pbBreak = new System.Windows.Forms.PictureBox();
            this.btBreak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaultVSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCMD
            // 
            this.pbCMD.Location = new System.Drawing.Point(290, 145);
            this.pbCMD.Margin = new System.Windows.Forms.Padding(2);
            this.pbCMD.Name = "pbCMD";
            this.pbCMD.Size = new System.Drawing.Size(23, 23);
            this.pbCMD.TabIndex = 39;
            this.pbCMD.TabStop = false;
            // 
            // btFaultVSD
            // 
            this.btFaultVSD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFaultVSD.Location = new System.Drawing.Point(251, 120);
            this.btFaultVSD.Margin = new System.Windows.Forms.Padding(2);
            this.btFaultVSD.Name = "btFaultVSD";
            this.btFaultVSD.Size = new System.Drawing.Size(23, 23);
            this.btFaultVSD.TabIndex = 38;
            this.btFaultVSD.UseVisualStyleBackColor = false;
            this.btFaultVSD.Click += new System.EventHandler(this.btFaultVSD_Click);
            // 
            // pbFaultVSD
            // 
            this.pbFaultVSD.Location = new System.Drawing.Point(290, 120);
            this.pbFaultVSD.Margin = new System.Windows.Forms.Padding(2);
            this.pbFaultVSD.Name = "pbFaultVSD";
            this.pbFaultVSD.Size = new System.Drawing.Size(23, 23);
            this.pbFaultVSD.TabIndex = 37;
            this.pbFaultVSD.TabStop = false;
            // 
            // btRunFeedback
            // 
            this.btRunFeedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRunFeedback.Location = new System.Drawing.Point(251, 95);
            this.btRunFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.btRunFeedback.Name = "btRunFeedback";
            this.btRunFeedback.Size = new System.Drawing.Size(23, 23);
            this.btRunFeedback.TabIndex = 36;
            this.btRunFeedback.UseVisualStyleBackColor = false;
            this.btRunFeedback.Click += new System.EventHandler(this.btRunFeedback_Click);
            // 
            // pbRunFeedback
            // 
            this.pbRunFeedback.Location = new System.Drawing.Point(290, 95);
            this.pbRunFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.pbRunFeedback.Name = "pbRunFeedback";
            this.pbRunFeedback.Size = new System.Drawing.Size(23, 23);
            this.pbRunFeedback.TabIndex = 35;
            this.pbRunFeedback.TabStop = false;
            // 
            // pbStop
            // 
            this.pbStop.Location = new System.Drawing.Point(290, 70);
            this.pbStop.Margin = new System.Windows.Forms.Padding(2);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(23, 23);
            this.pbStop.TabIndex = 33;
            this.pbStop.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.Location = new System.Drawing.Point(290, 45);
            this.pbStart.Margin = new System.Windows.Forms.Padding(2);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(23, 23);
            this.pbStart.TabIndex = 31;
            this.pbStart.TabStop = false;
            // 
            // tbFaultVSBModbus
            // 
            this.tbFaultVSBModbus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbFaultVSBModbus.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFaultVSBModbus.ForeColor = System.Drawing.Color.GreenYellow;
            this.tbFaultVSBModbus.Location = new System.Drawing.Point(251, 172);
            this.tbFaultVSBModbus.Margin = new System.Windows.Forms.Padding(2);
            this.tbFaultVSBModbus.Multiline = true;
            this.tbFaultVSBModbus.Name = "tbFaultVSBModbus";
            this.tbFaultVSBModbus.Size = new System.Drawing.Size(77, 25);
            this.tbFaultVSBModbus.TabIndex = 88;
            // 
            // pbBreak
            // 
            this.pbBreak.Location = new System.Drawing.Point(70, 113);
            this.pbBreak.Margin = new System.Windows.Forms.Padding(2);
            this.pbBreak.Name = "pbBreak";
            this.pbBreak.Size = new System.Drawing.Size(30, 30);
            this.pbBreak.TabIndex = 92;
            this.pbBreak.TabStop = false;
            // 
            // btBreak
            // 
            this.btBreak.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btBreak.Location = new System.Drawing.Point(39, 113);
            this.btBreak.Margin = new System.Windows.Forms.Padding(2);
            this.btBreak.Name = "btBreak";
            this.btBreak.Size = new System.Drawing.Size(30, 30);
            this.btBreak.TabIndex = 91;
            this.btBreak.Text = "Brk";
            this.btBreak.UseVisualStyleBackColor = false;
            this.btBreak.Click += new System.EventHandler(this.btBreak_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Page_Raker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 211);
            this.Controls.Add(this.pbBreak);
            this.Controls.Add(this.btBreak);
            this.Controls.Add(this.tbFaultVSBModbus);
            this.Controls.Add(this.pbCMD);
            this.Controls.Add(this.btFaultVSD);
            this.Controls.Add(this.pbFaultVSD);
            this.Controls.Add(this.btRunFeedback);
            this.Controls.Add(this.pbRunFeedback);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.pbStart);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "Page_Raker";
            this.Text = "Page_Raker";
            this.FormClosed += Page_Raker_FormClosed;
            this.FormClosing += Page_Raker_FormClosing;
            this.Load += new System.EventHandler(this.Page_Raker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaultVSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Page_Raker_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            StopTimer1();
        }

        private void Page_Raker_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        #endregion
        private System.Windows.Forms.PictureBox pbCMD;
        private System.Windows.Forms.Button btFaultVSD;
        private System.Windows.Forms.PictureBox pbFaultVSD;
        private System.Windows.Forms.Button btRunFeedback;
        private System.Windows.Forms.PictureBox pbRunFeedback;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.TextBox tbFaultVSBModbus;
        private System.Windows.Forms.PictureBox pbBreak;
        private System.Windows.Forms.Button btBreak;
        private System.Windows.Forms.Timer timer1;
    }
}