using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProcessing
{
    public partial class Form2 : Form
    {
        Bitmap bmp_base, bmp_roi, bmp_canny, bmp_temp;

        double r_black = 0, r_white = 0;
        int[,] matrix = new int[3, 3];
        int[,] sobelX = new int[3, 3];
        int[,] sobelY = new int[3, 3];
        int[,] prewittX = new int[3, 3];
        int[,] prewittY = new int[3, 3];
        int[,] laplaceX = new int[3, 3];
        int[,] laplaceY = new int[3, 3];
        int[,] robertX = new int[2, 2];
        int[,] robertY = new int[2, 2];
        // Canny

        public Form2()
        {
            InitializeComponent();
            Inisialisasi();
        }


        public Form2(Bitmap bmp_crop_color2)
        {
            InitializeComponent();
            Inisialisasi();
            Bitmap bmp = bmp_crop_color2;
            bmp_base = new Bitmap(bmp, new Size(300, 300));
            pb_img.InitialImage = null;
            pb_crop_sclera.Image = bmp_base;
        }

        public void Inisialisasi()
        {
            // Sobel
            sobelX[0, 0] = -3; sobelX[0, 1] = 0; sobelX[0, 2] = 3;
            sobelX[1, 0] = -10; sobelX[1, 1] = 0; sobelX[1, 2] = 10;
            sobelX[2, 0] = -3; sobelX[2, 1] = 0; sobelX[2, 2] = 3;

            sobelY[0, 0] = -3; sobelY[0, 1] = -10; sobelY[0, 2] = -3;
            sobelY[1, 0] = 0; sobelY[1, 1] = 0; sobelY[1, 2] = 0;
            sobelY[2, 0] = 3; sobelY[2, 1] = 10; sobelY[2, 2] = 3;

            // Prewitt
            prewittX[0, 0] = -1; prewittX[0, 1] = 0; prewittX[0, 2] = 1;
            prewittX[1, 0] = -1; prewittX[1, 1] = 0; prewittX[1, 2] = 1;
            prewittX[2, 0] = -1; prewittX[2, 1] = 0; prewittX[2, 2] = 1;

            prewittY[0, 0] = -1; prewittY[0, 1] = -1; prewittY[0, 2] = -1;
            prewittY[1, 0] = 0; prewittY[1, 1] = 0; prewittY[1, 2] = 0;
            prewittY[2, 0] = 1; prewittY[2, 1] = 1; prewittY[2, 2] = 1;

            // Laplace
            laplaceX[0, 0] = -1; laplaceX[0, 1] = -1; laplaceX[0, 2] = -1;
            laplaceX[1, 0] = -1; laplaceX[1, 1] = 8; laplaceX[1, 2] = -1;
            laplaceX[2, 0] = -1; laplaceX[2, 1] = -1; laplaceX[2, 2] = -1;

            laplaceY[0, 0] = 1; laplaceY[0, 1] = -2; laplaceY[0, 2] = 1;
            laplaceY[1, 0] = -2; laplaceY[1, 1] = 4; laplaceY[1, 2] = -2;
            laplaceY[2, 0] = 1; laplaceY[2, 1] = -2; laplaceY[2, 2] = 1;

            // Robert
            robertX[0, 0] = 1; robertX[0, 1] = 0;
            robertX[1, 0] = 0; robertX[1, 1] = -1;

            robertY[0, 0] = 0; robertY[0, 1] = 1;
            robertY[1, 0] = -1; robertY[1, 1] = 0;
        }

        private Bitmap col2gray(Bitmap bmp_temp)
        {
            for (int y = 0; y < bmp_temp.Height; y++)
            {
                for (int x = 0; x < bmp_temp.Width; x++)
                {
                    Color w = bmp_temp.GetPixel(x, y);
                    int gray = (int)(w.R + w.G + w.B) / 3;
                    bmp_temp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            return bmp_temp;
        }

        private Bitmap convulation(Bitmap bmp_temp, Bitmap bmp_temp_coordinat, int[,] filter)
        {
            for (int y = 1; y < bmp_temp.Height - 1; y++)
            {
                for (int x = 1; x < bmp_temp.Width - 1; x++)
                {
                    int hasil = getValueKonvolusi(filter, bmp_temp, x, y);
                    bmp_temp_coordinat.SetPixel(x, y, Color.FromArgb(hasil, hasil, hasil));
                }
            }

            return bmp_temp_coordinat;
        }

        private Bitmap edgeDetection(Bitmap bmp_temp, Bitmap bmp_temp_x, Bitmap bmp_temp_y, Bitmap bmp_result)
        {
            for (int y = 1; y < bmp_temp.Height - 1; y++)
            {
                for (int x = 1; x < bmp_temp.Width - 1; x++)
                {
                    int hasil = getMagnitude(bmp_temp_x, bmp_temp_y, x, y);

                    bmp_result.SetPixel(x, y, Color.FromArgb(hasil, hasil, hasil));

                }
            }

            return bmp_result;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                bmp_base = new Bitmap(bmp, new Size(300, 300)); //lebar tinggi
                pb_crop_sclera.Image = bmp_base;
            }
        }

        private void btn_sobel_Click(object sender, EventArgs e)
        {
            Bitmap bmp_img, bmp_img_x, bmp_img_y;
            //convert to Gray
            bmp_img = bmp_base;
            bmp_img = col2gray(bmp_img);

            //konvolusi filter_x
            bmp_img_x = new Bitmap(bmp_img);
            bmp_img_x = convulation(bmp_img, bmp_img_x, sobelX);

            //konvolusi filter_y
            bmp_img_y = new Bitmap(bmp_img);
            bmp_img_y = convulation(bmp_img, bmp_img_y, prewittY);

            Bitmap bmp_img_fix = new Bitmap(bmp_img);
            bmp_img_fix = edgeDetection(bmp_img, bmp_img_x, bmp_img_y, bmp_img_fix);

            if (pb_img.Image != null)
            {
                pb_img.Image.Dispose();
                pb_img.Image = null;
            }

            bmp_base = bmp_img_fix;
            pb_img.Image = bmp_base;

        }

        private void btn_prewitt_Click(object sender, EventArgs e)
        {
            Bitmap bmp_img, bmp_img_x, bmp_img_y;

            //convert to Gray
            bmp_img = bmp_base;
            bmp_img = col2gray(bmp_img);

            //konvolusi filter_x
            bmp_img_x = new Bitmap(bmp_img);
            bmp_img_x = convulation(bmp_img, bmp_img_x, prewittX);

            //konvolusi filter_y
            bmp_img_y = new Bitmap(bmp_img);
            bmp_img_y = convulation(bmp_img, bmp_img_y, prewittY);

            Bitmap bmp_img_fix = new Bitmap(bmp_img);
            bmp_img_fix = edgeDetection(bmp_img, bmp_img_x, bmp_img_y, bmp_img_fix);


            pb_img.Image = null;
            pb_img.Update();
            bmp_base = bmp_img_fix;
            pb_img.Image = bmp_base;
        }

        private void btn_laplace_Click(object sender, EventArgs e)
        {
            Bitmap bmp_img, bmp_img_x, bmp_img_y;

            //convert to Gray
            bmp_img = bmp_base;
            bmp_img = col2gray(bmp_img);

            //konvolusi filter_x
            bmp_img_x = new Bitmap(bmp_img);
            bmp_img_x = convulation(bmp_img, bmp_img_x, laplaceX);

            //konvolusi filter_y
            bmp_img_y = new Bitmap(bmp_img);
            bmp_img_y = convulation(bmp_img, bmp_img_y, laplaceY);

            Bitmap bmp_img_fix = new Bitmap(bmp_img);
            bmp_img_fix = edgeDetection(bmp_img, bmp_img_x, bmp_img_y, bmp_img_fix);


            pb_img.Image = null;
            pb_img.Update();
            bmp_base = bmp_img_fix;
            pb_img.Image = bmp_base;
        }

        private void btn_robert_Click(object sender, EventArgs e)
        {
            Bitmap bmp_img, bmp_img_x, bmp_img_y;

            //convert to Gray
            bmp_img = bmp_base;
            bmp_img = col2gray(bmp_img);

            //konvolusi filter_x
            bmp_img_x = new Bitmap(bmp_img);
            bmp_img_x = convulation(bmp_img, bmp_img_x, robertX);

            //konvolusi filter_y
            bmp_img_y = new Bitmap(bmp_img);
            bmp_img_y = convulation(bmp_img, bmp_img_y, robertY);

            Bitmap bmp_img_fix = new Bitmap(bmp_img);
            bmp_img_fix = edgeDetection(bmp_img, bmp_img_x, bmp_img_y, bmp_img_fix);


            pb_img.Image = null;
            pb_img.Update();
            bmp_base = bmp_img_fix;
            pb_img.Image = bmp_base;
        }

        private void btn_canny_Click(object sender, EventArgs e)
        {

        }

        public int getValueKonvolusi(int[,] filter, Bitmap bmp1, int x, int y)
        {
            int value = 0;
            value += filter[0, 0] * bmp1.GetPixel(x - 1, y - 1).R;
            value += filter[0, 1] * bmp1.GetPixel(x, y - 1).R;
            value += filter[0, 2] * bmp1.GetPixel(x + 1, y - 1).R;
            value += filter[1, 0] * bmp1.GetPixel(x - 1, y).R;
            value += filter[1, 1] * bmp1.GetPixel(x, y).R;
            value += filter[1, 2] * bmp1.GetPixel(x + 1, y).R;
            value += filter[2, 0] * bmp1.GetPixel(x - 1, y + 1).R;
            value += filter[2, 1] * bmp1.GetPixel(x, y + 1).R;
            value += filter[2, 2] * bmp1.GetPixel(x + 1, y + 1).R;
            if (value < 0) value = 0;
            if (value > 255) value = 255;
            return value;
        }

        private void pb_crop_iris_Click(object sender, EventArgs e)
        {

        }

        private void pb_roi_Click(object sender, EventArgs e)
        {

        }

        private void pb_sobel_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pb_roi_img_Click(object sender, EventArgs e)
        {

        }

        private void tx_hasil_Click(object sender, EventArgs e)
        {

        }

        private void txt_ratio_bw_Click(object sender, EventArgs e)
        {

        }

        private void pb_extract_Click(object sender, EventArgs e)
        {

        }

        private void txt_bw_Click(object sender, EventArgs e)
        {

        }

        private void edit_threshold_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public int getMagnitude(Bitmap bmp2a, Bitmap bmp2b, int x, int y)
        {
            int value1 = bmp2a.GetPixel(x, y).R;
            int value2 = bmp2a.GetPixel(x, y).R;
            int hasil = (int)Math.Sqrt((Math.Pow(value1, 2)) + Math.Pow(value2, 2));
            if (hasil > 255)
                hasil = 255;
            return hasil;
        }

        private void btn_roi_Click(object sender, EventArgs e)
        {
            int left = bmp_base.Width * 16 / 32;
            int right = bmp_base.Width * 19 / 32;
            int top = Convert.ToInt16(bmp_base.Height * 23.5 / 32);
            int bottom = Convert.ToInt16(bmp_base.Height * 31 / 32);

            Bitmap roi_area = new Bitmap(bmp_base);
            for (int i = 0; i < bmp_base.Width; i++)
            {
                for (int j = 0; j < bmp_base.Height; j++)
                {
                    //kebawah
                    if ((i == left || i == right) && j >= top && j <= bottom)
                    {
                        roi_area.SetPixel(i, j, Color.Red);
                    }
                    //kesamping
                    else if (i >= left && i <= right && (j == top || j == bottom))
                    {
                        roi_area.SetPixel(i, j, Color.Red);
                    }
                }
            }
            pb_roi.Image = roi_area;

            bmp_roi = new Bitmap(right - left + 1, bottom - top + 1);
            int xb = 0, yb = 0;

            for (int x = left; x <= right; x++)
            {
                for (int y = top; y <= bottom; y++)
                {
                    Color color = bmp_base.GetPixel(x, y);
                    bmp_roi.SetPixel(xb, yb, color);
                    yb++;
                }
                xb++;
                yb = 0;
            }
            pb_roi_img.Image = bmp_roi;
        }

        private void btn_rasio_Click(object sender, EventArgs e)
        {
            Bitmap bmp_roi_extract = new Bitmap(bmp_roi);
            Bitmap bmp_roi_gray = new Bitmap(bmp_roi);
            int black = 0, white = 255;
            double black_count = 0, white_count = 0;
            double count = 0; int lain = 0;

            int new_xr = 0;
            for (int x = 0; x < bmp_roi.Width; x++)
            {
                for (int y = 0; y < bmp_roi.Height; y++)
                {
                    Color w = bmp_roi.GetPixel(x, y);
                    double xr = Math.Sqrt((Math.Pow(w.R - white, 2)) + (Math.Pow(w.G - white, 2)) + (Math.Pow(w.B - white, 2)));

                    if (xr < 350)
                    {
                        new_xr = 255;
                        white_count++;
                    }
                    else
                    {
                        new_xr = 0;
                        black_count++;
                    }
                    count++;
                    Color new_w = Color.FromArgb(new_xr, new_xr, new_xr);
                    //bmp_roi_extract.SetPixel(x, y, new_w);
                    bmp_roi_extract.SetPixel(x, y, new_w);
                }
            }
            //bmp_roi = bmp_roi_extract;
            pb_extract.Image = bmp_roi_extract;
            txt_bw.Text = "Jumlah hitam = " + Convert.ToInt16(black_count) +
                "\nJumlah putih = " + Convert.ToInt16(white_count) +
                "\nJumlah lain = " + Convert.ToInt16(lain) +
                "\nJumlah pixel = " + Convert.ToInt16(count);

            r_black = black_count / count;
            r_white = white_count / count;

            txt_ratio_bw.Text = "Ratio hitam = " + Math.Round(r_black, 3) +
               "\nRatio putih = " + Math.Round(r_white, 3);


        }

        private void btn_kondisi_Click(object sender, EventArgs e)
        {
            double th_white = Convert.ToDouble(edit_threshold.Text);
            //double th_white = 0.25;
            if (r_white > th_white)
                tx_hasil.Text = "HASIL: Abnormal";
            else
                tx_hasil.Text = "HASIL: Normal";
        }


    }
}
