namespace PredatorPreyRovio
{
    partial class PredatorForm
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
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.filtImage = new System.Windows.Forms.PictureBox();
            this.sourceLab = new System.Windows.Forms.Label();
            this.filtLab = new System.Windows.Forms.Label();
            this.greenFilt = new System.Windows.Forms.PictureBox();
            this.geenLab = new System.Windows.Forms.Label();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.filtBlue = new System.Windows.Forms.Label();
            this.stateLab = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceImage
            // 
            this.sourceImage.Location = new System.Drawing.Point(12, 25);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(352, 288);
            this.sourceImage.TabIndex = 0;
            this.sourceImage.TabStop = false;
            // 
            // filtImage
            // 
            this.filtImage.Location = new System.Drawing.Point(12, 354);
            this.filtImage.Name = "filtImage";
            this.filtImage.Size = new System.Drawing.Size(352, 288);
            this.filtImage.TabIndex = 1;
            this.filtImage.TabStop = false;
            // 
            // sourceLab
            // 
            this.sourceLab.AutoSize = true;
            this.sourceLab.Location = new System.Drawing.Point(12, 9);
            this.sourceLab.Name = "sourceLab";
            this.sourceLab.Size = new System.Drawing.Size(41, 13);
            this.sourceLab.TabIndex = 2;
            this.sourceLab.Text = "Source";
            // 
            // filtLab
            // 
            this.filtLab.AutoSize = true;
            this.filtLab.Location = new System.Drawing.Point(9, 338);
            this.filtLab.Name = "filtLab";
            this.filtLab.Size = new System.Drawing.Size(52, 13);
            this.filtLab.TabIndex = 3;
            this.filtLab.Text = "Filter Red";
            // 
            // greenFilt
            // 
            this.greenFilt.Location = new System.Drawing.Point(370, 354);
            this.greenFilt.Name = "greenFilt";
            this.greenFilt.Size = new System.Drawing.Size(352, 288);
            this.greenFilt.TabIndex = 4;
            this.greenFilt.TabStop = false;
            // 
            // geenLab
            // 
            this.geenLab.AutoSize = true;
            this.geenLab.Location = new System.Drawing.Point(367, 338);
            this.geenLab.Name = "geenLab";
            this.geenLab.Size = new System.Drawing.Size(61, 13);
            this.geenLab.TabIndex = 5;
            this.geenLab.Text = "Filter Green";
            // 
            // blueImage
            // 
            this.blueImage.Location = new System.Drawing.Point(728, 354);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(352, 288);
            this.blueImage.TabIndex = 6;
            this.blueImage.TabStop = false;
            // 
            // filtBlue
            // 
            this.filtBlue.AutoSize = true;
            this.filtBlue.Location = new System.Drawing.Point(725, 338);
            this.filtBlue.Name = "filtBlue";
            this.filtBlue.Size = new System.Drawing.Size(53, 13);
            this.filtBlue.TabIndex = 7;
            this.filtBlue.Text = "Filter Blue";
            // 
            // stateLab
            // 
            this.stateLab.AutoSize = true;
            this.stateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLab.Location = new System.Drawing.Point(371, 25);
            this.stateLab.Name = "stateLab";
            this.stateLab.Size = new System.Drawing.Size(103, 18);
            this.stateLab.TabIndex = 8;
            this.stateLab.Text = "Current State: ";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(481, 29);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 18);
            this.stateLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Object:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Object Direction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PredatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateLab);
            this.Controls.Add(this.filtBlue);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.geenLab);
            this.Controls.Add(this.greenFilt);
            this.Controls.Add(this.filtLab);
            this.Controls.Add(this.sourceLab);
            this.Controls.Add(this.filtImage);
            this.Controls.Add(this.sourceImage);
            this.Name = "PredatorForm";
            this.Text = "PredatorForm";
            this.Load += new System.EventHandler(this.PredatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.PictureBox filtImage;
        private System.Windows.Forms.Label sourceLab;
        private System.Windows.Forms.Label filtLab;
        private System.Windows.Forms.PictureBox greenFilt;
        private System.Windows.Forms.Label geenLab;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.Label filtBlue;
        private System.Windows.Forms.Label stateLab;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}