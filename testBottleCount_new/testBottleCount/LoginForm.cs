using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Imaging;
using AForge.Video;
using AForge.Controls;
using AForge.Video.DirectShow;
using System.Threading;
using Emgu.CV;
using System.IO;
using Emgu.CV.Structure;

namespace testBottleCount
{
    public partial class LoginForm : Form
    {
        VideoSourcePlayer myVideoSourcePlayer = new VideoSourcePlayer();
        TextBox tbxUserName = new TextBox();
        TextBox tbxPassword = new TextBox();
        Label lblUserName = new Label();
        Label lblPassword = new Label();

        List<FilterInfo> comboBoxCameras = new List<FilterInfo>();

        Button btnNormalLogin = new Button();
        public LoginForm()
        {
            InitializeComponent();
            lblUserName.Text = "UserName:";
            lblPassword.Text = "PassWord:";
            lblUserName.Size = new Size(60, 23);
            lblPassword.Size = new Size(60, 23);

            tbxUserName.Size = new Size(150, 23);
            tbxPassword.Size = new Size(150, 23);

            btnNormalLogin.Text = "Login";
            btnNormalLogin.Click += BtnNormalLogin_Click;

        }

        private void BtnNormalLogin_Click(object sender, EventArgs e)
        {
            BottleCountMain BCM = new BottleCountMain();
            this.DialogResult = DialogResult.OK;
        }

        private void btnFaceLogin_Click(object sender, EventArgs e)
        {
            myVideoSourcePlayer.Stop();
            this.panelVideoSourcePlayer.Controls.Clear();
            myVideoSourcePlayer.Dock = DockStyle.Fill;
            this.panelVideoSourcePlayer.Controls.Add(myVideoSourcePlayer);

            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBoxCameras.Clear();

            for (int i = 0; i < videoDevices.Count; i++)
            {
                comboBoxCameras.Add(videoDevices[i]);
            }

            if (comboBoxCameras.Count <= 0)
            {
                MessageBox.Show("No device can be used. Please use other way to login.", "", MessageBoxButtons.OK);
                return;
            }



            FilterInfo selectedDevice = comboBoxCameras[0];
            VideoCaptureDevice videoSource = new VideoCaptureDevice(selectedDevice.MonikerString);
            //videoSource.VideoResolution = videoSource.VideoCapabilities[0];
            int FrameWidth = 2000;
            int FrameHeight = 0;
            foreach (VideoCapabilities capab in videoSource.VideoCapabilities)
            {
                if (capab.FrameSize.Width< FrameWidth)
                {
                    FrameWidth = capab.FrameSize.Width;
                    FrameHeight = capab.FrameSize.Height;
                    videoSource.VideoResolution = capab;
                }
            }

            myVideoSourcePlayer.VideoSource = videoSource;
            // set NewFrame event handler
            myVideoSourcePlayer.Start();
            Thread.Sleep(1000);

            Task.Run(() =>
            {
                string absolutPath = Directory.GetCurrentDirectory();
                var faceClassifier = new CascadeClassifier(absolutPath + "\\haarcascade_frontalface_default.xml");
                int frameCount = 0;
                while (true)
                {
                    Bitmap bitmap = myVideoSourcePlayer.GetCurrentVideoFrame();
                    string fileName = Guid.NewGuid().ToString() + ".jpg";
                    bitmap.Save(fileName);
                    frameCount += 1;
                    var img = new Image<Bgr, byte>(fileName);
                    UMat ugray = new UMat();

                    //把图片从彩色转灰度
                    CvInvoke.CvtColor(img, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                    //亮度增强
                    CvInvoke.EqualizeHist(ugray, ugray);
                    //返回的是人脸所在的位置和大小
                    var facesDetected = faceClassifier.DetectMultiScale(ugray, 1.1,3,new Size(0,0));
                    //{ X = 122 Y = 62 Width = 60 Height = 60}
                    if (facesDetected.Length > 0)
                    {
                        Graphics g = this.myVideoSourcePlayer.CreateGraphics();
                        int width = 0;
                        int height = 0;
                        foreach (Rectangle location in facesDetected)
                        {
                            width = location.Width * 3;
                            height = location.Height * 4;
                            g.DrawLine(new Pen(Color.Black), new System.Drawing.Point(location.X, location.Y), new System.Drawing.Point(location.X,location.Y + height));
                            g.DrawLine(new Pen(Color.Black), new System.Drawing.Point(location.X, location.Y), new System.Drawing.Point(location.X+ width, location.Y));
                            g.DrawLine(new Pen(Color.Black), new System.Drawing.Point(location.X + width, location.Y + height), new System.Drawing.Point(location.X + width, location.Y));
                            g.DrawLine(new Pen(Color.Black), new System.Drawing.Point(location.X + width, location.Y + height), new System.Drawing.Point(location.X, location.Y + height));
                        }
                        g.Dispose();
                    }

                    ugray.Dispose();
                    img.Dispose();
                    File.Delete(fileName);

                    //FaceCore.OpenPlatform.DTO.FaceDetectRequest

                    Thread.Sleep(1000);
                    if (frameCount > 12)
                    {
                        break;
                    }
                }
            });
        }

        private void btnNormalLogin_Click(object sender, EventArgs e)
        {
            myVideoSourcePlayer.Stop();
            this.panelVideoSourcePlayer.Controls.Clear();
            lblUserName.Location = new System.Drawing.Point(new Size(93, 120));
            this.panelVideoSourcePlayer.Controls.Add(lblUserName);

            lblPassword.Location = new System.Drawing.Point(new Size(93, 160));
            this.panelVideoSourcePlayer.Controls.Add(lblPassword);

            tbxUserName.Location = new System.Drawing.Point(new Size(163, 115));
            this.panelVideoSourcePlayer.Controls.Add(tbxUserName);

            tbxPassword.Location = new System.Drawing.Point(new Size(163, 155));
            this.panelVideoSourcePlayer.Controls.Add(tbxPassword);

            btnNormalLogin.Location = new System.Drawing.Point(new Size(300, 280));
            this.panelVideoSourcePlayer.Controls.Add(btnNormalLogin);

        }
    }
}
