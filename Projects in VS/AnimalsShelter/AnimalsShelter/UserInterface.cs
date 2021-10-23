using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnimalsShelter
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackgroundImage = Properties.Resources.omaga;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form f1 = new AnimalsShelterForm();
            f1.Show();

            f1.Closed += (s, args) => this.Close(); /// Lambda Expression 
                                                    /// ->Face o functie instant cu parametrii s si args
                                                    /// si cu codul this.Close(); . Practic, daca fereastra a doua se va inchide, 
                                                    /// doresc ca si prima fereastra care e ascunsa sa se inchida
        }


    }
}
