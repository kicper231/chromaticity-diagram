namespace GKprojekt3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            widmo = new PictureBox();
            podkowa = new PictureBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)widmo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podkowa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // widmo
            // 
            widmo.BackColor = SystemColors.ButtonFace;
            widmo.Location = new Point(21, 24);
            widmo.Name = "widmo";
            widmo.Size = new Size(600, 600);
            widmo.TabIndex = 0;
            widmo.TabStop = false;
            widmo.Click += pictureBox1_Click;
            widmo.Paint += widmo_Paint;
            widmo.MouseDown += widmo_MouseDown;
            widmo.MouseMove += widmo_MouseMove;
            widmo.MouseUp += widmo_MouseUp;
            // 
            // podkowa
            // 
            podkowa.BackColor = SystemColors.ButtonFace;
            podkowa.Location = new Point(640, 24);
            podkowa.Name = "podkowa";
            podkowa.Size = new Size(600, 600);
            podkowa.TabIndex = 1;
            podkowa.TabStop = false;
            podkowa.Paint += podkowa_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(1096, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "obramowanie";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(514, 61);
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 38);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Liczba Punktów";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1252, 636);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(podkowa);
            Controls.Add(widmo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)widmo).EndInit();
            ((System.ComponentModel.ISupportInitialize)podkowa).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox widmo;
        private PictureBox podkowa;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}
