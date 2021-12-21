
namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btngray = new System.Windows.Forms.Button();
            this.btnmirrorH = new System.Windows.Forms.Button();
            this.btnmirrorV = new System.Windows.Forms.Button();
            this.btnmakecopy = new System.Windows.Forms.Button();
            this.btnquant = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnhisto = new System.Windows.Forms.Button();
            this.btnBri = new System.Windows.Forms.Button();
            this.textBoxBri = new System.Windows.Forms.TextBox();
            this.btnNeg = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.textBoxCont = new System.Windows.Forms.TextBox();
            this.btnRot = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnZIn = new System.Windows.Forms.Button();
            this.btnZOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(95, 57);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(546, 436);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(844, 57);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(546, 436);
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(60, 580);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(132, 49);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btngray
            // 
            this.btngray.Location = new System.Drawing.Point(367, 580);
            this.btngray.Name = "btngray";
            this.btngray.Size = new System.Drawing.Size(132, 49);
            this.btngray.TabIndex = 3;
            this.btngray.Text = "Gray";
            this.btngray.UseVisualStyleBackColor = true;
            this.btngray.Click += new System.EventHandler(this.btngray_Click);
            // 
            // btnmirrorH
            // 
            this.btnmirrorH.Location = new System.Drawing.Point(509, 580);
            this.btnmirrorH.Name = "btnmirrorH";
            this.btnmirrorH.Size = new System.Drawing.Size(132, 49);
            this.btnmirrorH.TabIndex = 4;
            this.btnmirrorH.Text = "MirrorH";
            this.btnmirrorH.UseVisualStyleBackColor = true;
            this.btnmirrorH.Click += new System.EventHandler(this.btnmirrorH_Click);
            // 
            // btnmirrorV
            // 
            this.btnmirrorV.Location = new System.Drawing.Point(675, 580);
            this.btnmirrorV.Name = "btnmirrorV";
            this.btnmirrorV.Size = new System.Drawing.Size(132, 49);
            this.btnmirrorV.TabIndex = 5;
            this.btnmirrorV.Text = "MirrorV";
            this.btnmirrorV.UseVisualStyleBackColor = true;
            this.btnmirrorV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmakecopy
            // 
            this.btnmakecopy.Location = new System.Drawing.Point(216, 580);
            this.btnmakecopy.Name = "btnmakecopy";
            this.btnmakecopy.Size = new System.Drawing.Size(132, 49);
            this.btnmakecopy.TabIndex = 6;
            this.btnmakecopy.Text = "Make Copy";
            this.btnmakecopy.UseVisualStyleBackColor = true;
            this.btnmakecopy.Click += new System.EventHandler(this.btnmakecopy_Click);
            // 
            // btnquant
            // 
            this.btnquant.Location = new System.Drawing.Point(675, 12);
            this.btnquant.Name = "btnquant";
            this.btnquant.Size = new System.Drawing.Size(132, 49);
            this.btnquant.TabIndex = 7;
            this.btnquant.Text = "Quantify";
            this.btnquant.UseVisualStyleBackColor = true;
            this.btnquant.Click += new System.EventHandler(this.btnquant_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1258, 580);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(132, 49);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(703, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 23);
            this.textBox1.TabIndex = 9;
            // 
            // btnhisto
            // 
            this.btnhisto.Location = new System.Drawing.Point(675, 96);
            this.btnhisto.Name = "btnhisto";
            this.btnhisto.Size = new System.Drawing.Size(132, 49);
            this.btnhisto.TabIndex = 10;
            this.btnhisto.Text = "Histogram";
            this.btnhisto.UseVisualStyleBackColor = true;
            this.btnhisto.Click += new System.EventHandler(this.btnhisto_Click);
            // 
            // btnBri
            // 
            this.btnBri.Location = new System.Drawing.Point(675, 151);
            this.btnBri.Name = "btnBri";
            this.btnBri.Size = new System.Drawing.Size(132, 49);
            this.btnBri.TabIndex = 11;
            this.btnBri.Text = "Brightness";
            this.btnBri.UseVisualStyleBackColor = true;
            this.btnBri.Click += new System.EventHandler(this.btnBri_Click);
            // 
            // textBoxBri
            // 
            this.textBoxBri.Location = new System.Drawing.Point(703, 206);
            this.textBoxBri.Name = "textBoxBri";
            this.textBoxBri.Size = new System.Drawing.Size(74, 23);
            this.textBoxBri.TabIndex = 12;
            // 
            // btnNeg
            // 
            this.btnNeg.Location = new System.Drawing.Point(675, 235);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(132, 49);
            this.btnNeg.TabIndex = 13;
            this.btnNeg.Text = "Negative";
            this.btnNeg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(675, 290);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(132, 49);
            this.btnCont.TabIndex = 14;
            this.btnCont.Text = "Contrast";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // textBoxCont
            // 
            this.textBoxCont.Location = new System.Drawing.Point(703, 345);
            this.textBoxCont.Name = "textBoxCont";
            this.textBoxCont.Size = new System.Drawing.Size(74, 23);
            this.textBoxCont.TabIndex = 15;
            // 
            // btnRot
            // 
            this.btnRot.Location = new System.Drawing.Point(675, 374);
            this.btnRot.Name = "btnRot";
            this.btnRot.Size = new System.Drawing.Size(132, 49);
            this.btnRot.TabIndex = 16;
            this.btnRot.Text = "Rotate";
            this.btnRot.UseVisualStyleBackColor = true;
            this.btnRot.Click += new System.EventHandler(this.btnRot_Click);
            // 
            // btnEq
            // 
            this.btnEq.Location = new System.Drawing.Point(675, 444);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(132, 49);
            this.btnEq.TabIndex = 17;
            this.btnEq.Text = "Equalize";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnZIn
            // 
            this.btnZIn.Location = new System.Drawing.Point(830, 580);
            this.btnZIn.Name = "btnZIn";
            this.btnZIn.Size = new System.Drawing.Size(132, 49);
            this.btnZIn.TabIndex = 18;
            this.btnZIn.Text = "Zoom In";
            this.btnZIn.UseVisualStyleBackColor = true;
            this.btnZIn.Click += new System.EventHandler(this.btnZIn_Click);
            // 
            // btnZOut
            // 
            this.btnZOut.Location = new System.Drawing.Point(1008, 580);
            this.btnZOut.Name = "btnZOut";
            this.btnZOut.Size = new System.Drawing.Size(132, 49);
            this.btnZOut.TabIndex = 19;
            this.btnZOut.Text = "Zoom Out";
            this.btnZOut.UseVisualStyleBackColor = true;
            this.btnZOut.Click += new System.EventHandler(this.btnZOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 651);
            this.Controls.Add(this.btnZOut);
            this.Controls.Add(this.btnZIn);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btnRot);
            this.Controls.Add(this.textBoxCont);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.textBoxBri);
            this.Controls.Add(this.btnBri);
            this.Controls.Add(this.btnhisto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnquant);
            this.Controls.Add(this.btnmakecopy);
            this.Controls.Add(this.btnmirrorV);
            this.Controls.Add(this.btnmirrorH);
            this.Controls.Add(this.btngray);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btngray;
        private System.Windows.Forms.Button btnmirrorH;
        private System.Windows.Forms.Button btnmirrorV;
        private System.Windows.Forms.Button btnmakecopy;
        private System.Windows.Forms.Button btnquant;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnhisto;
        private System.Windows.Forms.Button btnBri;
        private System.Windows.Forms.TextBox textBoxBri;
        private System.Windows.Forms.Button btnNeg;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.TextBox textBoxCont;
        private System.Windows.Forms.Button btnRot;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnZIn;
        private System.Windows.Forms.Button btnZOut;
    }
}

