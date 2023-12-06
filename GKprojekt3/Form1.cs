using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using System;
using System.IO;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Drawing;


namespace GKprojekt3
{
    public partial class Form1 : Form
    {
        public bool obramowka = true;
        public int margin = 50;
        public XYZ[] dane = new XYZ[781];
        public bool tlo = true;
        int number = 4;
        double k = 0;
        Color punktu;

        List<Point> controlPoints = new List<Point>();
        int catched;
        bool catchedbool = false;
        XYZ berziew = new XYZ(0, 0, 0);
        public Form1()
        {

            controlPoints = new List<Point>()
    {
       
        new Point(70, 400), 
        new Point(100, 200),
        new Point(150, 500),
         new Point(300, 200)

    };

            //wczytan dane 
            LoadData();
            double starabara = 0.0003;

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void widmo_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;




            Pen arrowPen = new Pen(Brushes.Black, 1)
            {
                CustomEndCap = new AdjustableArrowCap(5, 5)
            };
            g.DrawLine(arrowPen, new Point(margin, widmo.Height - margin), new Point(widmo.Width - margin + 40, widmo.Height - margin)); // Oœ X
            g.DrawLine(arrowPen, new Point(margin, widmo.Height - margin), new Point(margin, margin - 40)); // Oœ Y



            
              //  g.DrawBeziers(Pens.Black, controlPoints.ToArray());
            


            foreach (var point in controlPoints)
            {
                g.FillEllipse(Brushes.Red, new Rectangle(point.X - 5, point.Y - 5, 10, 10));
            }



            for (int i = 0; i <= 8; i++)
            {
                int x = margin + i * (widmo.Width - 2 * margin) / 8 + 20;
                g.DrawLine(Pens.Black, x, widmo.Height - margin - 5, x, widmo.Height - margin + 5);
                g.DrawString((380 + i * 50).ToString(), this.Font, Brushes.Black, x - 15, widmo.Height - margin + 10);
            }


            for (int i = 0; i <= 9; i++)
            {
                int y = widmo.Height - margin - i * (widmo.Height - 2 * margin) / 9;
                g.DrawLine(Pens.Black, margin - 5, y, margin + 5, y);
                g.DrawString((i * 0.2).ToString("F1"), this.Font, Brushes.Black, 5, y - 10);
            }
            SetPoint(g);



        }

        private void podkowa_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (tlo)
            {
                Image img = Properties.Resources.pngwing_com;


                int newWidth = 374;
                int newHeight = 415;


                Rectangle destRect = new Rectangle(margin, 600 - newHeight - margin, newWidth, newHeight);


                e.Graphics.DrawImage(img, destRect);
            }










