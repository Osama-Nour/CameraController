using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace DealWithCamera
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;


        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            try
            {
                if (isCameraRunning)
                {
                    // Take snapshot of the current image generate by OpenCV in the Picture Box
                    Bitmap snapshot = new Bitmap(pictureBox1.Image);
                    // Save in some directory
                    // in this example, we'll generate a random filename e.g 47059681-95ed-4e95-9b50-320092a3d652.png
                    // snapshot.Save(@"C:\Users\sdkca\Desktop\mysnapshot.png", ImageFormat.Png);
                    snapshot.Save(string.Format(@"C:\Users\dell\Desktop\{0}.jpg", Guid.NewGuid()), ImageFormat.Jpeg);



                    //saveFilePhoto.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                    //saveFilePhoto.Title = "Save an Image File";
                    //saveFilePhoto.ShowDialog();
                    //if (saveFilePhoto.FileName != "")
                    //{
                    //    // Saves the Image via a FileStream created by the OpenFile method.
                    //    System.IO.FileStream fs =
                    //        (System.IO.FileStream)saveFilePhoto.OpenFile();
                    //    // Saves the Image in the appropriate ImageFormat based upon the
                    //    // File type selected in the dialog box.
                    //    // NOTE that the FilterIndex property is one-based.
                    //    switch (saveFilePhoto.FilterIndex)
                    //    {
                    //        case 1:
                    //            this.btn_capture.Image.Save(fs,
                    //              System.Drawing.Imaging.ImageFormat.Jpeg);
                    //            break;

                    //        case 2:
                    //            this.btn_capture.Image.Save(fs,
                    //              System.Drawing.Imaging.ImageFormat.Bmp);
                    //            break;

                    //        case 3:
                    //            this.btn_capture.Image.Save(fs,
                    //              System.Drawing.Imaging.ImageFormat.Gif);
                    //            break;
                    //    }

                    //    fs.Close();
                    //}
                }
                else
                {
                    MessageBox.Show("Cannot take picture if the camera isn't capturing image!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureCamera();
                isCameraRunning = true;
                btn_start.Enabled = false;
                btn_stopCamera.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_stopCamera_Click(object sender, EventArgs e)
        {
            try
            {
                capture.Release();
                isCameraRunning = false;
                btn_start.Enabled = true;
                btn_stopCamera.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_saveBinary_Click(object sender, EventArgs e)
        {

        }
    }
}
