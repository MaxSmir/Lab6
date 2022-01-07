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
        virtual public void Move(KeyEventArgs e)
        {
        }
        virtual public void Size(KeyEventArgs e)
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
        private SolidBrush brush;
        Rectangle rec;
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            brush = new SolidBrush(Color.White);
            pen = new Pen(Color.White);
        }
        override public void Draw(Panel panel1, Graphics g)
        {
            rec = new Rectangle(x - radius, y - radius, radius * 2, radius * 2);
            if (Colored == true)
            {
                pen.Color = Color.Red;
            }
            else
            {
                pen.Color = Color.Black;
            }
            //if (col == 0) 
            //{
            //    pen = new Pen(Color.Black);
            //}
            //if (col == 1)
            //{
            //    pen = new Pen(Color.Red);
            //}
            //if (col == 2)
            //{
            //    pen = new Pen(Color.Blue);
            //}
            //if (col == 3)
            //{
            //    pen = new Pen(Color.DarkGreen); //mojno tok kak hz
            //}
            g.FillEllipse(brush, rec);
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

        public override void Size(KeyEventArgs e)
        {
            if (e.KeyValue == 107)
            {
                radius = radius + 10;
            }
            if (e.KeyValue == 109)
            {
                radius = radius - 10;
            }

        }
        override public void Move(KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                x = x - 5;
            }
            if (e.KeyValue == 39)
            {
                x = x + 5;
            }
            if (e.KeyValue == 38)
            {
                y = y - 5;
            }
            if (e.KeyValue == 40)
            {
                y = y + 5;
            }
        }

        public override void chooseColor(int col)
        {

            if (col == 1)
            {
                brush.Color = Color.Black;
            }
            if (col == 2)
            {
                brush.Color = Color.Red;
            }
            if (col == 3)
            {
                brush.Color = Color.Blue;
            }
            if (col == 4)
            {
                brush.Color = Color.Green;
            }
        }
    }

    class sqare : figure
    {
        private int x;
        private int y;
        private int a;
        private bool Colored;
        private SolidBrush brush;
        private Pen pen;
        public sqare(int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            brush = new SolidBrush(Color.White);
        }

        override public void Draw(Panel panel1, Graphics g)
        {
            Rectangle rec = new Rectangle(x - a, y - a, a * 2, a * 2);
            if (Colored == true)
            {
                pen = new Pen(Color.Red);
            }
            else
            {
                pen = new Pen(Color.Black);
            }
            g.FillRectangle(brush, rec);
            g.DrawRectangle(pen, rec);
        }
        public override void Size(KeyEventArgs e)
        {

            if (e.KeyValue == 107)
            {
                a = a + 10;
            }
            if (e.KeyValue == 109)
            {
                a = a - 10;
            }
        }
        override public void Move(KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                x = x - 5;
            }
            if (e.KeyValue == 39)
            {
                x = x + 5;
            }
            if (e.KeyValue == 38)
            {
                y = y - 5;
            }
            if (e.KeyValue == 40)
            {
                y = y + 5;
            }
        }
        public override void chooseColor(int col)
        {

            if (col == 1)
            {
                brush.Color = Color.Black;
            }
            if (col == 2)
            {
                brush.Color = Color.Red;
            }
            if (col == 3)
            {
                brush.Color = Color.Blue;
            }
            if (col == 4)
            {
                brush.Color = Color.Green;
            }
        }
        public override bool IsChecked()
        {
            return Colored;
        }

        public override bool isClicked(MouseEventArgs e)
        {
            if (e.X >= x - a && e.Y >= y - a && e.X <= x + a && e.Y <= y + a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void ColoredFalse()
        {
            Colored = false;
        }
        public override void ColoredTrue()
        {
            Colored = true;
        }
    }

    class triangle : figure
    {
        private int x;
        private int y;
        private int a;
        private Point[] points;
        private bool Colored;
        private Pen pen;
        private SolidBrush brush;
        public triangle(int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            brush = new SolidBrush(Color.White);
            points = new Point[3];
            points[0].X = x; points[0].Y = y - a;
            points[1].X = x - a; points[1].Y = y + a;
            points[2].X = x + a; points[2].Y = y + a;
        }

        override public void Draw(Panel panel1, Graphics g)
        {
            if (Colored == true)
            {
                pen = new Pen(Color.Red);
            }
            else
            {
                pen = new Pen(Color.Black);
            }
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }
        public override void Size(KeyEventArgs e)
        {
            if (e.KeyValue == 107)
            {
                points[0].X = points[0].X; points[0].Y = points[0].Y - 10;
                points[1].X = points[1].X - 10; points[1].Y = points[1].Y + 10;
                points[2].X = points[2].X + 10; points[2].Y = points[2].Y + 10;
            }
            if (e.KeyValue == 109)
            {
                points[0].X = points[0].X; points[0].Y = points[0].Y + 10;
                points[1].X = points[1].X + 10; points[1].Y = points[1].Y - 10;
                points[2].X = points[2].X - 10; points[2].Y = points[2].Y - 10;
            }
        }
        override public void Move(KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                points[0].X = points[0].X - 5; points[0].Y = points[0].Y;
                points[1].X = points[1].X - 5; points[1].Y = points[1].Y;
                points[2].X = points[2].X - 5; points[2].Y = points[2].Y;
            }
            if (e.KeyValue == 39)
            {
                points[0].X = points[0].X + 5; points[0].Y = points[0].Y;
                points[1].X = points[1].X + 5; points[1].Y = points[1].Y;
                points[2].X = points[2].X + 5; points[2].Y = points[2].Y;
            }
            if (e.KeyValue == 38)
            {
                points[0].X = points[0].X; points[0].Y = points[0].Y - 5;
                points[1].X = points[1].X; points[1].Y = points[1].Y - 5;
                points[2].X = points[2].X; points[2].Y = points[2].Y - 5;
            }
            if (e.KeyValue == 40)
            {
                points[0].X = points[0].X; points[0].Y = points[0].Y + 5;
                points[1].X = points[1].X; points[1].Y = points[1].Y + 5;
                points[2].X = points[2].X; points[2].Y = points[2].Y + 5;
            }
        }
        public override void chooseColor(int col)
        {

            if (col == 1)
            {
                brush.Color = Color.Black;
            }
            if (col == 2)
            {
                brush.Color = Color.Red;
            }
            if (col == 3)
            {
                brush.Color = Color.Blue;
            }
            if (col == 4)
            {
                brush.Color = Color.Green;
            }
        }

        public override bool IsChecked()
        {
            return Colored;
        }
        public override bool isClicked(MouseEventArgs e)
        {
            if (e.X >= x - a && e.Y >= y - a && e.X <= x + a && e.Y <= y + a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void ColoredFalse()
        {
            Colored = false;
        }
        public override void ColoredTrue()
        {
            Colored = true;
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
        public void Size(KeyEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    storage[i].Size(e);
                }
            }
        }
        public void Move(KeyEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    storage[i].Move(e);
                }
            }
        }
        public void chooseColor(int col)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    storage[i].chooseColor(col);
                }
            }
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
