using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace CvPlatformer
{
    public partial class Form1 : Form
    {
        Mat currentFrame;
        VideoCapture capture;
        List<Rectangle> platforms;
        Vector2 playerPosition;
        Vector2 speed;
        Size playerSize;
        bool isUpdateing = true;
        VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isUpdateing)
            {
                currentFrame = capture.QueryFrame();
                CameraWindow.Image = capture.QueryFrame().ToBitmap();
                perspectiveTransform();
                trackPlatforms();
            }
            else
            {
                player();
            }
            draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
            playerPosition = new Vector2(100, 100);
            speed = new Vector2(0, 0);
            playerSize = new Size(30, 40);
        }
        public void player()
        {
            playerPosition.Y += speed.Y;
            playerPosition.X += speed.X;
            speed.Y += 2f;
            for(int i = 0; i < platforms.Count; i++)
            {
                if (new Rectangle(new Point((int)playerPosition.X, (int)playerPosition.Y), playerSize).IntersectsWith(platforms[i]))
                {
                    speed.Y = -2.3f;  
                }
            }         
            if(playerPosition.Y > 500)
            {
                playerPosition.Y = 50;
                speed.Y = 0;
            }
        }
        private void perspectiveTransform()
        {
            Mat image = currentFrame;
            Mat output = image.Clone();
            Mat imageClone = image.Clone();
            CvInvoke.GaussianBlur(imageClone, imageClone, new Size(7, 7), 0);
            CvInvoke.CvtColor(imageClone, imageClone, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            CvInvoke.InRange(imageClone, (ScalarArray)new MCvScalar(75, 0, 127), (ScalarArray)new MCvScalar(179, 65, 255), imageClone);
            InRangeWindow.Image = imageClone.ToBitmap();
            contours = new VectorOfVectorOfPoint();
            Mat heirachy = new Mat();
            CvInvoke.FindContours(imageClone, contours, heirachy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);

            int index = 0;
            var biggestContourArea = double.MinValue;
            for (int i = 0; i < contours.Size; i++)
            {
                double area = CvInvoke.ContourArea(contours[i]);
                if (biggestContourArea <= area)
                {
                    index = i;
                    biggestContourArea = area;
                }
            }

            if (contours.Size == 0 || biggestContourArea < 500)
            {
                return;
            }

            CvInvoke.ApproxPolyDP(contours[index], contours[index], 0.02 * CvInvoke.ArcLength(contours[index], true), true);
            CvInvoke.DrawContours(image, contours, -1, new MCvScalar(255, 0, 0), 4);
            ContourWindow.Image = image.ToBitmap();
            PointF[] dest = new PointF[]
            {
                new PointF(0,0),
                new PointF(output.Width,0),
                new PointF(output.Width,output.Height),
                new PointF(0,output.Height),
            };

            CvInvoke.WarpPerspective(output, output, CvInvoke.GetPerspectiveTransform(new PointF[] { contours[index][0], contours[index][1], contours[index][2], contours[index][3] }, dest), output.Size);
            CvInvoke.Flip(output, output, Emgu.CV.CvEnum.FlipType.Horizontal);
            TransformWindow.Image = output.ToBitmap();
            TransformWindow.Tag = output;
        }

        private void trackPlatforms()
        {
            Mat image = (Mat)TransformWindow.Tag;
            Mat imageClone = image.Clone();
            CvInvoke.GaussianBlur(imageClone, imageClone, new Size(5, 5), 0);
            CvInvoke.CvtColor(imageClone, imageClone, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            CvInvoke.InRange(imageClone, (ScalarArray)new MCvScalar(0, 0, 0), (ScalarArray)new MCvScalar(255, 255, 60), imageClone);
            
            Mat heirachy = new Mat();
            CvInvoke.FindContours(imageClone, contours, heirachy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
            platforms = new List<Rectangle>();
            for(int i = 0; i < contours.Size; i++)
            {
                if (CvInvoke.ContourArea(contours[i]) > 50)
                {
                    platforms.Add(CvInvoke.BoundingRectangle(contours[i]));                  
                }
            }
        }
        private void draw()
        {
            Mat image = (Mat)TransformWindow.Tag;
            Mat output = image.Clone();
            for(int i = 0; i < platforms.Count; i++)
            {
                CvInvoke.Rectangle(output, CvInvoke.BoundingRectangle(contours[i]), new MCvScalar(0, 255, 255), -1);
            }
            CvInvoke.Rectangle(output, new Rectangle((int)playerPosition.X, (int)playerPosition.Y, playerSize.Width, playerSize.Height), new MCvScalar(255, 0, 0), -1);
            GameWindow.Image = output.ToBitmap();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                speed = new Vector2(speed.X,-25);
            }

            if(e.KeyData == Keys.Right)
            {
                speed.X = 12;
            }
            else if(e.KeyData == Keys.Left)
            {
                speed.X = -12;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            speed.X = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isUpdateing = false;
            GameWindow.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            isUpdateing = true;
            GameWindow.Focus();
        }
    }
}