            if (obramowka)
            {
                for (int i = 380; i <= 700; ++i)
                {

                    XYZ xyz = dane[i];


                    (int R, int G, int B) = ConvertXYZtoRGB(xyz.X, xyz.Y, xyz.Z);


                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B)))
                    {
                        double suma = xyz.X + xyz.Y + xyz.Z;
                        double x = 0; ; double y = 0;
                        if (suma != 0)
                        {
                            x = xyz.X / suma;
                            y = xyz.Y / suma;
                        }


                        int xpunkt = (int)(500 * x + margin);
                        int ypunkt = 600 - (int)(500 * y + margin);


                        e.Graphics.FillEllipse(brush, xpunkt, ypunkt, 8, 8);
                    }
                }
            }

            Pen arrowPen = new Pen(Brushes.Black, 1)
            {
                CustomEndCap = new AdjustableArrowCap(5, 5)
            };
            g.DrawLine(arrowPen, new Point(margin, podkowa.Height - margin), new Point(podkowa.Width - margin + 40, podkowa.Height - margin)); // Oœ X
            g.DrawLine(arrowPen, new Point(margin, podkowa.Height - margin), new Point(margin, margin - 40)); // Oœ Y


            for (int i = 0; i <= 8; i++)
            {
                int x = margin + i * (podkowa.Width - 2 * margin) / 8;
                g.DrawLine(Pens.Black, x, podkowa.Height - margin - 5, x, podkowa.Height - margin + 5);
                g.DrawString((i * 0.1).ToString("F1"), this.Font, Brushes.Black, x - 10, podkowa.Height - margin + 10);

                int y = podkowa.Height - margin - i * (podkowa.Height - 2 * margin) / 8;
                g.DrawLine(Pens.Black, margin - 5, y, margin + 5, y);
                g.DrawString((i * 0.1).ToString("F1"), this.Font, Brushes.Black, 5, y - 10);
            }


            double suma1 = berziew.X + berziew.Y + berziew.Z;
            double x1 = 0; ; double y1 = 0;
            if (suma1 != 0)
            {
                x1 = berziew.X / suma1;
                y1 = berziew.Y / suma1;
            }


            int xpunkt1 = (int)(500 * x1 + margin);
            int ypunkt1 = 600 - (int)(500 * y1 + margin);

            (int R1, int G1, int B1) = ConvertXYZtoRGB(berziew.X / k, berziew.Y / k, berziew.Z / k);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(R1, G1, B1)))
            {
                g.FillEllipse(brush, xpunkt1, ypunkt1, 8, 8);
            }
            e.Graphics.DrawString($"{Math.Round(x1, 3)} {Math.Round(y1, 3)}", new Font("Arial", 8), Brushes.Black, xpunkt1 - 5, ypunkt1 + 7);



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                obramowka = true;
            }
            else
            {
                obramowka = false;
            }
            podkowa.Invalidate();
        }



        private void LoadData()
        {

            using (StringReader reader = new StringReader(Properties.Resources.faletxt))
            {
                string line;
                int index = 380;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ', '\t');


                    double x = double.Parse(parts[1], CultureInfo.InvariantCulture);
                    double y = double.Parse(parts[2], CultureInfo.InvariantCulture);
                    double z = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    k += y;
                    dane[index++] = new XYZ(x, y, z);

                    if (index >= 781) break;
                }
            }


        }









        public (int R, int G, int B) ConvertXYZtoRGB(double X, double Y, double Z)
        {

            double rLinear = 3.2410 * X - 1.5374 * Y - 0.4986 * Z;
            double gLinear = -0.9692 * X + 1.8760 * Y + 0.0416 * Z;
            double bLinear = 0.0556 * X - 0.2040 * Y + 1.0570 * Z;


            double r = rLinear > 0.0031308 ? 1.055 * Math.Pow(rLinear, 1.0 / 2.4) - 0.055 : 12.92 * rLinear;
            double g = gLinear > 0.0031308 ? 1.055 * Math.Pow(gLinear, 1.0 / 2.4) - 0.055 : 12.92 * gLinear;
            double b = bLinear > 0.0031308 ? 1.055 * Math.Pow(bLinear, 1.0 / 2.4) - 0.055 : 12.92 * bLinear;


            int R = (int)(Math.Max(0, Math.Min(1, r)) * 255);
            int G = (int)(Math.Max(0, Math.Min(1, g)) * 255);
            int B = (int)(Math.Max(0, Math.Min(1, b)) * 255);

            return (R, G, B);
        }

        private void widmo_MouseDown(object sender, MouseEventArgs e)
        {

            int i = 0;
            foreach (var points in controlPoints)
            {
                if (e.Y > points.Y - 8 && e.Y < points.Y + 8 && e.X > points.X - 8 && e.X < points.X + 8)
                {
                    catched = i;
                    catchedbool = true;
                }
                i++;
            }



        }

        private void widmo_MouseMove(object sender, MouseEventArgs e)
        {
            if (catchedbool)
            {
                if (e.X > margin + 20 && e.Y > margin && e.Y < 600 - margin && e.X < 570)
                { 

             
                bool canMoveRight = catched == controlPoints.Count - 1 || controlPoints[catched + 1].X > e.X;
                bool canMoveLeft = catched == 0 || controlPoints[catched - 1].X < e.X;
                if (canMoveLeft && canMoveRight)
                {
                    controlPoints[catched] = new Point(e.X, e.Y);
                }

                }

                widmo.Invalidate();
            }
        }

        private void widmo_MouseUp(object sender, MouseEventArgs e)
        {
            catchedbool = false;
        }




        public double Bernstein(int i, int n, double t)
        {

            double binomialCoefficient = 1;
            for (int k = 1; k <= i; k++)
            {
                binomialCoefficient *= (n - (i - k));
                binomialCoefficient /= k;
            }


            return binomialCoefficient * Math.Pow(t, i) * Math.Pow(1 - t, n - i);
        }


        public void SetPoint(Graphics g)
        {
            berziew = new XYZ(0, 0, 0);

            double xpoint1 = controlPoints[0].X;
            double ypoint1 = controlPoints[0].Y;
            double xpointend=controlPoints.Last().X;
            double ypointed = controlPoints.Last().Y;

            int ggg = 0;
            double xpoint2 = 0;
            double ypoint2 = 0;
            //obliczenie punktów bezierewa
            for (double t = 0; t <= 1; t += 0.01)
            {
                int i = 0;
                xpoint2 = 0;
                ypoint2 = 0;
                //obliczenie danego punktu
                foreach (var points in controlPoints)
                {

                    xpoint2 += points.X * Bernstein(i, controlPoints.Count - 1, t);
                    ypoint2 += points.Y * Bernstein(i, controlPoints.Count - 1, t);
                    i++;

                }


             
                // przeksztalcenie na wspoprzedne fali 
                double x1 = (xpoint1 - margin - 20) / 500 * 400 + 380;
                double x2 = (xpoint2 - margin - 20) / 500 * 400 + 380;
                double y1 = ((ypoint1 - margin) / 500 * 1.8);
                double y2 = ((ypoint2 - margin) / 500 * 1.8);

                XYZ p1 = dane[(int)x1];
                XYZ p2 = dane[(int)x2];
                //calkowanie prostokatne punktu srodowego 
                double xm = (x1 + x2) / 2;
                double ym = (y1 + y2) / 2;
                XYZ pm = dane[(int)xm];

                int roznica = Math.Abs((((int)xpoint2 - (int)xpoint1)));
                //wzór 
                berziew.X += pm.X * ym * roznica;
                berziew.Y += pm.Y * ym * roznica;
                berziew.Z += pm.Z * ym * roznica;
                if (ggg==0)
                    ggg = ggg;
                 g.DrawLine(new Pen(Color.Black,2), (int)xpoint1, (int)ypoint1 , (int)xpoint2, (int)ypoint2);

                if (t > 0.5 && berziew.X == 0)
                    t = t;



                //przepisanie punktu do ca³kowania
                xpoint1 = xpoint2;
                ypoint1 = ypoint2;
                ggg++;
            }

            g.DrawLine(new Pen(Color.Black, 2), (int)xpoint1, (int)ypoint1, (int)xpointend, (int)ypointed);
            double suma2 = berziew.X + berziew.Y + berziew.Z;
            double x3 = 0; ; double y3 = 0;
            if (suma2 != 0)
            {
                x3 = berziew.X / suma2;
                y3 = berziew.Y / suma2;
            }


            int xpunkt1 = (int)(500 * x3 + margin);
            int ypunkt1 = 600 - (int)(500 * y3 + margin);

          
            
            podkowa.Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            number = (int)numericUpDown1.Value;
            SetBezierCurveBasic();
            widmo.Refresh();
        }

        private void SetBezierCurveBasic()
        {
            Point start = new Point(500, 500);
            Point end = new Point(150, 500);
            int deltaX = (end.X - start.X) / (number - 1);
            int deltaY = 500;
            controlPoints = new List<Point>();

            for (int i = 0; i < number; i++)
            {
                int x = start.X + deltaX * i;
                int y = start.Y;
                controlPoints.Add(new Point(x, y));
            }
            controlPoints.Reverse();
        }
    }
}
