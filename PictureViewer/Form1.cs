using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace PictureViewer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public Form1(String fileStr) {
            InitializeComponent();
            FileInfo file = new FileInfo(fileStr);
            string extension = file.Extension;
            if (file.Exists && (extension.Equals(".png") || extension.Equals(".jpg") || extension.Equals(".bmp"))) {
                pictureBox1.Load(fileStr);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if(pd.ShowDialog() == DialogResult.OK) {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e) {
            Bitmap bm = pictureBox1.Image as Bitmap;
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e) {
            Bitmap source = pictureBox1.Image as Bitmap;

            Rectangle cropRect = new Rectangle(90, 66, 568, 367);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target)) {
                g.DrawImage(source, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            pictureBox1.Image = target;
        }

        private void button3_Click(object sender, EventArgs e) {
            Bitmap source = pictureBox1.Image as Bitmap;

            Rectangle cropRect = new Rectangle(207, 163, 344, 311);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target)) {
                g.DrawImage(source, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            pictureBox1.Image = target;
        }

        private void button4_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}
