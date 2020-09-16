using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {


      //  double value;
        double result;
        string operationExecute = " ";
 
        bool operationDo= false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
             Button btn = (Button)sender;
            if ((textBox_Output.Text == "0") || operationDo)
                 textBox_Output.Clear();
             operationDo = false;
            textBox_Output.Text = textBox_Output.Text + btn.Text;

           // Button btn = (Button)sender;
          //  textBox_Output.Text = textBox_Output.Text + btn.Text;
          


        }
        private void button2_Click(object sender, EventArgs e)
        {
           /* if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + ".";
            */

        }

        private void button6_Click(object sender, EventArgs e)
        {
           if ((textBox_Output.Text == "0")|| operationDo)
                textBox_Output.Clear();
               Button btn = (Button)sender;
            textBox_Output.Text = textBox_Output.Text + "1";
            operationDo = true;
            



        }

        private void button8_Click(object sender, EventArgs e)
        {
          /*  if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "3";
            operationDo = true;
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
            if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "2";
            operationDo = true;
            */

        }

        private void button15_Click(object sender, EventArgs e)
        {
          /*  if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "4";
            operationDo = true;
            */

        }

        private void button14_Click(object sender, EventArgs e)
        {
         /*   if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "5";
            operationDo = true;
            */

        }

        private void button13_Click(object sender, EventArgs e)
        {
         /*   if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "6";
            operationDo = true;
            */

        }

        private void button20_Click(object sender, EventArgs e)
        {
         /*   if ((textBox.Text == "0") || operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "7";
            operationDo = true;
            */

        }

        private void button19_Click(object sender, EventArgs e)
        {
          /*  if ((textBox.Text == "0")||operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "8";
            operationDo = true;
            */

        }

        private void button18_Click(object sender, EventArgs e)
        {
          /*  if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "9";
            operationDo = true;
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  if ((textBox.Text == "0")|| operationDo)
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text = textBox.Text + "0";
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            /*  value = double.Parse(textBox.Text);
              textBox.Clear();
              textBox.Focus();
              operationExecute = "";
             count = "";
              labelCurrentOperation.Text = value.ToString() + "+";
              */
        }

        private void button9_Click(object sender, EventArgs e)
        {
           

            /* this.textBox.Text = "";
             input = input + "-";
             textBox.Clear();
             this.textBox.Text = this.textBox.Text + input;
             */
            //  textBox.Clear();
            /* value = double.Parse(textBox.Text);
             textBox.Clear();
             textBox.Focus();
             operationExecute = "";
           count = "";
             labelCurrentOperation.Text = value.ToString() + "-";
             */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
          /*  this.textBox.Text = "";
            input = input + "*";
            textBox.Clear();
            this.textBox.Text = this.textBox.Text + input;
            
            // textBox.Clear();
            value = double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            operationExecute = "";
            //count = "";
            labelCurrentOperation.Text = value.ToString() + "*";
*/
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
          /*  this.textBox.Text = "";
            input = input + "/";
            textBox.Clear();
            this.textBox.Text = this.textBox.Text + input;
            */
            
            //  textBox.Clear();
        /*    value = double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            operationExecute = "";
              // count = "";
            labelCurrentOperation.Text = value.ToString() + "/";
            */
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
          
          

            
           if (operationExecute == "+")
            {
                textBox_Output.Text = (result+double.Parse(textBox_Output.Text)).ToString();

            }
            else if (operationExecute == "-")
            {
               

                 textBox_Output.Text = (result - double.Parse(textBox_Output.Text)).ToString();

            }
            else if (operationExecute == "*")
            {
                

                 textBox_Output.Text = (result * double.Parse(textBox_Output.Text)).ToString();

            }
            else if (operationExecute == "/")
            {
              

                textBox_Output.Text = (result / double.Parse(textBox_Output.Text)).ToString();

            }
            


        }

        private void Click_Operator(object sender, EventArgs e)
        {
          Button btn = (Button)sender;
            operationExecute = btn.Text;
     
            result = double.Parse(textBox_Output.Text);
           labelCurrentOperation.Text = result + " " + operationExecute;
            
            operationDo= true;
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
          this.textBox_Output.Text=" ";
           result = 0;
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = "0";
        }
    }
}
