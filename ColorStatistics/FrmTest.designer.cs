namespace ColorStatistics
{
    partial class FrmTest
    {
        /// <summary>
        /// Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources that are in use.
        /// </summary>
        /// <param name="disposing">True if the managed resource should be released; otherwise false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form designer generated code

        /// <summary>
        /// The designer supports the required method - Do not use a code editor to modify the contents of this method.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.CmdOpen = new System.Windows.Forms.Button();
            this.PicColors = new System.Windows.Forms.PictureBox();
            this.Thumb = new System.Windows.Forms.PictureBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CmdProcess = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SliderColorAmount = new System.Windows.Forms.TrackBar();
            this.LblAmount = new System.Windows.Forms.Label();
            this.LblDelta = new System.Windows.Forms.Label();
            this.SliderDelta = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderColorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderDelta)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(12, 13);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(75, 25);
            this.CmdOpen.TabIndex = 1;
            this.CmdOpen.Text = "Open image";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // PicColors
            // 
            this.PicColors.Location = new System.Drawing.Point(485, 13);
            this.PicColors.Name = "PicColors";
            this.PicColors.Size = new System.Drawing.Size(326, 456);
            this.PicColors.TabIndex = 2;
            this.PicColors.TabStop = false;
            this.PicColors.Click += new System.EventHandler(this.PicR_Click);
            this.PicColors.Paint += new System.Windows.Forms.PaintEventHandler(this.PicR_Paint);
            // 
            // Thumb
            // 
            this.Thumb.Image = global::ColorStatistics.Properties.Resources._170530_0069;
            this.Thumb.Location = new System.Drawing.Point(15, 140);
            this.Thumb.Name = "Thumb";
            this.Thumb.Size = new System.Drawing.Size(453, 325);
            this.Thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Thumb.TabIndex = 3;
            this.Thumb.TabStop = false;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(200, 18);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 13);
            this.LblStatus.TabIndex = 4;
            // 
            // CmdProcess
            // 
            this.CmdProcess.Location = new System.Drawing.Point(103, 13);
            this.CmdProcess.Name = "CmdProcess";
            this.CmdProcess.Size = new System.Drawing.Size(75, 25);
            this.CmdProcess.TabIndex = 5;
            this.CmdProcess.Text = "Process";
            this.CmdProcess.UseVisualStyleBackColor = true;
            this.CmdProcess.Click += new System.EventHandler(this.CmdDeal_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 55);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(96, 13);
            this.Label.TabIndex = 6;
            this.Label.Text = "# of primary colors:";
            // 
            // SliderColorAmount
            // 
            this.SliderColorAmount.Location = new System.Drawing.Point(116, 50);
            this.SliderColorAmount.Maximum = 20;
            this.SliderColorAmount.Minimum = 1;
            this.SliderColorAmount.Name = "SliderColorAmount";
            this.SliderColorAmount.Size = new System.Drawing.Size(301, 45);
            this.SliderColorAmount.TabIndex = 7;
            this.SliderColorAmount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderColorAmount.Value = 20;
            this.SliderColorAmount.Scroll += new System.EventHandler(this.SliderColorAmount_Scroll);
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(423, 55);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(19, 13);
            this.LblAmount.TabIndex = 8;
            this.LblAmount.Text = "20";
            // 
            // LblDelta
            // 
            this.LblDelta.AutoSize = true;
            this.LblDelta.Location = new System.Drawing.Point(423, 94);
            this.LblDelta.Name = "LblDelta";
            this.LblDelta.Size = new System.Drawing.Size(19, 13);
            this.LblDelta.TabIndex = 11;
            this.LblDelta.Text = "24";
            // 
            // SliderDelta
            // 
            this.SliderDelta.Location = new System.Drawing.Point(116, 89);
            this.SliderDelta.Maximum = 128;
            this.SliderDelta.Minimum = 1;
            this.SliderDelta.Name = "SliderDelta";
            this.SliderDelta.Size = new System.Drawing.Size(301, 45);
            this.SliderDelta.TabIndex = 10;
            this.SliderDelta.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderDelta.Value = 24;
            this.SliderDelta.Scroll += new System.EventHandler(this.SliderDelta_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delta：";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 488);
            this.Controls.Add(this.LblDelta);
            this.Controls.Add(this.SliderDelta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.SliderColorAmount);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.CmdProcess);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.Thumb);
            this.Controls.Add(this.PicColors);
            this.Controls.Add(this.CmdOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Statistics";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderColorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderDelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.PictureBox PicColors;
        private System.Windows.Forms.PictureBox Thumb;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button CmdProcess;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TrackBar SliderColorAmount;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label LblDelta;
        private System.Windows.Forms.TrackBar SliderDelta;
        private System.Windows.Forms.Label label2;
    }
}

