using System.Linq.Expressions;

namespace CalculatorTest
{
    public partial class Form_Calculator : Form
    {
        public Form_Calculator()
        {
            InitializeComponent();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region point "." button
        private void btn_p_Click(object sender, EventArgs e)
        {
            if(Output.Text=="")
            {
                Output.Text += "";
            }
            else if (!Output.Text.Contains(","))
            {
                Output.Text += ",";
            }


        }
        #endregion

        #region clear button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            lbl_result.Text= ""; 
        }
        #endregion


        #region arhitmetic operations buttons
        double result;
        private void button3_Click_1(object sender, EventArgs e)
        {
            try {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    if (operation == "+")
                    {
                        lbl_result.Text += Output.Text;
                        result = first + second;
                        Output.Text = result.ToString();

                    }
                    if (operation == "-")
                    {
                        lbl_result.Text += Output.Text;
                        result = first - second;
                        Output.Text = result.ToString();

                    }
                    if (operation == "*")
                    {
                        lbl_result.Text += Output.Text;
                        result = first * second;
                        Output.Text = result.ToString();

                    }
                    if (operation == "/")
                    {
                        if (second != 0)
                        {
                            lbl_result.Text += Output.Text;
                            result = first / second;
                            Output.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("0-a bolme yoxdur!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (operation == "percent")
                    {
                        lbl_result.Text += Output.Text;
                        result = first * second / 100;
                        Output.Text = result.ToString();
                    }
                }
               
            }
            catch
            {

            }
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {

        }
        #region backspace button
        private void button1_Click_3(object sender, EventArgs e)
        {
            if (Output.Text.Length > 0)
            {
                Output.Text= Output.Text.Remove(Output.Text.Length-1, 1);
            }
            else if (Output.Text.Length == 0)
            {
                Output.Text = "";
            }
        }
        #endregion

        #region numbers
        //number 1 button
        private void btn_n1_Click(object sender, EventArgs e)
        {
            if(Output.Text=="")
            {
                Output.Text = "1";
            }
            else
            {
                Output.Text += 1;
            }
        }
        //number 2 button
        private void btn_n2_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "2";
            }
            else
            {
                Output.Text += 2;
            }
        }
        //number 3 button
        private void btn_n3_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "3";
            }
            else
            {
                Output.Text += 3;
            }
        }
        //number 4 button
        private void btn_n4_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "4";
            }
            else
            {
                Output.Text += 4;
            }
        }
        //number 5 button
        private void btn_n5_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "5";
            }
            else
            {
                Output.Text += 5;
            }
        }
        //number 6 button
        private void btn_n6_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "6";
            }
            else
            {
                Output.Text += 6;
            }
        }
        //number 7 button
        private void btn_n7_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "7";
            }
            else
            {
                Output.Text += 7;
            }
        }
        //number 8 button
        private void btn_n8_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "8";
            }
            else
            {
                Output.Text += 8;
            }
        }
        //number 9 button
        private void btn_n9_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "9";
            }
            else
            {
                Output.Text += 9;
            }
        }
        //number zero button
        private void btn_z_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "0";
            }
            else
            {
                Output.Text += 0;
            }
        }
        #endregion

        #region sum operation button
        string operation;
        double first, second;
        private void btn_sum_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    first = Convert.ToDouble(Output.Text);
                    operation = "+";
                    lbl_result.Text = Output.Text + "+";
                    Output.Text = "";
                }
            }
            catch
            {

            }
        }
        #endregion

        #region minus button
        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    first = Convert.ToDouble(Output.Text);
                    operation = "-";
                    lbl_result.Text = Output.Text + "-";
                    Output.Text = "";
                }
            }
            catch
            {

            }
        }
        #endregion

        #region multiplay operation button
        private void btn_by_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    first = Convert.ToDouble(Output.Text);
                    operation = "*";
                    lbl_result.Text = Output.Text + "*";
                    Output.Text = "";
                }
            }
            catch
            {

            }
          
          
        }
        #endregion

        #region percent button
        private void btn_percent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    first = Convert.ToDouble(Output.Text);
                    operation = "percent";

                    lbl_result.Text += Output.Text + "%";
                    Output.Text = "";
                }
            }
            catch
            {

            }
        }
        #endregion

        #region power 2 "square" button
        private void btn_power2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = second + "^2";
                    result = Math.Pow(second, 2);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region power 3 button
        private void btn_power3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = second + "^3";
                    result = Math.Pow(second, 3);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region root operation button
        private void btn_root_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = second + " " + "root";
                    result = Math.Sqrt(second);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region tan button

        private void btn_tan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "tan" + second;
                    result = Math.Tan(second);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region cos button
        private void btn_cos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "cos" + second;
                    result = Math.Cos(second);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
            
        }
        #endregion

        #region sin button
        private void btn_sin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "sin" + second;
                    result = Math.Sin(second);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region log button
        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "log" + second;
                    result = Math.Log(second);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }

        }
        #endregion

        #region ln button
        private void btn_ln_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "ln" + second;
                    result = Math.Log10(second);
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region pi and e button
        //pi button
        private void btn_pi_Click(object sender, EventArgs e)
        {
            Output.Text = "3,14";
        }

        //e button
        private void btn_e_Click(object sender, EventArgs e)
        {
            Output.Text = "2,71";
        }
        #endregion

        #region 1 over button
        private void button_1over_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "1/" + second;
                    result = 1 / second;
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region mod button
        private void btn_mod_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    lbl_result.Text = "Mod" + second;
                    result = second % 10;
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region faktorial button

        int i, fakt = 1;
        private void btn_faktorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    second = Convert.ToDouble(Output.Text);
                    if (second > 0)
                    {
                        for (i = 1; i <= second; i++)
                        {
                            fakt = fakt * i;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu ededin faktoriali tapila bilmez!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lbl_result.Text = second + " " + "!";
                    result = fakt;
                    Output.Text = result.ToString();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region over button
        private void btn_over_Click(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Length > 0)
                {
                    first = Convert.ToDouble(Output.Text);
                    operation = "/";

                    lbl_result.Text = Output.Text + "/";
                    Output.Text = "";
                }
            }
            catch
            {

            }
        }
        #endregion

    }
}