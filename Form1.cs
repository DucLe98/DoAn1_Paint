using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PaintApp
{
    public partial class Form1 : Form
    {
       
        List<Point> mouse = new List<Point>();
        int hinh;
        Pen myPen;
        Color myColor;
        int demBenzier = 0;
        bool isStart = false;// Xác định có đang vẽ hay ko
        List<Shape> listShape = new List<Shape>();
        Rectangle rect;
        int fill = 0;
        public Form1()
        {
            InitializeComponent();
            
            myColor = Color.Black;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
          //  myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            myPen = new Pen(Color.Black, 2);
           
                for (int i = 0; i < listShape.Count; i++)
                {
                    myPen = new Pen(listShape[i].mauSac, Convert.ToInt32(listShape[i].doDay));

                switch (listShape[i].kind)
                {
                    case "line":
                        e.Graphics.DrawLine(myPen, listShape[i].p1, listShape[i].p2);
                        break;
                    case "rect":
                        rect = new Rectangle(listShape[i].p1.X, listShape[i].p1.Y, listShape[i].p2.X - listShape[i].p1.X, listShape[i].p2.Y - listShape[i].p1.Y);
                        if (listShape[i].fill == 0)
                            e.Graphics.DrawRectangle(myPen, rect);
                        else
                        {
                            SolidBrush Brush = new SolidBrush(listShape[i].mauSac);
                            e.Graphics.FillRectangle(Brush, rect);
                        }
                        break;
                    case "elip":
                        rect = new Rectangle(listShape[i].p1.X, listShape[i].p1.Y, listShape[i].p2.X - listShape[i].p1.X, listShape[i].p2.Y - listShape[i].p1.Y);
                        if (listShape[i].fill == 0)
                            e.Graphics.DrawEllipse(myPen, rect);
                        else
                        {
                            SolidBrush Brush = new SolidBrush(listShape[i].mauSac);
                            e.Graphics.FillEllipse(Brush, rect);
                        }
                        break;
                    case "square":
                        rect = new Rectangle(listShape[i].p1.X, listShape[i].p1.Y, listShape[i].p2.Y - listShape[i].p1.Y, listShape[i].p2.Y - listShape[i].p1.Y);
                        if(listShape[i].fill == 0)
                        e.Graphics.DrawRectangle(myPen, rect);
                        else
                        {
                            SolidBrush Brush = new SolidBrush(listShape[i].mauSac);
                            e.Graphics.FillRectangle(Brush, rect);
                        }
                        break;
                    case "circle":
                        rect = new Rectangle(listShape[i].p1.X, listShape[i].p1.Y, listShape[i].p2.X - listShape[i].p1.X, listShape[i].p2.X - listShape[i].p1.X);
                        if(listShape[i].fill == 0)
                        e.Graphics.DrawEllipse(myPen, rect);
                        else
                        {
                            SolidBrush Brush = new SolidBrush(listShape[i].mauSac);
                            e.Graphics.FillEllipse(Brush, rect);
                        }
                        break;
                    case "cong":
                            e.Graphics.DrawBezier(myPen, listShape[i].p1, listShape[i].p3, listShape[i].p2, listShape[i].p4);                                             
                        break;
                    case "lucgiac":
                        {
                            Point A = new Point((listShape[i].p1.X + listShape[i].p2.X) / 2, listShape[i].p1.Y);
                            Point B = new Point(listShape[i].p1.X, listShape[i].p1.Y + (listShape[i].p2.Y - listShape[i].p1.Y) /4);
                            Point C = new Point(listShape[i].p1.X, listShape[i].p1.Y + (listShape[i].p2.Y - listShape[i].p1.Y) * 3/4);
                            Point D = new Point((listShape[i].p1.X + listShape[i].p2.X)/2, listShape[i].p2.Y);
                            Point E = new Point(listShape[i].p2.X, listShape[i].p1.Y + (listShape[i].p2.Y - listShape[i].p1.Y) * 3/4);
                            Point F = new Point(listShape[i].p2.X, listShape[i].p1.Y + (listShape[i].p2.Y - listShape[i].p1.Y) /4);
                            Point[] a = { A,B,C,D,E,F };
                            if (listShape[i].fill == 0)
                                e.Graphics.DrawPolygon(myPen, a);
                            else
                            {
                                SolidBrush Brush = new SolidBrush(listShape[i].mauSac);
                                e.Graphics.FillPolygon(Brush, a);
                            }
                            break;
                        }
                    case "tamgiac":
                        {
                            Point A = new Point((listShape[i].p2.X - listShape[i].p1.X)/2, listShape[i].p1.Y);
                            Point B = new Point(listShape[i].p1.X, listShape[i].p2.Y);
                            Point[] a = { A, listShape[i].p2, B  };
                            if (listShape[i].fill == 0)
                                e.Graphics.DrawPolygon(myPen,a);
                            else
                            {
                                SolidBrush Brush = new SolidBrush(listShape[i].mauSac);
                                e.Graphics.FillPolygon(Brush, a);
                            }
                            break;
                        }
                    case "thoi":
                        {
                            Point A = new Point((-listShape[i].p1.X + listShape[i].p2.X)/2, listShape[i].p1.Y );
                            Point B = new Point(listShape[i].p2.X, (listShape[i].p2.Y - listShape[i].p1.Y)/2);
                            Point C = new Point((listShape[i].p2.X - listShape[i].p1.X)/2, listShape[i].p2.Y);
                            Point D = new Point(listShape[i].p1.X, (listShape[i].p2.Y - listShape[i].p1.Y)/2);
                            Point[] a = {D,A,C,B };
                            if (listShape[i].fill == 0)
                            {
                                e.Graphics.DrawPolygon(myPen, a);
                            }
                            else
                            {
                                SolidBrush brush = new SolidBrush(listShape[i].mauSac);
                                e.Graphics.FillPolygon(brush,a);
                            }
                            break;
                        }
                }
                }//RePaint
            
        }

        public void veCham(List<Point>a,Rectangle rect, PaintEventArgs e)
        {
           
            for (int i = 0; i < a.Count; i++)
            {
                rect = new Rectangle(a[i].X, 2, 2, 2);
                e.Graphics.DrawRectangle(myPen,rect);
            }
        }


        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                
                isStart = true;
                switch (hinh)
                {
                    case 1: //duong thang
                {
                    Shape myShape = new Shape();
                    myShape.p1 = e.Location;
                    myShape.p2 = e.Location;
                    myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                    myShape.mauSac = myColor;
                    myShape.kind = "line";
                    myShape.fill = fill;
                    listShape.Add(myShape);
                    break;
                }
                    case 2: //hinh chu nhat
                        {
                    Shape myShape = new Shape(); 
                    myShape.p1 = e.Location;
                    myShape.p2 = e.Location;
                    myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                    myShape.mauSac = myColor;
                    myShape.kind = "rect";
                    myShape.fill = fill;
                    listShape.Add(myShape);
                            break;
                }
                    case 3: //hinh elipsce
                {
                    Shape myShape = new Shape();
                    myShape.p1 = e.Location;
                    myShape.p2 = e.Location;
                    myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                    myShape.mauSac = myColor;
                    myShape.kind = "elip";
                    myShape.fill = fill;
                    listShape.Add(myShape);
                            break;
                }
                    case 4: //hinh vuong
                {
                    Shape myShape = new Shape();
                    myShape.p1 = e.Location;
                    myShape.p2 = e.Location;
                    myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                    myShape.mauSac = myColor;
                    myShape.kind = "square";
                    myShape.fill = fill;
                    listShape.Add(myShape);
                    break;
                }
                    case 5: //hinh tron
                {
                    Shape myShape = new Shape();
                    myShape.p1 = e.Location;
                    myShape.p2 = e.Location;
                    myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                    myShape.mauSac = myColor;
                    myShape.kind = "circle";
                    myShape.fill = fill;
                    listShape.Add(myShape);
                            break;
                }
                    case 6: //bezier
                {
                                Shape myShape = new Shape();
                                myShape.p1 = e.Location;
                                myShape.p2 = e.Location;
                                myShape.p3 = e.Location;
                                myShape.p4 = e.Location;
                                myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                                myShape.mauSac = myColor;
                                myShape.kind = "cong";
                                 myShape.fill = fill;
                                 listShape.Add(myShape);
                            if (demBenzier == 1 || demBenzier == 2)
                            {
                                listShape.Remove(listShape[listShape.Count - 1]);
                            }
                                break;
                            
                }
                    case 7: //luc giac
                        {
                            Shape myShape = new Shape();
                            myShape.p1 = e.Location;
                            myShape.p2 = e.Location;
                            myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                            myShape.mauSac = myColor;
                            myShape.kind = "lucgiac";
                            myShape.fill = fill;
                            listShape.Add(myShape);
                            break;
                        }
                    case 8: //tam giac
                        {
                            Shape myShape = new Shape();
                            myShape.p1 = e.Location;
                            myShape.p2 = e.Location;
                            myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                            myShape.mauSac = myColor;
                            myShape.kind = "tamgiac";
                            myShape.fill = fill;
                            listShape.Add(myShape);
                            break;
                        }
                    case 9: //diamond
                        {
                            Shape myShape = new Shape();
                            myShape.p1 = e.Location;
                            myShape.p2 = e.Location;
                            myShape.doDay = int.Parse(nrDoDay.Value.ToString());
                            myShape.mauSac = myColor;
                            myShape.kind = "thoi";
                            myShape.fill = fill;
                            listShape.Add(myShape);
                            break;
                        }
                }
            }
            catch { }
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (isStart == true)
                {
                    if (hinh == 6)
                    {
                        if (demBenzier == 0)
                        {
                            listShape[listShape.Count - 1].p2 = e.Location;
                            listShape[listShape.Count - 1].p3 = e.Location;
                            listShape[listShape.Count - 1].p4 = e.Location;

                        }
                        if (demBenzier == 1)
                        {
                            listShape[listShape.Count - 1].p2 = e.Location;
                            listShape[listShape.Count - 1].p3 = e.Location;
                        }
                        if (demBenzier == 2)
                        {
                            listShape[listShape.Count - 1].p2 = e.Location;
                        }
                    }
                    else
                    {
                        listShape[listShape.Count - 1].p2 = e.Location;
                    }
                    this.Invalidate();

                }
            }
            catch { }
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            demBenzier++;
            if (demBenzier == 3)
                demBenzier = 0;
                isStart = false;
            this.Invalidate();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pb_color.BackColor = myColor;
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            hinh = 1;
        }

        private void btn_Rec_Click(object sender, EventArgs e)
        {
            hinh = 2;
        }

        private void btn_elip_Click(object sender, EventArgs e)
        {
            hinh = 3;
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            hinh = 4;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            hinh = 5;
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            hinh = 6;
        }

        private void btn_lucGiac_Click(object sender, EventArgs e)
        {
            hinh = 7;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pb_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pb_color.BackColor = myColor = cd.Color;
               
            }
        }

        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (hinh == 6 && mouse.Count <= 4)
            {     
                Point chuot = new Point();
                chuot.X = e.X;
                chuot.Y = e.Y;
                mouse.Add(chuot);
            }
            else
                mouse = new List<Point>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listShape.Clear();
            this.Invalidate();
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            fill = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fill = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hinh = 8;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hinh = 9;
        }
    }
}

