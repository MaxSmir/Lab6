using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int figure = 1;
        int col = 0;
        MyStorage Storage = new MyStorage();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            if (Storage.IsClicked(e) == false)
            {
                Storage.AllNotChecked();
                if (figure == 1)
                {
                    Storage.AddObject(new Circle(e.X, e.Y, 40));
                }
                if (figure == 2)
                {
                    Storage.AddObject(new sqare(e.X, e.Y, 30));
                }
                if (figure == 3)
                {
                    Storage.AddObject(new triangle(e.X, e.Y, 40));
                }
            }
            else
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    Storage.Highlighting(e);
                }
                else
                {
                    Storage.AllNotChecked();
                    Storage.Highlighting(e);
                }
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Graphics g = panel1.CreateGraphics();
                Storage.removeCheckedObject(Storage);
                g.Clear(Color.White);
                Refresh();
            }

        }
        private void black_Click(object sender, EventArgs e)
        {
            col = 0;
        }

        private void red_Click(object sender, EventArgs e)
        {
            col = 1;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            col = 2;
        }

        private void green_Click(object sender, EventArgs e)
        {
            col = 3;
        }




        private void circle_Click(object sender, EventArgs e)
        {
            figure = 1;
        }

        private void square_Click(object sender, EventArgs e)
        {
            figure = 2;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            figure = 3;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Storage.Draww(panel1, g);
        }
    }

}
