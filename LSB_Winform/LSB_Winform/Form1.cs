using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap fileAf, fileBef;// after,before

        
        private void picboxBefore_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 10))
            {
                e.Graphics.DrawString("Before", myFont, Brushes.Gray, new Point(80, 80));
            }
        }
        private void picboxAfter_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 10))
            {
                e.Graphics.DrawString("After", myFont, Brushes.Gray, new Point(80, 80));
            }
        }
        //load ảnh 
        private void btnFile_Click(object sender, EventArgs e)
        {

            picboxAfter.Image = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picboxBefore.Image = Image.FromFile(ofd.FileName);
                fileBef = (Bitmap)picboxBefore.Image;

            }
        }

        //load ảnh
        private void picboxBefore_Click(object sender, EventArgs e)
        {
            picboxAfter.Image=null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picboxBefore.Image = Image.FromFile(ofd.FileName);
                fileBef = (Bitmap)picboxBefore.Image;

            }
        }

        //xử lí lsb và hiển thị kết quả
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (fileBef != null && textHide.Text != "")
            {
                fileAf = LSB.HideBitmap(textHide.Text, fileBef);
                picboxAfter.Image = fileAf;
                MessageBox.Show("Hide text successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to hide!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // đọc lsb
        private void btnExtract_Click(object sender, EventArgs e)
        {
            string mess = "";
            // MessageBox.Show("Ảnh giữ nguyên,chỉ đọc lsb!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (fileBef != null)
            {
                if (textHide.Text != "")
                {
                    textHide.Clear();
                }
                mess = LSB.ExtractBitmap(fileBef);
                if (mess != null) textExtract.Text = mess;
                MessageBox.Show("Extract successful!\n" + mess, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to extract!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //lưu kết quả
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fileAf != null)
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "Bmp (*.bmp)|*.bmp|Gif (*.gif)|*.gif|Jpeg (*.jpeg)|*.jpeg;*.jpg|Png (*.png)|*.png";
                sfd.Title = "chọn kiểu lưu";
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        switch (sfd.FilterIndex)
                        {
                            case 1: fileAf.Save(sfd.FileName, ImageFormat.Bmp); break;
                            case 2: fileAf.Save(sfd.FileName, ImageFormat.Gif); break;
                            case 3: fileAf.Save(sfd.FileName, ImageFormat.Jpeg); break;
                            case 4: fileAf.Save(sfd.FileName, ImageFormat.Png); break;
                            default: fileAf.Save(sfd.FileName + ".png", ImageFormat.Png); break;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot save image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Cannot find image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picboxExtract.Image = Image.FromFile(ofd.FileName);
                fileBef = (Bitmap)picboxExtract.Image;

            }
        }

        private void picboxExtract_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picboxExtract.Image = Image.FromFile(ofd.FileName);
                fileBef = (Bitmap)picboxExtract.Image;

            }
        }

       

        //
        private void btnCleartext_Click(object sender, EventArgs e)
        {
            textHide.Clear();
        }

    }
}
