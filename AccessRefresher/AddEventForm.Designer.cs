namespace AccessRefresher
{
    partial class AddEventForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtAccessFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(674, 299);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Submit";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(137, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 23);
            this.progressBar.TabIndex = 1;
            // 
            // txtAccessFile
            // 
            this.txtAccessFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccessFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtAccessFile.Location = new System.Drawing.Point(84, 58);
            this.txtAccessFile.Name = "txtAccessFile";
            this.txtAccessFile.Size = new System.Drawing.Size(228, 20);
            this.txtAccessFile.TabIndex = 2;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 334);
            this.Controls.Add(this.txtAccessFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnOK);
            this.Name = "AddEventForm";
            this.Text = "New Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtAccessFile;
    }
}

