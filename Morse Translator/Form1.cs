using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Created & published by Ilya Kalitov 
 * swterr at outlook dot com
 * github.com/svtrv 
 */
 //TODO: clipboard copy
namespace Morse_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MorseLib morse = new MorseLib();
        }

        public int lengthOfSound = 60;// in ms
        public int frequency = 550; // in Hz

        private bool isCurrentModeM2T()
        {
            if (m2tbtn.Enabled)//if morse to text btn is avaiable to enable, then current mode is text to morse
            {
                return false;
            }
            else return true;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isCurrentModeM2T())
            {

            }
            else
            {
                outputTextBox.Text = MorseLib.TextToMorse(inputTextBox.Text);
            }
        }

        async Task wordDelay()
        {
            await Task.Delay(lengthOfSound*7);
        }
        async Task symbolDelay()
        {
            await Task.Delay(lengthOfSound);
        }
        async Task letterDelay()
        {
            await Task.Delay(lengthOfSound * 3);
        }
        async Task playSound(int multiplier)
        {
            await Task.Run(() =>
            {
                Console.Beep(frequency, lengthOfSound * multiplier);
            });
        }
        private async void playbtn_Click(object sender, EventArgs e)
        {
            playbtn.Enabled = false;

            byte[][][] result = MorseLib.TextToMorseBytes(inputTextBox.Text);
            foreach(byte[][] word in result)
            {
                foreach(byte[] letter in word)
                {
                    foreach (byte beep in letter)
                    {
                        if (beep == MorseLib.dot)
                        {
                            await playSound(1);
                        }
                        else if (beep == MorseLib.dash)
                        {
                            await playSound(3);
                        }
                        await symbolDelay();
                    }
                    await letterDelay();
                }
                await wordDelay();
            }

            playbtn.Enabled = true;
        }

        private void wpmTextBox_TextChanged(object sender, EventArgs e)
        {
            int wpm;
            if (int.TryParse(wpmTextBox.Text, out wpm)) {
                lengthOfSound = 1200 / wpm;
                if (wpmTextBox.ForeColor == Color.DarkRed)
                {
                    wpmTextBox.ForeColor = Color.Black;
                }
            }
            else
            {
                wpmTextBox.ForeColor = Color.DarkRed;
            }
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);
        }
    }
}
