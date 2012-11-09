using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace converter
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Binary = BinaryText.Text;
            string Output="";
           
            double IntValue=0;
            List<int> IntBinaryLst= new List<int>();
            double RaisePower=8;
            foreach (char c in Binary)
            {
                if (c == ' ')
                {
                    IntBinaryLst.Add(((int)IntValue)/2);
                    IntValue = 0;
                    RaisePower = 8;
                    continue;
                }
                if(c=='1')
                IntValue += Math.Pow(2, RaisePower);
                RaisePower--;


            }
            foreach (var i in IntBinaryLst)
            {
                
                Output += (char)i;
            }
            textBox2.Text = Output;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = textBox2.Text;
            string o = "";
          
            foreach (char i in t)
            {
                string s = "";
                int b = (int)i;
               for (int tt=0;tt<8;tt++)
                {
                    s += (b % 2).ToString();
                    b=b/2;
                }
                for (int ip = 0; ip < 8; ip++)
                    o += s[7 - ip];
                o += " ";
            }
            BinaryText.Text = o;
        }
    }
}
