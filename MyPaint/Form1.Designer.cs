namespace MyPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор толщины";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(0, 55);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 115);
            this.panel2.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(114, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 30);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(78, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cyan;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(42, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(6, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(114, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(78, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(42, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private TrackBar trackBar1;
        private Panel panel2;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}