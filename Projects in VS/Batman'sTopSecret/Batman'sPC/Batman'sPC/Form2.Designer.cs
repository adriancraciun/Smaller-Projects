namespace Batman_sPC
{
    partial class Batman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batman));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BatmanGifPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BatmanGifPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BatmanGifPictureBox
            // 
            this.BatmanGifPictureBox.Location = new System.Drawing.Point(97, 72);
            this.BatmanGifPictureBox.Name = "BatmanGifPictureBox";
            this.BatmanGifPictureBox.Size = new System.Drawing.Size(238, 186);
            this.BatmanGifPictureBox.TabIndex = 0;
            this.BatmanGifPictureBox.TabStop = false;
            // 
            // Batman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 375);
            this.Controls.Add(this.BatmanGifPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Batman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batman";
            ((System.ComponentModel.ISupportInitialize)(this.BatmanGifPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox BatmanGifPictureBox;
    }
}