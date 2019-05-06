namespace PassFail
{
    partial class frmPassFail
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
            this.btnParseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParseFile
            // 
            this.btnParseFile.Font = new System.Drawing.Font("Times New Roman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseFile.Location = new System.Drawing.Point(47, 97);
            this.btnParseFile.Name = "btnParseFile";
            this.btnParseFile.Size = new System.Drawing.Size(714, 169);
            this.btnParseFile.TabIndex = 0;
            this.btnParseFile.Text = "Parse File";
            this.btnParseFile.UseVisualStyleBackColor = true;
            this.btnParseFile.Click += new System.EventHandler(this.btnParseFile_Click);
            // 
            // frmPassFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 448);
            this.Controls.Add(this.btnParseFile);
            this.Name = "frmPassFail";
            this.Text = "Pass Fail Zach K";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParseFile;
    }
}

