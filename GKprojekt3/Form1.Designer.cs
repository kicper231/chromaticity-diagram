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
            label2 = new Label();
            label3 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)widmo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podkowa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 54);
            label2.Name = "label2";
            label2.Size = new Size(134, 34);
            label2.TabIndex = 5;
            label2.Text = "WIDMO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(852, 52);
            label3.Name = "label3";
            label3.Size = new Size(181, 34);
            label3.TabIndex = 6;
            label3.Text = "PODKOWA";
            // 
            // button1
            // 
            button1.Location = new Point(1096, 85);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 7;
            button1.Text = "Zapisz obrazek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1137, 120);
            button2.Name = "button2";
            button2.Size = new Size(82, 52);
            button2.TabIndex = 8;
            button2.Text = "Wybierz Kolor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1096, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 48);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1252, 636);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(podkowa);
            Controls.Add(widmo);
            Name = "Form1";
            Text = "PROJEKT 0";
            ((System.ComponentModel.ISupportInitialize)widmo).EndInit();
            ((System.ComponentModel.ISupportInitialize)podkowa).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox widmo;
        private PictureBox podkowa;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private ColorDialog colorDialog1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
