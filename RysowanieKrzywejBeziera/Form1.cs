/*
 * Coding: Marta Taszmowicz - 2024
 * 
 * WinForms POC application for drawing Bezier curve
 * 
 */


using System;

namespace RysowanieKrzywejBeziera
{
    public partial class Form1 : Form
    {
        // Deklaracja zmiennych
        public Point P1 = new Point(50, 50);
        public Point C1 = new Point(250, 100);
        public Point P2 = new Point(600, 500);
        public Point C2 = new Point(380, 700);
        public int bufferSize = 25;
        public int pointSize = 6;
        public Bitmap buffer;
        private bool isDraggingP1 = false;
        private bool isDraggingP2 = false;
        private bool isDraggingC1 = false;
        private bool isDraggingC2 = false;

        public Form1()
        {
            InitializeComponent();

            P1X.Text = P1.X.ToString();
            P1Y.Text = P1.Y.ToString();
            C1X.Text = C1.X.ToString();
            C1Y.Text = C1.Y.ToString();
            P2X.Text = P2.X.ToString();
            P2Y.Text = P2.Y.ToString();
            C2X.Text = C2.X.ToString();
            C2Y.Text = C2.Y.ToString();
            bufforSizeCtrl.Text = bufferSize.ToString();

            // Create a new bitmap with the same size as the form
            buffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            RedrawCurve();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RedrawCurve();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (buffer != null)
            {
                this.SuspendLayout();
                e.Graphics.DrawImage(buffer, 0, 0);
                this.ResumeLayout();
            }
        }

        void RedrawCurve()
        {
            using (Graphics g = Graphics.FromImage(buffer))
            {
                bufferSize = int.Parse(bufforSizeCtrl.Text);
                P1.X = int.Parse(P1X.Text);
                P1.Y = int.Parse(P1Y.Text);
                C1.X = int.Parse(C1X.Text);
                C1.Y = int.Parse(C1Y.Text);
                P2.X = int.Parse(P2X.Text);
                P2.Y = int.Parse(P2Y.Text);
                C2.X = int.Parse(C2X.Text);
                C2.Y = int.Parse(C2Y.Text);


                Brush bBrush = (Brush)Brushes.Black;
                Pen bPen = new Pen(Color.Black, 1);
                Brush rBrush = (Brush)Brushes.Red;
                Pen rPen = new Pen(Color.Red, 1);
                Pen pPen = new Pen(Color.LightGray, 3);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                g.DrawBezier(pPen, P1, C1, C2, P2);

                Point[] points = GetBezierCurvePoints(P1, C1, P2, C2, bufferSize);
                foreach (Point point in points)
                {
                    g.FillRectangle(rBrush, point.X - 1, point.Y - 1, 3, 3);
                }

                g.DrawLine(rPen, P1, C1);
                g.DrawLine(rPen, P2, C2);
                g.FillRectangle(bBrush, P1.X - (pointSize / 2), P1.Y - (pointSize / 2), pointSize, pointSize);
                g.FillRectangle(rBrush, C1.X - (pointSize / 2), C1.Y - (pointSize / 2), pointSize, pointSize);
                g.FillRectangle(bBrush, P2.X - (pointSize / 2), P2.Y - (pointSize / 2), pointSize, pointSize);
                g.FillRectangle(rBrush, C2.X - (pointSize / 2), C2.Y - (pointSize / 2), pointSize, pointSize);

                g.DrawString("P1", new Font("Arial", 10), Brushes.Black, P1.X, P1.Y);
                g.DrawString("P2", new Font("Arial", 10), Brushes.Black, P2.X, P2.Y);

                string strTemp = "Długość krzywej: " + GetBezierLength(P1, C1, P2, C2, 100).ToString();
                g.DrawString(strTemp, new Font("Arial", 10), Brushes.Black, P2.X, P2.Y + 20);

                Invalidate();
            }
        }

        public static Point[] GetBezierCurvePoints(Point P1, Point C1, Point P2, Point C2, int bufferSize)
        {
            Point[] points = new Point[bufferSize];

            for (int i = 0; i < bufferSize; i++)
            {
                double t = i / (double)(bufferSize - 1);

                // Calculate coordinates of the point on the curve
                double x = Math.Pow(1 - t, 3) * P1.X + 3 * Math.Pow(1 - t, 2) * t * C1.X + 3 * (1 - t) * Math.Pow(t, 2) * C2.X + Math.Pow(t, 3) * P2.X;
                double y = Math.Pow(1 - t, 3) * P1.Y + 3 * Math.Pow(1 - t, 2) * t * C1.Y + 3 * (1 - t) * Math.Pow(t, 2) * C2.Y + Math.Pow(t, 3) * P2.Y;

                points[i] = new Point((int)x, (int)y);
            }

            return points;
        }

