namespace FormProcessing
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_roi = new System.Windows.Forms.Button();
            this.pb_roi = new System.Windows.Forms.PictureBox();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.pb_crop_sclera = new System.Windows.Forms.PictureBox();
            this.btn_sobel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_roi_img = new System.Windows.Forms.PictureBox();
            this.tx_hasil = new System.Windows.Forms.Label();
            this.btn_kondisi = new System.Windows.Forms.Button();
            this.txt_ratio_bw = new System.Windows.Forms.Label();
            this.pb_extract = new System.Windows.Forms.PictureBox();
            this.txt_bw = new System.Windows.Forms.Label();
            this.btn_rasio = new System.Windows.Forms.Button();
            this.edit_threshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_prewitt = new System.Windows.Forms.Button();
            this.btn_laplace = new System.Windows.Forms.Button();
            this.btn_canny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_roi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_crop_sclera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_roi_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_extract)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(145, 294);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(100, 41);
            this.btn_browse.TabIndex = 71;
            this.btn_browse.Text = "Load Sclera";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_roi
            // 
            this.btn_roi.Location = new System.Drawing.Point(143, 644);
            this.btn_roi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_roi.Name = "btn_roi";
            this.btn_roi.Size = new System.Drawing.Size(100, 39);
            this.btn_roi.TabIndex = 70;
            this.btn_roi.Text = "ROI Area";
            this.btn_roi.UseVisualStyleBackColor = true;
            this.btn_roi.Click += new System.EventHandler(this.btn_roi_Click);
            // 
            // pb_roi
            // 
            this.pb_roi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_roi.Location = new System.Drawing.Point(49, 366);
            this.pb_roi.Margin = new System.Windows.Forms.Padding(4);
            this.pb_roi.Name = "pb_roi";
            this.pb_roi.Size = new System.Drawing.Size(293, 270);
            this.pb_roi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_roi.TabIndex = 69;
            this.pb_roi.TabStop = false;
            this.pb_roi.Click += new System.EventHandler(this.pb_roi_Click);
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img.Location = new System.Drawing.Point(443, 15);
            this.pb_img.Margin = new System.Windows.Forms.Padding(4);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(293, 270);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 68;
            this.pb_img.TabStop = false;
            this.pb_img.Click += new System.EventHandler(this.pb_sobel_Click);
            // 
            // pb_crop_sclera
            // 
            this.pb_crop_sclera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_crop_sclera.Location = new System.Drawing.Point(49, 16);
            this.pb_crop_sclera.Margin = new System.Windows.Forms.Padding(4);
            this.pb_crop_sclera.Name = "pb_crop_sclera";
            this.pb_crop_sclera.Size = new System.Drawing.Size(293, 270);
            this.pb_crop_sclera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_crop_sclera.TabIndex = 67;
            this.pb_crop_sclera.TabStop = false;
            this.pb_crop_sclera.Click += new System.EventHandler(this.pb_crop_iris_Click);
            // 
            // btn_sobel
            // 
            this.btn_sobel.Location = new System.Drawing.Point(764, 16);
            this.btn_sobel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sobel.Name = "btn_sobel";
            this.btn_sobel.Size = new System.Drawing.Size(100, 41);
            this.btn_sobel.TabIndex = 66;
            this.btn_sobel.Text = "Sobel";
            this.btn_sobel.UseVisualStyleBackColor = true;
            this.btn_sobel.Click += new System.EventHandler(this.btn_sobel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pb_roi_img
            // 
            this.pb_roi_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_roi_img.Location = new System.Drawing.Point(441, 366);
            this.pb_roi_img.Margin = new System.Windows.Forms.Padding(4);
            this.pb_roi_img.Name = "pb_roi_img";
            this.pb_roi_img.Size = new System.Drawing.Size(146, 192);
            this.pb_roi_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_roi_img.TabIndex = 72;
            this.pb_roi_img.TabStop = false;
            this.pb_roi_img.Click += new System.EventHandler(this.pb_roi_img_Click);
            // 
            // tx_hasil
            // 
            this.tx_hasil.AutoSize = true;
            this.tx_hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_hasil.ForeColor = System.Drawing.Color.Maroon;
            this.tx_hasil.Location = new System.Drawing.Point(879, 535);
            this.tx_hasil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tx_hasil.Name = "tx_hasil";
            this.tx_hasil.Size = new System.Drawing.Size(73, 24);
            this.tx_hasil.TabIndex = 80;
            this.tx_hasil.Text = "HASIL: ";
            this.tx_hasil.Click += new System.EventHandler(this.tx_hasil_Click);
            // 
            // btn_kondisi
            // 
            this.btn_kondisi.Location = new System.Drawing.Point(883, 476);
            this.btn_kondisi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kondisi.Name = "btn_kondisi";
            this.btn_kondisi.Size = new System.Drawing.Size(172, 41);
            this.btn_kondisi.TabIndex = 79;
            this.btn_kondisi.Text = "Check Kondisi";
            this.btn_kondisi.UseVisualStyleBackColor = true;
            this.btn_kondisi.Click += new System.EventHandler(this.btn_kondisi_Click);
            // 
            // txt_ratio_bw
            // 
            this.txt_ratio_bw.AutoSize = true;
            this.txt_ratio_bw.Location = new System.Drawing.Point(680, 607);
            this.txt_ratio_bw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_ratio_bw.Name = "txt_ratio_bw";
            this.txt_ratio_bw.Size = new System.Drawing.Size(20, 17);
            this.txt_ratio_bw.TabIndex = 78;
            this.txt_ratio_bw.Text = "...";
            this.txt_ratio_bw.Click += new System.EventHandler(this.txt_ratio_bw_Click);
            // 
            // pb_extract
            // 
            this.pb_extract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_extract.Location = new System.Drawing.Point(684, 366);
            this.pb_extract.Margin = new System.Windows.Forms.Padding(4);
            this.pb_extract.Name = "pb_extract";
            this.pb_extract.Size = new System.Drawing.Size(146, 192);
            this.pb_extract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_extract.TabIndex = 77;
            this.pb_extract.TabStop = false;
            this.pb_extract.Click += new System.EventHandler(this.pb_extract_Click);
            // 
            // txt_bw
            // 
            this.txt_bw.AutoSize = true;
            this.txt_bw.Location = new System.Drawing.Point(879, 607);
            this.txt_bw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_bw.Name = "txt_bw";
            this.txt_bw.Size = new System.Drawing.Size(20, 17);
            this.txt_bw.TabIndex = 76;
            this.txt_bw.Text = "...";
            this.txt_bw.Click += new System.EventHandler(this.txt_bw_Click);
            // 
            // btn_rasio
            // 
            this.btn_rasio.Location = new System.Drawing.Point(441, 607);
            this.btn_rasio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rasio.Name = "btn_rasio";
            this.btn_rasio.Size = new System.Drawing.Size(147, 39);
            this.btn_rasio.TabIndex = 81;
            this.btn_rasio.Text = "Ekstraksi Fitur";
            this.btn_rasio.UseVisualStyleBackColor = true;
            this.btn_rasio.Click += new System.EventHandler(this.btn_rasio_Click);
            // 
            // edit_threshold
            // 
            this.edit_threshold.Location = new System.Drawing.Point(883, 432);
            this.edit_threshold.Margin = new System.Windows.Forms.Padding(4);
            this.edit_threshold.Name = "edit_threshold";
            this.edit_threshold.Size = new System.Drawing.Size(171, 22);
            this.edit_threshold.TabIndex = 82;
            this.edit_threshold.Text = "0.269";
            this.edit_threshold.TextChanged += new System.EventHandler(this.edit_threshold_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(879, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "threshold rasio putih";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(724, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Distance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_prewitt
            // 
            this.btn_prewitt.Location = new System.Drawing.Point(764, 64);
            this.btn_prewitt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prewitt.Name = "btn_prewitt";
            this.btn_prewitt.Size = new System.Drawing.Size(100, 42);
            this.btn_prewitt.TabIndex = 87;
            this.btn_prewitt.Text = "Prewitt";
            this.btn_prewitt.UseVisualStyleBackColor = true;
            this.btn_prewitt.Click += new System.EventHandler(this.btn_prewitt_Click);
            // 
            // btn_laplace
            // 
            this.btn_laplace.Location = new System.Drawing.Point(764, 113);
            this.btn_laplace.Margin = new System.Windows.Forms.Padding(4);
            this.btn_laplace.Name = "btn_laplace";
            this.btn_laplace.Size = new System.Drawing.Size(100, 42);
            this.btn_laplace.TabIndex = 88;
            this.btn_laplace.Text = "Laplace";
            this.btn_laplace.UseVisualStyleBackColor = true;
            this.btn_laplace.Click += new System.EventHandler(this.btn_laplace_Click);
            // 
            // btn_canny
            // 
            this.btn_canny.Location = new System.Drawing.Point(764, 163);
            this.btn_canny.Margin = new System.Windows.Forms.Padding(4);
            this.btn_canny.Name = "btn_canny";
            this.btn_canny.Size = new System.Drawing.Size(100, 42);
            this.btn_canny.TabIndex = 90;
            this.btn_canny.Text = "Canny";
            this.btn_canny.UseVisualStyleBackColor = true;
            this.btn_canny.Click += new System.EventHandler(this.btn_canny_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1135, 747);
            this.Controls.Add(this.btn_canny);
            this.Controls.Add(this.btn_laplace);
            this.Controls.Add(this.btn_prewitt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_threshold);
            this.Controls.Add(this.btn_rasio);
            this.Controls.Add(this.tx_hasil);
            this.Controls.Add(this.btn_kondisi);
            this.Controls.Add(this.txt_ratio_bw);
            this.Controls.Add(this.pb_extract);
            this.Controls.Add(this.txt_bw);
            this.Controls.Add(this.pb_roi_img);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_roi);
            this.Controls.Add(this.pb_roi);
            this.Controls.Add(this.pb_img);
            this.Controls.Add(this.pb_crop_sclera);
            this.Controls.Add(this.btn_sobel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_roi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_crop_sclera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_roi_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_extract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_roi;
        private System.Windows.Forms.PictureBox pb_roi;
        private System.Windows.Forms.PictureBox pb_img;

        private System.Windows.Forms.PictureBox pb_crop_sclera;
        private System.Windows.Forms.Button btn_sobel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_roi_img;
        private System.Windows.Forms.Label tx_hasil;
        private System.Windows.Forms.Button btn_kondisi;
        private System.Windows.Forms.Label txt_ratio_bw;
        private System.Windows.Forms.PictureBox pb_extract;
        private System.Windows.Forms.Label txt_bw;
        private System.Windows.Forms.Button btn_rasio;
        private System.Windows.Forms.TextBox edit_threshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_prewitt;
        private System.Windows.Forms.Button btn_laplace;
        private System.Windows.Forms.Button btn_canny;
    }
}