namespace AnimalsShelter
{
    partial class AnimalsShelterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalsShelterForm));
            this.animalsdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaEstimataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aspecteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaleDataSet1 = new AnimalsShelter.AnimaleDataSet1();
            this.btnAdopt = new System.Windows.Forms.Button();
            this.groupBoxAdopt = new System.Windows.Forms.GroupBox();
            this.textBoxAdopt = new System.Windows.Forms.TextBox();
            this.labelAdopt = new System.Windows.Forms.Label();
            this.tableTableAdapter = new AnimalsShelter.AnimaleDataSet1TableAdapters.TableTableAdapter();
            this.contactrichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContact = new System.Windows.Forms.Label();
            this.dogsandcatsroundButton = new AnimalsShelter.RoundButton();
            this.catroundButton = new AnimalsShelter.RoundButton();
            this.dogsroundButton = new AnimalsShelter.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.animalsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaleDataSet1)).BeginInit();
            this.groupBoxAdopt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalsdataGridView
            // 
            this.animalsdataGridView.AllowUserToAddRows = false;
            this.animalsdataGridView.AllowUserToDeleteRows = false;
            this.animalsdataGridView.AllowUserToResizeColumns = false;
            this.animalsdataGridView.AllowUserToResizeRows = false;
            this.animalsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animalsdataGridView.AutoGenerateColumns = false;
            this.animalsdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.animalsdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.animalsdataGridView.BackgroundColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.animalsdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.animalsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subcategorieDataGridViewTextBoxColumn,
            this.varstaEstimataDataGridViewTextBoxColumn,
            this.aspecteDataGridViewTextBoxColumn});
            this.animalsdataGridView.DataSource = this.tableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.animalsdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.animalsdataGridView.EnableHeadersVisualStyles = false;
            this.animalsdataGridView.GridColor = System.Drawing.Color.Peru;
            this.animalsdataGridView.Location = new System.Drawing.Point(625, 127);
            this.animalsdataGridView.Name = "animalsdataGridView";
            this.animalsdataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.animalsdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Moccasin;
            this.animalsdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.animalsdataGridView.Size = new System.Drawing.Size(1137, 433);
            this.animalsdataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 68;
            // 
            // subcategorieDataGridViewTextBoxColumn
            // 
            this.subcategorieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subcategorieDataGridViewTextBoxColumn.DataPropertyName = "Subcategorie";
            this.subcategorieDataGridViewTextBoxColumn.HeaderText = "Subcategorie";
            this.subcategorieDataGridViewTextBoxColumn.Name = "subcategorieDataGridViewTextBoxColumn";
            this.subcategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.subcategorieDataGridViewTextBoxColumn.Width = 213;
            // 
            // varstaEstimataDataGridViewTextBoxColumn
            // 
            this.varstaEstimataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.varstaEstimataDataGridViewTextBoxColumn.DataPropertyName = "Varsta estimata";
            this.varstaEstimataDataGridViewTextBoxColumn.HeaderText = "Varsta estimata";
            this.varstaEstimataDataGridViewTextBoxColumn.Name = "varstaEstimataDataGridViewTextBoxColumn";
            this.varstaEstimataDataGridViewTextBoxColumn.ReadOnly = true;
            this.varstaEstimataDataGridViewTextBoxColumn.Width = 229;
            // 
            // aspecteDataGridViewTextBoxColumn
            // 
            this.aspecteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aspecteDataGridViewTextBoxColumn.DataPropertyName = "Aspecte";
            this.aspecteDataGridViewTextBoxColumn.HeaderText = "Aspecte";
            this.aspecteDataGridViewTextBoxColumn.Name = "aspecteDataGridViewTextBoxColumn";
            this.aspecteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.animaleDataSet1;
            // 
            // animaleDataSet1
            // 
            this.animaleDataSet1.DataSetName = "AnimaleDataSet1";
            this.animaleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdopt
            // 
            this.btnAdopt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(160)))));
            this.btnAdopt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdopt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdopt.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdopt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.btnAdopt.Location = new System.Drawing.Point(11, 126);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(257, 55);
            this.btnAdopt.TabIndex = 1;
            this.btnAdopt.Text = "Adopta";
            this.btnAdopt.UseVisualStyleBackColor = false;
            this.btnAdopt.Click += new System.EventHandler(this.BtnAdopt_Click);
            // 
            // groupBoxAdopt
            // 
            this.groupBoxAdopt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdopt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.groupBoxAdopt.Controls.Add(this.textBoxAdopt);
            this.groupBoxAdopt.Controls.Add(this.labelAdopt);
            this.groupBoxAdopt.Controls.Add(this.btnAdopt);
            this.groupBoxAdopt.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdopt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(160)))));
            this.groupBoxAdopt.Location = new System.Drawing.Point(1481, 682);
            this.groupBoxAdopt.Name = "groupBoxAdopt";
            this.groupBoxAdopt.Size = new System.Drawing.Size(281, 199);
            this.groupBoxAdopt.TabIndex = 2;
            this.groupBoxAdopt.TabStop = false;
            this.groupBoxAdopt.Text = "Adopta un animal";
            // 
            // textBoxAdopt
            // 
            this.textBoxAdopt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(160)))));
            this.textBoxAdopt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdopt.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdopt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.textBoxAdopt.Location = new System.Drawing.Point(64, 81);
            this.textBoxAdopt.Name = "textBoxAdopt";
            this.textBoxAdopt.Size = new System.Drawing.Size(204, 32);
            this.textBoxAdopt.TabIndex = 3;
            // 
            // labelAdopt
            // 
            this.labelAdopt.AutoSize = true;
            this.labelAdopt.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdopt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(160)))));
            this.labelAdopt.Location = new System.Drawing.Point(11, 81);
            this.labelAdopt.Name = "labelAdopt";
            this.labelAdopt.Size = new System.Drawing.Size(47, 31);
            this.labelAdopt.TabIndex = 2;
            this.labelAdopt.Text = "Id:";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // contactrichTextBox
            // 
            this.contactrichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(164)))), ((int)(((byte)(177)))));
            this.contactrichTextBox.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactrichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.contactrichTextBox.Location = new System.Drawing.Point(132, 213);
            this.contactrichTextBox.Name = "contactrichTextBox";
            this.contactrichTextBox.ReadOnly = true;
            this.contactrichTextBox.Size = new System.Drawing.Size(381, 668);
            this.contactrichTextBox.TabIndex = 5;
            this.contactrichTextBox.Text = resources.GetString("contactrichTextBox.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Location = new System.Drawing.Point(132, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 89);
            this.panel1.TabIndex = 6;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.lblContact.Location = new System.Drawing.Point(110, 21);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(157, 47);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact";
            // 
            // dogsandcatsroundButton
            // 
            this.dogsandcatsroundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dogsandcatsroundButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dogsandcatsroundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dogsandcatsroundButton.FlatAppearance.BorderSize = 0;
            this.dogsandcatsroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dogsandcatsroundButton.Location = new System.Drawing.Point(625, 684);
            this.dogsandcatsroundButton.Name = "dogsandcatsroundButton";
            this.dogsandcatsroundButton.Size = new System.Drawing.Size(199, 199);
            this.dogsandcatsroundButton.TabIndex = 7;
            this.dogsandcatsroundButton.UseVisualStyleBackColor = false;
            this.dogsandcatsroundButton.Click += new System.EventHandler(this.DogsandcatsroundButton_Click);
            // 
            // catroundButton
            // 
            this.catroundButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.catroundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catroundButton.FlatAppearance.BorderSize = 0;
            this.catroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catroundButton.Location = new System.Drawing.Point(1195, 684);
            this.catroundButton.Name = "catroundButton";
            this.catroundButton.Size = new System.Drawing.Size(199, 199);
            this.catroundButton.TabIndex = 4;
            this.catroundButton.UseVisualStyleBackColor = false;
            this.catroundButton.Click += new System.EventHandler(this.CatroundButton_Click);
            // 
            // dogsroundButton
            // 
            this.dogsroundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dogsroundButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dogsroundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dogsroundButton.FlatAppearance.BorderSize = 0;
            this.dogsroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dogsroundButton.Location = new System.Drawing.Point(883, 682);
            this.dogsroundButton.Name = "dogsroundButton";
            this.dogsroundButton.Size = new System.Drawing.Size(199, 199);
            this.dogsroundButton.TabIndex = 3;
            this.dogsroundButton.UseVisualStyleBackColor = false;
            this.dogsroundButton.Click += new System.EventHandler(this.DogsroundButton_Click);
            // 
            // AnimalsShelterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1873, 989);
            this.Controls.Add(this.dogsandcatsroundButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contactrichTextBox);
            this.Controls.Add(this.catroundButton);
            this.Controls.Add(this.dogsroundButton);
            this.Controls.Add(this.groupBoxAdopt);
            this.Controls.Add(this.animalsdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalsShelterForm";
            this.Text = "AdapostBN_Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaleDataSet1)).EndInit();
            this.groupBoxAdopt.ResumeLayout(false);
            this.groupBoxAdopt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView animalsdataGridView;
        private AnimaleDataSet1 animaleDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AnimaleDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.GroupBox groupBoxAdopt;
        private System.Windows.Forms.TextBox textBoxAdopt;
        private System.Windows.Forms.Label labelAdopt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaEstimataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aspecteDataGridViewTextBoxColumn;
        private RoundButton dogsroundButton;
        private RoundButton catroundButton;
        private System.Windows.Forms.RichTextBox contactrichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContact;
        private RoundButton dogsandcatsroundButton;
    }
}

