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
    class figure
    {
        virtual public void Draw(Panel panel1, Graphics g)
        {
        }

        virtual public bool IsChecked()
        {
            return true;
        }
        virtual public void ColoredTrue()
        {

        }
        virtual public void ColoredFalse()
        {
        }
        virtual public bool isClicked(MouseEventArgs e)
        {
            return true;
        }
        virtual public void chooseColor(int col)
        {

        }
    }

    class Circle : figure
    {
        private int x;
        private int y;
        private int radius;
        private bool Colored;
        private Pen pen;
        Rectangle rec;
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            Colored = true;
        }
        override public void Draw(Panel panel1, Graphics g)
        {
            rec = new Rectangle(x - radius, y - radius, radius * 2, radius * 2);
            if (Colored == true)
            {
                pen = new Pen(Color.Red);
            }
            else
            {
                pen = new Pen(Color.Black);
            }
            g.DrawEllipse(pen, rec);
        }

        override public bool IsChecked()
        {
            return Colored;
        }

        override public bool isClicked(MouseEventArgs e)
        {
            if ((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y) <= radius * radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void ColoredTrue()
        {
            Colored = true;
        }

        public override void ColoredFalse()
        {
            Colored = false;
        }

        public override void chooseColor(int col)
        {
            if (col == 0)
            {
                pen.Color = Color.Black;
            }
            if (col == 1)
            {
                pen.Color = Color.Red;
            }
            if (col == 2)
            {
                pen.Color = Color.Blue;
            }
            if (col == 3)
            {
                pen.Color = Color.Green;
            }
        }
    }

    class MyStorage
    {
        private int size;
        figure[] storage;

        public MyStorage()
        {
            size = 0;
        }
        public MyStorage(int size)
        {
            this.size = size;
            storage = new figure[size];
        }
        public void SetObject(int size, figure Obj)
        {
            storage[size] = Obj;
        }
        public bool IsClicked(MouseEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].isClicked(e) == true)
                {
                    storage[i].ColoredTrue();
                    return true;
                }
            }
            return false;
        }
        public void AddObject(figure Obj)
        {
            figure[] storage2 = new figure[size + 1];
            if (size != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    storage2[i] = storage[i];
                }
            }
            storage = storage2;
            storage[size] = Obj;
            size++;
        }
        public void RemoveObject(int i)
        {
            figure[] storage2 = new figure[size - 1];
            for (int j = 0; j < i; j++)
            {
                storage2[j] = storage[j];
            }
            for (int j = i; j < size - 1; j++)
            {
                storage2[j] = storage[j + 1];
            }
            size = size - 1;
            storage = storage2;
            //storage[0] = null;
            //size = 0;
        }
        public void removeCheckedObject(MyStorage storage)
        {
            for (int i = 0; i < size; i++)
            {
                if (this.storage[i].IsChecked() == true)
                {
                    storage.RemoveObject(i);
                    i = i - 1;
                }
            }
        }

        public void Draww(Panel panel1, Graphics g)
        {
            for (int i = 0; i < size; i++)
            {
                storage[i].Draw(panel1, g);
            }
        }

        public void chooseColor(int col)
        {
            for (int i = 0; i < size; i++)
            {
                storage[i].chooseColor(col);
            }
        }
        public void Highlighting(MouseEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].isClicked(e) == true)
                {
                    storage[i].ColoredTrue();
                    break;
                }
            }

        }
        public void AllNotChecked()
        {
            for (int i = 0; i < size; i++)
            {
                storage[i].ColoredFalse();
            }
        }
    }

}
