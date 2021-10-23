namespace AnimalsShelter
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.labelInf = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInf
            // 
            this.labelInf.BackColor = System.Drawing.Color.Transparent;
            this.labelInf.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInf.ForeColor = System.Drawing.Color.DimGray;
            this.labelInf.Location = new System.Drawing.Point(12, 55);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(586, 82);
            this.labelInf.TabIndex = 0;
            this.labelInf.Text = "Toate animalele din AdapostulBN sunt vaccinate si sterilizate";
            this.labelInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEnter.Location = new System.Drawing.Point(209, 190);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(198, 71);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 587);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labelInf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInterface";
            this.Text = "AdapostBN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInf;
        private System.Windows.Forms.Button btnEnter;
    }
}