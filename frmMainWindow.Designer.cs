namespace RemotePlayMasher_2020
{
    partial class frmMainWindow
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
            this.btnStart = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblMoreButtonsComing = new System.Windows.Forms.Label();
            this.lblButtonPresses = new System.Windows.Forms.Label();
            this.numTimesPerSecond = new System.Windows.Forms.NumericUpDown();
            this.lblWhichButton = new System.Windows.Forms.Label();
            this.picTriangle = new System.Windows.Forms.PictureBox();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.picSquare = new System.Windows.Forms.PictureBox();
            this.picCross = new System.Windows.Forms.PictureBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblWindowFocus = new System.Windows.Forms.Label();
            this.cboWindowFocus = new System.Windows.Forms.ComboBox();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPerSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(296, 169);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.lblMoreButtonsComing);
            this.grpOptions.Controls.Add(this.lblButtonPresses);
            this.grpOptions.Controls.Add(this.numTimesPerSecond);
            this.grpOptions.Controls.Add(this.lblWhichButton);
            this.grpOptions.Controls.Add(this.picTriangle);
            this.grpOptions.Controls.Add(this.picCircle);
            this.grpOptions.Controls.Add(this.picSquare);
            this.grpOptions.Controls.Add(this.picCross);
            this.grpOptions.Controls.Add(this.lblNotice);
            this.grpOptions.Controls.Add(this.lblWindowFocus);
            this.grpOptions.Controls.Add(this.btnStart);
            this.grpOptions.Controls.Add(this.cboWindowFocus);
            this.grpOptions.Location = new System.Drawing.Point(12, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(483, 227);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Masher Options";
            // 
            // lblMoreButtonsComing
            // 
            this.lblMoreButtonsComing.AutoSize = true;
            this.lblMoreButtonsComing.Location = new System.Drawing.Point(245, 81);
            this.lblMoreButtonsComing.Name = "lblMoreButtonsComing";
            this.lblMoreButtonsComing.Size = new System.Drawing.Size(220, 15);
            this.lblMoreButtonsComing.TabIndex = 10;
            this.lblMoreButtonsComing.Text = "Might implement other buttons one day";
            // 
            // lblButtonPresses
            // 
            this.lblButtonPresses.AutoSize = true;
            this.lblButtonPresses.Location = new System.Drawing.Point(184, 125);
            this.lblButtonPresses.Name = "lblButtonPresses";
            this.lblButtonPresses.Size = new System.Drawing.Size(166, 15);
            this.lblButtonPresses.TabIndex = 9;
            this.lblButtonPresses.Text = "~ Button Presses Per Second";
            // 
            // numTimesPerSecond
            // 
            this.numTimesPerSecond.Location = new System.Drawing.Point(117, 123);
            this.numTimesPerSecond.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTimesPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimesPerSecond.Name = "numTimesPerSecond";
            this.numTimesPerSecond.Size = new System.Drawing.Size(61, 20);
            this.numTimesPerSecond.TabIndex = 8;
            this.numTimesPerSecond.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblWhichButton
            // 
            this.lblWhichButton.AutoSize = true;
            this.lblWhichButton.Location = new System.Drawing.Point(82, 81);
            this.lblWhichButton.Name = "lblWhichButton";
            this.lblWhichButton.Size = new System.Drawing.Size(96, 15);
            this.lblWhichButton.TabIndex = 7;
            this.lblWhichButton.Text = "Button To Mash:";
            // 
            // picTriangle
            // 
            this.picTriangle.Image = global::RemotePlayMasher_2020.Properties.Resources.Triangle;
            this.picTriangle.Location = new System.Drawing.Point(331, 72);
            this.picTriangle.Name = "picTriangle";
            this.picTriangle.Size = new System.Drawing.Size(32, 32);
            this.picTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTriangle.TabIndex = 6;
            this.picTriangle.TabStop = false;
            this.picTriangle.Visible = false;
            this.picTriangle.Click += new System.EventHandler(this.picButtonClicked);
            // 
            // picCircle
            // 
            this.picCircle.Image = global::RemotePlayMasher_2020.Properties.Resources.Circle;
            this.picCircle.Location = new System.Drawing.Point(289, 72);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(32, 32);
            this.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCircle.TabIndex = 5;
            this.picCircle.TabStop = false;
            this.picCircle.Visible = false;
            this.picCircle.Click += new System.EventHandler(this.picButtonClicked);
            // 
            // picSquare
            // 
            this.picSquare.Image = global::RemotePlayMasher_2020.Properties.Resources.Square;
            this.picSquare.Location = new System.Drawing.Point(248, 72);
            this.picSquare.Name = "picSquare";
            this.picSquare.Size = new System.Drawing.Size(32, 32);
            this.picSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSquare.TabIndex = 4;
            this.picSquare.TabStop = false;
            this.picSquare.Visible = false;
            this.picSquare.Click += new System.EventHandler(this.picButtonClicked);
            // 
            // picCross
            // 
            this.picCross.Image = global::RemotePlayMasher_2020.Properties.Resources.Cross;
            this.picCross.Location = new System.Drawing.Point(207, 72);
            this.picCross.Name = "picCross";
            this.picCross.Size = new System.Drawing.Size(32, 32);
            this.picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCross.TabIndex = 3;
            this.picCross.TabStop = false;
            this.picCross.Click += new System.EventHandler(this.picButtonClicked);
            // 
            // lblNotice
            // 
            this.lblNotice.Location = new System.Drawing.Point(40, 177);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(195, 36);
            this.lblNotice.TabIndex = 2;
            this.lblNotice.Text = "Press BACKSPACE to cancel the mashing at any time";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWindowFocus
            // 
            this.lblWindowFocus.AutoSize = true;
            this.lblWindowFocus.Location = new System.Drawing.Point(6, 38);
            this.lblWindowFocus.Name = "lblWindowFocus";
            this.lblWindowFocus.Size = new System.Drawing.Size(90, 15);
            this.lblWindowFocus.TabIndex = 1;
            this.lblWindowFocus.Text = "Window Focus:";
            // 
            // cboWindowFocus
            // 
            this.cboWindowFocus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWindowFocus.FormattingEnabled = true;
            this.cboWindowFocus.Items.AddRange(new object[] {
            "Focus PS Remote Play Window (Reliable)",
            "Do NOT Focus PS Remote Play Window (Less Reliable)"});
            this.cboWindowFocus.Location = new System.Drawing.Point(109, 35);
            this.cboWindowFocus.Name = "cboWindowFocus";
            this.cboWindowFocus.Size = new System.Drawing.Size(368, 21);
            this.cboWindowFocus.TabIndex = 0;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 251);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.Text = "PS Remote Play Button Masher";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPerSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblWindowFocus;
        private System.Windows.Forms.ComboBox cboWindowFocus;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.PictureBox picTriangle;
        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.PictureBox picSquare;
        private System.Windows.Forms.PictureBox picCross;
        private System.Windows.Forms.Label lblWhichButton;
        private System.Windows.Forms.Label lblButtonPresses;
        private System.Windows.Forms.NumericUpDown numTimesPerSecond;
        private System.Windows.Forms.Label lblMoreButtonsComing;
    }
}

