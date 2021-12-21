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

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if(DialogResult.OK==ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);
                
            }

        }

        private void btngray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
           
            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;

        }

        private void btnmirrorH_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
            Bitmap copy1 = new Bitmap((Bitmap)this.picResult.Image);

            Processing.MirrorImageH(copy, copy1);
            this.picResult.Image = copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
            Bitmap copy1 = new Bitmap((Bitmap)this.picResult.Image);

            Processing.MirrorImageV(copy, copy1);
            this.picResult.Image = copy;

        }

        private void btnmakecopy_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            this.picResult.Image = copy;

        }

        private void btnquant_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);

            Processing.ConvertToGray(copy);

            //Processing.Quantify(copy);
            this.picResult.Image = copy;


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.picResult.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }


        }

        private void btnhisto_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Bitmap histogram = new Bitmap(256, 256);

            Processing.histogram(copy, histogram);

            this.picResult.Image = histogram;
        }

        private void btnBri_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Processing.brightness(copy, Convert.ToInt32(textBoxBri.Text));

            this.picResult.Image = copy;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Processing.negative(copy);

            this.picResult.Image = copy;
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picResult.Image);
            Processing.Contrast(copy, Convert.ToInt32(textBoxCont.Text));

            this.picResult.Image = copy;
        }

        private void btnRot_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Bitmap copy1 = new Bitmap(copy.Height, copy.Width);

            Processing.rotate(copy, copy1);

            this.picResult.Image = copy1;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Bitmap copy1 = new Bitmap((Bitmap)this.picOriginal.Image);
            Bitmap histogram = new Bitmap(256, 256);

            Processing.Equalized(copy, histogram, copy1);

            this.picOriginal.Image = copy1;

            this.picResult.Image = histogram;
        }

        private void btnZIn_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Bitmap copy1 = new Bitmap(picOriginal.Image.Width * 2, picOriginal.Image.Height * 2);

            Processing.ZoomIn(copy, copy1);

            this.picResult.Image = copy1;
        }

        private void btnZOut_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Bitmap copy1 = new Bitmap(picOriginal.Image.Width / 2, picOriginal.Image.Height / 2);

            Processing.ZoomOut(copy, copy1, 2, 2);
            this.picOriginal.Image = copy1;
        }
    }
}
