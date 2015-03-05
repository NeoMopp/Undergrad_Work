namespace ToDoList
{
    partial class extendedTaskBuilder
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
            this.taskCancel = new System.Windows.Forms.Button();
            this.taskDone = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.Label();
            this.taskDescription = new System.Windows.Forms.Label();
            this.taskPriority = new System.Windows.Forms.Label();
            this.taskPri = new System.Windows.Forms.NumericUpDown();
            this.taskNameText = new System.Windows.Forms.TextBox();
            this.taskDescriptionText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.taskPri)).BeginInit();
            this.SuspendLayout();
            // 
            // taskCancel
            // 
            this.taskCancel.Location = new System.Drawing.Point(200, 150);
            this.taskCancel.Name = "taskCancel";
            this.taskCancel.Size = new System.Drawing.Size(72, 25);
            this.taskCancel.TabIndex = 10;
            this.taskCancel.Text = "Cancel";
            this.taskCancel.UseVisualStyleBackColor = true;
            this.taskCancel.Click += new System.EventHandler(this.taskCancel_Click);
            // 
            // taskDone
            // 
            this.taskDone.Location = new System.Drawing.Point(117, 150);
            this.taskDone.Name = "taskDone";
            this.taskDone.Size = new System.Drawing.Size(72, 25);
            this.taskDone.TabIndex = 9;
            this.taskDone.Text = "Done";
            this.taskDone.UseVisualStyleBackColor = true;
            this.taskDone.Click += new System.EventHandler(this.taskDone_Click);
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Location = new System.Drawing.Point(12, 19);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(62, 13);
            this.taskName.TabIndex = 11;
            this.taskName.Text = "Task Name";
            // 
            // taskDescription
            // 
            this.taskDescription.AutoSize = true;
            this.taskDescription.Location = new System.Drawing.Point(12, 55);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(87, 13);
            this.taskDescription.TabIndex = 12;
            this.taskDescription.Text = "Task Description";
            // 
            // taskPriority
            // 
            this.taskPriority.AutoSize = true;
            this.taskPriority.Location = new System.Drawing.Point(12, 98);
            this.taskPriority.Name = "taskPriority";
            this.taskPriority.Size = new System.Drawing.Size(65, 13);
            this.taskPriority.TabIndex = 13;
            this.taskPriority.Text = "Task Priority";
            // 
            // taskPri
            // 
            this.taskPri.Location = new System.Drawing.Point(211, 96);
            this.taskPri.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.taskPri.Name = "taskPri";
            this.taskPri.Size = new System.Drawing.Size(39, 20);
            this.taskPri.TabIndex = 14;
            // 
            // taskNameText
            // 
            this.taskNameText.Location = new System.Drawing.Point(137, 19);
            this.taskNameText.MaxLength = 16;
            this.taskNameText.Name = "taskNameText";
            this.taskNameText.Size = new System.Drawing.Size(134, 20);
            this.taskNameText.TabIndex = 15;
            // 
            // taskDescriptionText
            // 
            this.taskDescriptionText.Location = new System.Drawing.Point(138, 52);
            this.taskDescriptionText.MaxLength = 256;
            this.taskDescriptionText.Name = "taskDescriptionText";
            this.taskDescriptionText.Size = new System.Drawing.Size(134, 20);
            this.taskDescriptionText.TabIndex = 16;
            // 
            // extendedTaskBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.taskDescriptionText);
            this.Controls.Add(this.taskNameText);
            this.Controls.Add(this.taskPri);
            this.Controls.Add(this.taskPriority);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.taskCancel);
            this.Controls.Add(this.taskDone);
            this.Name = "extendedTaskBuilder";
            this.Text = "To Do List - Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.extendedTaskBuilder_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.taskPri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taskCancel;
        private System.Windows.Forms.Button taskDone;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Label taskDescription;
        private System.Windows.Forms.Label taskPriority;
        private System.Windows.Forms.NumericUpDown taskPri;
        private System.Windows.Forms.TextBox taskNameText;
        private System.Windows.Forms.TextBox taskDescriptionText;

    }
}