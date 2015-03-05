namespace ToDoList
{
    partial class noteBuilder
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
            this.noteName = new System.Windows.Forms.Label();
            this.noteDescription = new System.Windows.Forms.Label();
            this.noteDetails = new System.Windows.Forms.Label();
            this.noteNameText = new System.Windows.Forms.TextBox();
            this.noteDescriptionText = new System.Windows.Forms.TextBox();
            this.noteDetailsText = new System.Windows.Forms.RichTextBox();
            this.noteDone = new System.Windows.Forms.Button();
            this.noteCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteName
            // 
            this.noteName.AutoSize = true;
            this.noteName.Location = new System.Drawing.Point(15, 17);
            this.noteName.Name = "noteName";
            this.noteName.Size = new System.Drawing.Size(61, 13);
            this.noteName.TabIndex = 0;
            this.noteName.Text = "Note Name";
            // 
            // noteDescription
            // 
            this.noteDescription.AutoSize = true;
            this.noteDescription.Location = new System.Drawing.Point(15, 68);
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.Size = new System.Drawing.Size(86, 13);
            this.noteDescription.TabIndex = 1;
            this.noteDescription.Text = "Note Description";
            // 
            // noteDetails
            // 
            this.noteDetails.AutoSize = true;
            this.noteDetails.Location = new System.Drawing.Point(11, 113);
            this.noteDetails.Name = "noteDetails";
            this.noteDetails.Size = new System.Drawing.Size(65, 13);
            this.noteDetails.TabIndex = 2;
            this.noteDetails.Text = "Note Details";
            // 
            // noteNameText
            // 
            this.noteNameText.Location = new System.Drawing.Point(139, 14);
            this.noteNameText.MaxLength = 16;
            this.noteNameText.Name = "noteNameText";
            this.noteNameText.Size = new System.Drawing.Size(133, 20);
            this.noteNameText.TabIndex = 3;
            // 
            // noteDescriptionText
            // 
            this.noteDescriptionText.Location = new System.Drawing.Point(139, 65);
            this.noteDescriptionText.MaxLength = 256;
            this.noteDescriptionText.Name = "noteDescriptionText";
            this.noteDescriptionText.Size = new System.Drawing.Size(133, 20);
            this.noteDescriptionText.TabIndex = 5;
            // 
            // noteDetailsText
            // 
            this.noteDetailsText.Location = new System.Drawing.Point(139, 112);
            this.noteDetailsText.Name = "noteDetailsText";
            this.noteDetailsText.Size = new System.Drawing.Size(133, 122);
            this.noteDetailsText.TabIndex = 6;
            this.noteDetailsText.Text = "";
            // 
            // noteDone
            // 
            this.noteDone.Location = new System.Drawing.Point(117, 252);
            this.noteDone.Name = "noteDone";
            this.noteDone.Size = new System.Drawing.Size(72, 25);
            this.noteDone.TabIndex = 7;
            this.noteDone.Text = "Done";
            this.noteDone.UseVisualStyleBackColor = true;
            this.noteDone.Click += new System.EventHandler(this.noteDone_Click);
            // 
            // noteCancel
            // 
            this.noteCancel.Location = new System.Drawing.Point(200, 252);
            this.noteCancel.Name = "noteCancel";
            this.noteCancel.Size = new System.Drawing.Size(72, 25);
            this.noteCancel.TabIndex = 8;
            this.noteCancel.Text = "Cancel";
            this.noteCancel.UseVisualStyleBackColor = true;
            this.noteCancel.Click += new System.EventHandler(this.noteCancel_Click);
            // 
            // noteBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 289);
            this.Controls.Add(this.noteCancel);
            this.Controls.Add(this.noteDone);
            this.Controls.Add(this.noteDetailsText);
            this.Controls.Add(this.noteDescriptionText);
            this.Controls.Add(this.noteNameText);
            this.Controls.Add(this.noteDetails);
            this.Controls.Add(this.noteDescription);
            this.Controls.Add(this.noteName);
            this.Name = "noteBuilder";
            this.Text = "noteBuilder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.noteBuilder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteName;
        private System.Windows.Forms.Label noteDescription;
        private System.Windows.Forms.Label noteDetails;
        private System.Windows.Forms.TextBox noteNameText;
        private System.Windows.Forms.TextBox noteDescriptionText;
        private System.Windows.Forms.RichTextBox noteDetailsText;
        private System.Windows.Forms.Button noteDone;
        private System.Windows.Forms.Button noteCancel;
    }
}