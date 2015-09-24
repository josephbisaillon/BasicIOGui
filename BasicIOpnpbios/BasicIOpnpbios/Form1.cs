using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BasicIOpnpbios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printResultsButton_Click(object sender, EventArgs e)
        {
            string name =  nameTextBox.Text;
            string rooms = roomTextBox.Text.Replace(',', '+');

            using (StreamWriter file = new StreamWriter("savedfile.txt", true))
            {
                file.WriteLine(name + " " + rooms);
            }

            MessageBox.Show(name + " " + rooms + " \nSuccessfully Printed");
        }
    }
}
