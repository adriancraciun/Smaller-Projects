using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batman_sPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.BackgroundImage;
            MainPanel.BackgroundImage = Properties.Resources.LogInImage;
            MainTextLabel.BackColor = System.Drawing.Color.Transparent;
        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (usernameTextBox.Text == "Batman" && passwordTextBox.Text == "Gotham")
            {
                this.Hide();
                Form SecondForm = new Batman();
                SecondForm.Closed += (s, args) => this.Close(); /// Lambda Expression 
                                                               /// ->Face o functie instant cu parametrii s si args
                                                               /// si cu codul this.Show(); . Practic, daca fereastra a doua se va deschide, 
                                                               /// doresc ca prima sa se inchida si ea
                
                SecondForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void WindowedFullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
