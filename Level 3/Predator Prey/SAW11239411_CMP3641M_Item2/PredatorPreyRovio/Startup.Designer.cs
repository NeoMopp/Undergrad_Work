namespace PredatorPreyRovio
{
    partial class Startup
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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.predBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(12, 25);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(146, 20);
            this.ipBox.TabIndex = 0;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 9);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(58, 13);
            this.ipLabel.TabIndex = 1;
            this.ipLabel.Text = "IP Address";
            // 
            // predBut
            // 
            this.predBut.Location = new System.Drawing.Point(15, 55);
            this.predBut.Name = "predBut";
            this.predBut.Size = new System.Drawing.Size(145, 31);
            this.predBut.TabIndex = 2;
            this.predBut.Text = "Predator";
            this.predBut.UseVisualStyleBackColor = true;
            this.predBut.Click += new System.EventHandler(this.predBut_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 98);
            this.Controls.Add(this.predBut);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipBox);
            this.Name = "Startup";
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button predBut;
    }
}