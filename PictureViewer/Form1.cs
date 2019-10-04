using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PictureViewer {
    public partial class Form1 : Form {

        private Bitmap sourceImg = null;
        private String pathTemp = null;
        private String currPath = null;

        public Form1() {
            InitializeComponent();
            btnUndo.Enabled = false;
            btnCropNormal.Enabled = false;
            btnCropFaceOld.Enabled = false;
            btnCropFaceNew.Enabled = false;
            btnNewMachineFace.Enabled = false;
            btnNewMachineNormal.Enabled = false;
            btnPrint.Enabled = false;
        }

        public Form1(String fileStr) {
            InitializeComponent();
            FileInfo file = new FileInfo(fileStr);
            string extension = file.Extension;
            if (file.Exists && (extension.Equals(".png") || extension.Equals(".jpg") || extension.Equals(".bmp"))) {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                currPath = fileStr;
                pictureBox.Load(fileStr);
                pathTemp = Path.GetDirectoryName(fileStr) + "\\temp.png";
                btnUndo.Enabled = false;
                btnCropNormal.Enabled = true;
                btnCropFaceOld.Enabled = true;
                btnCropFaceNew.Enabled = true;
                btnNewMachineFace.Enabled = true;
                btnNewMachineNormal.Enabled = true;
                btnPrint.Enabled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            var p = new Process();
            if (currPath == null || pathTemp == null) {
                MessageBox.Show("Không có ảnh để in");
                return;
            }
            if (btnCropNormal.Enabled) {
                p.StartInfo.FileName = currPath;
            } else {
                p.StartInfo.FileName = pathTemp;
            }
            p.StartInfo.Verb = "Print";
            p.Start();
        }

        private void btnCropNormal_Click(object sender, EventArgs e) {
            sourceImg = pictureBox.Image as Bitmap;
            Rectangle cropRect = new Rectangle(90, 66, 568, 367);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target)) {
                g.DrawImage(sourceImg, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            target.Save(pathTemp, ImageFormat.Png);
            pictureBox.Image = target;
            btnUndo.Enabled = true;
            btnCropNormal.Enabled = false;
            btnCropFaceOld.Enabled = false;
            btnCropFaceNew.Enabled = false;
            btnNewMachineFace.Enabled = false;
            btnNewMachineNormal.Enabled = false;
        }

        private void btnCropFaceOld_Click(object sender, EventArgs e) {
            sourceImg = pictureBox.Image as Bitmap;
            Rectangle cropRect = new Rectangle(207, 163, 344, 311);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target)) {
                g.DrawImage(sourceImg, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            target.Save(pathTemp, ImageFormat.Png);
            pictureBox.Image = target;
            btnUndo.Enabled = true;
            btnCropNormal.Enabled = false;
            btnCropFaceOld.Enabled = false;
            btnCropFaceNew.Enabled = false;
            btnNewMachineFace.Enabled = false;
            btnNewMachineNormal.Enabled = false;
        }


        private void btnCropFaceNew_Click(object sender, EventArgs e) {
            sourceImg = pictureBox.Image as Bitmap;
            Rectangle cropRect = new Rectangle(150, 83, 387, 355);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target)) {
                g.DrawImage(sourceImg, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            target.Save(pathTemp, ImageFormat.Png);
            pictureBox.Image = target;
            btnUndo.Enabled = true;
            btnCropNormal.Enabled = false;
            btnCropFaceOld.Enabled = false;
            btnCropFaceNew.Enabled = false;
            btnNewMachineFace.Enabled = false;
            btnNewMachineNormal.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            pictureBox.Image = sourceImg;
            btnUndo.Enabled = false;
            btnCropNormal.Enabled = true;
            btnCropFaceOld.Enabled = true;
            btnCropFaceNew.Enabled = true;
            btnNewMachineFace.Enabled = true;
            btnNewMachineNormal.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (File.Exists(pathTemp)) {
                File.Delete(pathTemp);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                currPath = openFileDialog1.FileName;
                pictureBox.Load(currPath);
                pathTemp = Path.GetDirectoryName(currPath) + "\\temp.png";
                btnUndo.Enabled = false;
                btnCropNormal.Enabled = true;
                btnCropFaceOld.Enabled = true;
                btnCropFaceNew.Enabled = true;
                btnNewMachineFace.Enabled = true;
                btnNewMachineNormal.Enabled = true;
                btnPrint.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnNewMachineNormal_Click(object sender, EventArgs e)
        {
            sourceImg = pictureBox.Image as Bitmap;
            Rectangle cropRect = new Rectangle(500, 105, 1005, 676);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(sourceImg, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            target.Save(pathTemp, ImageFormat.Png);
            pictureBox.Image = target;
            btnUndo.Enabled = true;
            btnCropNormal.Enabled = false;
            btnCropFaceOld.Enabled = false;
            btnCropFaceNew.Enabled = false;
            btnNewMachineFace.Enabled = false;
            btnNewMachineNormal.Enabled = false;
        }

        private void btnNewMachineFace_Click(object sender, EventArgs e)
        {
            sourceImg = pictureBox.Image as Bitmap;
            Rectangle cropRect = new Rectangle(530, 65, 850, 850);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(sourceImg, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            }
            target.Save(pathTemp, ImageFormat.Png);
            pictureBox.Image = target;
            btnUndo.Enabled = true;
            btnCropNormal.Enabled = false;
            btnCropFaceOld.Enabled = false;
            btnCropFaceNew.Enabled = false;
            btnNewMachineFace.Enabled = false;
            btnNewMachineNormal.Enabled = false;
        }
    }
}
