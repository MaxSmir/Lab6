
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.square = new System.Windows.Forms.PictureBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 581);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.triangle);
            this.panel2.Controls.Add(this.square);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Controls.Add(this.red);
            this.panel2.Controls.Add(this.green);
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.black);
            this.panel2.Location = new System.Drawing.Point(787, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 360);
            this.panel2.TabIndex = 1;
            // 
            // triangle
            // 
            this.triangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangle.Image = global::Lab6.Properties.Resources.треугольник;
            this.triangle.Location = new System.Drawing.Point(228, 162);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(85, 85);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangle.TabIndex = 8;
            this.triangle.TabStop = false;
            // 
            // square
            // 
            this.square.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square.Image = global::Lab6.Properties.Resources.квадрат;
            this.square.Location = new System.Drawing.Point(119, 162);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(85, 85);
            this.square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.square.TabIndex = 7;
            this.square.TabStop = false;
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circle.Image = global::Lab6.Properties.Resources.круг;
            this.circle.Location = new System.Drawing.Point(12, 162);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(85, 85);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle.TabIndex = 4;
            this.circle.TabStop = false;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red.Location = new System.Drawing.Point(94, 28);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 50);
            this.red.TabIndex = 3;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green.Location = new System.Drawing.Point(258, 28);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(55, 50);
            this.green.TabIndex = 2;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue.Location = new System.Drawing.Point(176, 28);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(55, 50);
            this.blue.TabIndex = 1;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.black.Location = new System.Drawing.Point(12, 28);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(55, 50);
            this.black.TabIndex = 0;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.PictureBox square;
    }
}

