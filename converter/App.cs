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

        private void BinaryText2Text_Click(object sender, EventArgs e)
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
            PlainText.Text = Output;
            
        }

        private void Text2BinaryText_Click(object sender, EventArgs e)
        {
            string Plain = PlainText.Text;
            string OutPut = "";
          
            foreach (char i in Plain)
            {
                string Single = "";
                int IntegerVal = (int)i;
               for (int tt=0;tt<8;tt++)
                {
                    Single += (IntegerVal % 2).ToString();
                    IntegerVal=IntegerVal/2;
                }
                //reversing
                for (int ip = 0; ip < 8; ip++)
                    OutPut += Single[7 - ip];
                OutPut += " ";
            }
            BinaryText.Text = OutPut;
        }
    }
}
