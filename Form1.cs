using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountingVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A vowel counter using stringBuilder
        private void button1_Click(object sender, EventArgs e)
        {
            // Make a new stringbuilder to hold all the vowels
            StringBuilder vowels = new StringBuilder("aeiou");

            // Make a new stringbuilder with text in textbox
            StringBuilder totalText = new StringBuilder();

            // Make a new stringbuilder to hold all the text that are vowels
            StringBuilder vowelText = new StringBuilder();

            // Check if the textBox has a value, display error if no value
            if (textBox1 != null)
            {
                // Append text to totalText stringbuilder
                totalText.Append(textBox1.Text);
                foreach (char i in totalText.ToString())
                {
                    // If the character is a vowel add to vowelText stringbuilder
                    if (vowels.ToString().ToLower().Contains(i)) vowelText.Append(i);
                }

                // Add vowel count to textBox 
                textBox2.Text = vowelText.ToString();
            }
        }
    }
}
