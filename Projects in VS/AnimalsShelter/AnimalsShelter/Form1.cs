using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalsShelter
{
    public partial class AnimalsShelterForm : Form
    {
        public AnimalsShelterForm()
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = Properties.Resources.bg1;

            InitializeComponent();

            this.dogsroundButton.BackgroundImage = Properties.Resources.dog;
            this.catroundButton.BackgroundImage = Properties.Resources.cat;
            this.dogsandcatsroundButton.BackgroundImage = Properties.Resources.dogsandcats;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.animaleDataSet1.Table);
        }

        private void BtnAdopt_Click(object sender, EventArgs e)
        {

            if (this.textBoxAdopt.Text != "")
            {
                tableTableAdapter.AdoptAnAnimal(Int32.Parse(textBoxAdopt.Text));
                this.tableTableAdapter.Fill(this.animaleDataSet1.Table);
            }


        }

        private void DogsroundButton_Click(object sender, EventArgs e)
        {
            string animal = "Caine";
            this.tableTableAdapter.FillBySubcategory(this.animaleDataSet1.Table, animal);
        }

        private void CatroundButton_Click(object sender, EventArgs e)
        {
            string animal = "Pisica";
            this.tableTableAdapter.FillBySubcategory(this.animaleDataSet1.Table, animal);
        }

        private void DogsandcatsroundButton_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.animaleDataSet1.Table);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
