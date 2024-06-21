namespace Calci
{
    public partial class Calci : Form
    {

        public Calci()
        {
            InitializeComponent();
           

        }
            string CalTotal;
            int num1;
            int num2;

            string option;
            int result;

            private void button2_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn2.Text;
            }

            private void button3_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn3.Text;
            }

            private void button16_Click(object sender, EventArgs e)
            {
                num2 = int.Parse(txtTotal.Text);

                if (option.Equals("+"))
                    result = num1 + num2;

                if (option.Equals("-"))
                    result = num1 - num2;

                if (option.Equals("*"))
                    result = num1 * num2;

                if (option.Equals("/"))
                    result = num1 / num2;

                txtTotal.Text = result + "";

            }

            private void button5_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn5.Text;
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void button7_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn7.Text;
            }

            private void button12_Click(object sender, EventArgs e)
            {
                option = "-";
                num1 = int.Parse(txtTotal.Text);

                txtTotal.Clear();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + button1.Text;
            }

            private void btn4_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn4.Text;
            }

            private void btn6_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn6.Text;
            }

            private void btn8_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn8.Text;
            }

            private void btn9_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn9.Text;
            }

            private void btn0_Click(object sender, EventArgs e)
            {
                txtTotal.Text = txtTotal.Text + btn0.Text;
            }

            private void button11_Click(object sender, EventArgs e)
            {
                option = "+";
                num1 = int.Parse(txtTotal.Text);

                //txtTotal.Clear();
            }

            private void button13_Click(object sender, EventArgs e)
            {
                option = "*";
                num1 = int.Parse(txtTotal.Text);

                txtTotal.Clear();
            }

            private void button14_Click(object sender, EventArgs e)
            {
                option = "/";
                num1 = int.Parse(txtTotal.Text);

                txtTotal.Clear();
            }
        /* private void Calci_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (char.IsDigit(e.KeyChar))
             {
                 txtTotal.Text += e.KeyChar.ToString();
             }
             else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
             {
                 option = e.KeyChar.ToString();
                 num1 = int.Parse(txtTotal.Text);
                 txtTotal.Clear();
             }
             else if (e.KeyChar == '=' || e.KeyChar == '\r') 
             {
                 num2 = int.Parse(txtTotal.Text);

                 if (option.Equals("+"))
                     result = num1 + num2;
                 else if (option.Equals("-"))
                     result = num1 - num2;
                 else if (option.Equals("*"))
                     result = num1 * num2;
                 else if (option.Equals("/"))
                     result = num1 / num2;

                 txtTotal.Text = result.ToString();
             }
             else if (e.KeyChar == '\b') 
             {
                 if (txtTotal.Text.Length > 0)
                 {
                     txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);
                 }
             }
         }*/
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
              
                case Keys.Add:

                    button11_Click(sender, e);
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    button16.PerformClick();
                    break;
                default:
                    break;
            }
        }



        private void button15_Click(object sender, EventArgs e)
            {
                txtTotal.Clear();
                result = (0);
                num1 = (0);
                num2 = (0);

            }
        }
    
}




