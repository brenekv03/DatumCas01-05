using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            char[] separators = { ' ', ';',',' };
            string[] splitedS = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            DateTime nejstarsi = DateTime.Today.AddDays(1);
            int i = 0;
            while (i < splitedS.Length)
            {
                string slovo = splitedS[i];
                if (char.IsNumber(slovo[0]))
                {
                    DateTime stringNaDate = DateTime.Parse(slovo);
                    if (stringNaDate < nejstarsi)
                    {
                        nejstarsi = stringNaDate;
                    }
                    ++i;
                }
                else ++i;          
            }
            MessageBox.Show("Nejstarší je: " + nejstarsi.ToShortDateString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
