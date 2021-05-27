namespace SubmarineGame
{
    partial class Form1
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
        /// Required method for Designer support
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelLev = new System.Windows.Forms.Label();
            this.textBoxLev = new System.Windows.Forms.NumericUpDown();
            this.groupBoxBorad = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLev)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(21, 38);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(71, 17);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Width (X):";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(120, 38);
            this.textBoxX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.textBoxX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 23);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(21, 79);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(76, 17);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Height (Y):";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(120, 76);
            this.textBoxY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.textBoxY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 23);
            this.textBoxY.TabIndex = 3;
            this.textBoxY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(63, 160);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(72, 36);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // labelLev
            // 
            this.labelLev.AutoSize = true;
            this.labelLev.Location = new System.Drawing.Point(21, 123);
            this.labelLev.Name = "labelLev";
            this.labelLev.Size = new System.Drawing.Size(46, 17);
            this.labelLev.TabIndex = 5;
            this.labelLev.Text = "Level:";
            // 
            // textBoxLev
            // 
            this.textBoxLev.Location = new System.Drawing.Point(120, 117);
            this.textBoxLev.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.textBoxLev.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxLev.Name = "textBoxLev";
            this.textBoxLev.Size = new System.Drawing.Size(100, 23);
            this.textBoxLev.TabIndex = 6;
            this.textBoxLev.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxLev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // groupBoxBorad
            // 
            this.groupBoxBorad.AutoSize = true;
            this.groupBoxBorad.Location = new System.Drawing.Point(253, 40);
            this.groupBoxBorad.Name = "groupBoxBorad";
            this.groupBoxBorad.Size = new System.Drawing.Size(328, 190);
            this.groupBoxBorad.TabIndex = 7;
            this.groupBoxBorad.TabStop = false;
            this.groupBoxBorad.Text = "board";
            this.groupBoxBorad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.groupBoxBorad);
            this.Controls.Add(this.textBoxLev);
            this.Controls.Add(this.labelLev);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(928, 606);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submarine Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.textBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown textBoxX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.NumericUpDown textBoxY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelLev;
        private System.Windows.Forms.NumericUpDown textBoxLev;
        private System.Windows.Forms.GroupBox groupBoxBorad;
    }
}