        public double GetBezierLength(Point P1, Point C1, Point C2, Point P2, int bufferSize)
        {
            //int bufferSize = 1000; // Increase this for a more accurate result
            double length = 0.0;
            Point previousPoint = P1;

            for (int i = 1; i <= bufferSize; i++)
            {
                double t = i / (double)bufferSize;

                double x = Math.Pow(1 - t, 3) * P1.X + 3 * Math.Pow(1 - t, 2) * t * C1.X + 3 * (1 - t) * Math.Pow(t, 2) * C2.X + Math.Pow(t, 3) * P2.X;
                double y = Math.Pow(1 - t, 3) * P1.Y + 3 * Math.Pow(1 - t, 2) * t * C1.Y + 3 * (1 - t) * Math.Pow(t, 2) * C2.Y + Math.Pow(t, 3) * P2.Y;

                Point currentPoint = new Point((int)x, (int)y);

                length += Math.Sqrt(Math.Pow(currentPoint.X - previousPoint.X, 2) + Math.Pow(currentPoint.Y - previousPoint.Y, 2));

                previousPoint = currentPoint;
            }

            return length;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Start dragging if the mouse is within 5 pixels of any point
            if (Math.Abs(e.X - P1.X) <= 5 && Math.Abs(e.Y - P1.Y) <= 5)
            {
                isDraggingP1 = true;
            }
            else if (Math.Abs(e.X - P2.X) <= 5 && Math.Abs(e.Y - P2.Y) <= 5)
            {
                isDraggingP2 = true;
            }
            else if (Math.Abs(e.X - C1.X) <= 5 && Math.Abs(e.Y - C1.Y) <= 5)
            {
                isDraggingC1 = true;
            }
            else if (Math.Abs(e.X - C2.X) <= 5 && Math.Abs(e.Y - C2.Y) <= 5)
            {
                isDraggingC2 = true;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (Math.Abs(e.X - P1.X) <= 5 && Math.Abs(e.Y - P1.Y) <= 5 ||
                Math.Abs(e.X - P2.X) <= 5 && Math.Abs(e.Y - P2.Y) <= 5 ||
                Math.Abs(e.X - C1.X) <= 5 && Math.Abs(e.Y - C1.Y) <= 5 ||
                Math.Abs(e.X - C2.X) <= 5 && Math.Abs(e.Y - C2.Y) <= 5)
            {
                this.Cursor = Cursors.SizeAll;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
            
            if (isDraggingP1)
            {
                int offsetX = C1.X - P1.X;
                int offsetY = C1.Y - P1.Y;

                P1 = new Point(e.X, e.Y);
                if (checkBoxMoveControlPoint.Checked)
                {
                    C1 = new Point(P1.X + offsetX, P1.Y + offsetY);
                }
                P1X.Text = P1.X.ToString();
                P1Y.Text = P1.Y.ToString();
                C1X.Text = C1.X.ToString();
                C1Y.Text = C1.Y.ToString();
                RedrawCurve();
            }
            else if (isDraggingP2)
            {
                int offsetX = C2.X - P2.X;
                int offsetY = C2.Y - P2.Y;

                P2 = new Point(e.X, e.Y);

                if (checkBoxMoveControlPoint.Checked)
                {
                    C2 = new Point(P2.X + offsetX, P2.Y + offsetY);
                }

                P2X.Text = P2.X.ToString();
                P2Y.Text = P2.Y.ToString();
                C2X.Text = C2.X.ToString();
                C2Y.Text = C2.Y.ToString();
                RedrawCurve();
            }
            else if (isDraggingC1)
            {
                C1 = new Point(e.X, e.Y);
                C1X.Text = C1.X.ToString();
                C1Y.Text = C1.Y.ToString();
                RedrawCurve();
            }
            else if (isDraggingC2)
            {
                C2 = new Point(e.X, e.Y);
                C2X.Text = C2.X.ToString();
                C2Y.Text = C2.Y.ToString();
                RedrawCurve();
            }


        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            isDraggingP1 = false;
            isDraggingP2 = false;
            isDraggingC1 = false;
            isDraggingC2 = false;
        }

        private void checkBoxMoveControlPoint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            buffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            RedrawCurve();
        }
    }
}
