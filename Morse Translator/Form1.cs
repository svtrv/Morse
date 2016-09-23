using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isCurrentModeM2T()
        {
            if (m2tbtn.Enabled)//if morse to text btn is avaiable to enable, then current mode is text to morse
            {
                return false;
            }
            else return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isCurrentModeM2T())
            {

            }
        }
    }
}
