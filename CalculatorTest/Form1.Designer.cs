namespace CalculatorTest
{
    partial class Form_Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calculator));
            this.lbl_result = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_p = new System.Windows.Forms.Button();
            this.btn_z = new System.Windows.Forms.Button();
            this.btn_n9 = new System.Windows.Forms.Button();
            this.btn_n8 = new System.Windows.Forms.Button();
            this.btn_n7 = new System.Windows.Forms.Button();
            this.btn_n6 = new System.Windows.Forms.Button();
            this.btn_n5 = new System.Windows.Forms.Button();
            this.btn_n4 = new System.Windows.Forms.Button();
            this.btn_n3 = new System.Windows.Forms.Button();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.btn_over = new System.Windows.Forms.Button();
            this.btn_by = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_ln = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.btn_faktorial = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_power3 = new System.Windows.Forms.Button();
            this.btn_power2 = new System.Windows.Forms.Button();
            this.btn_pi = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.button_1over = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(12, 9);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 15);
            this.lbl_result.TabIndex = 14;
            this.lbl_result.Click += new System.EventHandler(this.button4_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(9, 28);
            this.Output.Margin = new System.Windows.Forms.Padding(2);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(594, 62);
            this.Output.TabIndex = 1;
            this.Output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(9, 94);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(117, 48);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(261, 279);
            this.btn_sum.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(78, 38);
            this.btn_sum.TabIndex = 13;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_p
            // 
            this.btn_p.Location = new System.Drawing.Point(92, 279);
            this.btn_p.Margin = new System.Windows.Forms.Padding(2);
            this.btn_p.Name = "btn_p";
            this.btn_p.Size = new System.Drawing.Size(78, 38);
            this.btn_p.TabIndex = 12;
            this.btn_p.Text = ".";
            this.btn_p.UseVisualStyleBackColor = true;
            this.btn_p.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // btn_z
            // 
            this.btn_z.Location = new System.Drawing.Point(8, 279);
            this.btn_z.Margin = new System.Windows.Forms.Padding(2);
            this.btn_z.Name = "btn_z";
            this.btn_z.Size = new System.Drawing.Size(78, 38);
            this.btn_z.TabIndex = 11;
            this.btn_z.Text = "0";
            this.btn_z.UseVisualStyleBackColor = true;
            this.btn_z.Click += new System.EventHandler(this.btn_z_Click);
            // 
            // btn_n9
            // 
            this.btn_n9.Location = new System.Drawing.Point(176, 235);
            this.btn_n9.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n9.Name = "btn_n9";
            this.btn_n9.Size = new System.Drawing.Size(78, 38);
            this.btn_n9.TabIndex = 10;
            this.btn_n9.Text = "9";
            this.btn_n9.UseVisualStyleBackColor = true;
            this.btn_n9.Click += new System.EventHandler(this.btn_n9_Click);
            // 
            // btn_n8
            // 
            this.btn_n8.Location = new System.Drawing.Point(92, 235);
            this.btn_n8.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n8.Name = "btn_n8";
            this.btn_n8.Size = new System.Drawing.Size(78, 38);
            this.btn_n8.TabIndex = 9;
            this.btn_n8.Text = "8";
            this.btn_n8.UseVisualStyleBackColor = true;
            this.btn_n8.Click += new System.EventHandler(this.btn_n8_Click);
            // 
            // btn_n7
            // 
            this.btn_n7.Location = new System.Drawing.Point(8, 235);
            this.btn_n7.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n7.Name = "btn_n7";
            this.btn_n7.Size = new System.Drawing.Size(78, 38);
            this.btn_n7.TabIndex = 8;
            this.btn_n7.Text = "7";
            this.btn_n7.UseVisualStyleBackColor = true;
            this.btn_n7.Click += new System.EventHandler(this.btn_n7_Click);
            // 
            // btn_n6
            // 
            this.btn_n6.Location = new System.Drawing.Point(176, 191);
            this.btn_n6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n6.Name = "btn_n6";
            this.btn_n6.Size = new System.Drawing.Size(78, 38);
            this.btn_n6.TabIndex = 7;
            this.btn_n6.Text = "6";
            this.btn_n6.UseVisualStyleBackColor = true;
            this.btn_n6.Click += new System.EventHandler(this.btn_n6_Click);
            // 
            // btn_n5
            // 
            this.btn_n5.Location = new System.Drawing.Point(92, 191);
            this.btn_n5.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n5.Name = "btn_n5";
            this.btn_n5.Size = new System.Drawing.Size(78, 38);
            this.btn_n5.TabIndex = 6;
            this.btn_n5.Text = "5";
            this.btn_n5.UseVisualStyleBackColor = true;
            this.btn_n5.Click += new System.EventHandler(this.btn_n5_Click);
            // 
            // btn_n4
            // 
            this.btn_n4.Location = new System.Drawing.Point(8, 191);
            this.btn_n4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n4.Name = "btn_n4";
            this.btn_n4.Size = new System.Drawing.Size(78, 38);
            this.btn_n4.TabIndex = 5;
            this.btn_n4.Text = "4";
            this.btn_n4.UseVisualStyleBackColor = true;
            this.btn_n4.Click += new System.EventHandler(this.btn_n4_Click);
            // 
            // btn_n3
            // 
            this.btn_n3.Location = new System.Drawing.Point(176, 148);
            this.btn_n3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n3.Name = "btn_n3";
            this.btn_n3.Size = new System.Drawing.Size(78, 38);
            this.btn_n3.TabIndex = 4;
            this.btn_n3.Text = "3";
            this.btn_n3.UseVisualStyleBackColor = true;
            this.btn_n3.Click += new System.EventHandler(this.btn_n3_Click);
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(9, 148);
            this.btn_n1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(78, 38);
            this.btn_n1.TabIndex = 2;
            this.btn_n1.Text = "1";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // btn_n2
            // 
            this.btn_n2.Location = new System.Drawing.Point(92, 148);
            this.btn_n2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(78, 38);
            this.btn_n2.TabIndex = 3;
            this.btn_n2.Text = "2";
            this.btn_n2.UseVisualStyleBackColor = true;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // btn_over
            // 
            this.btn_over.Location = new System.Drawing.Point(261, 148);
            this.btn_over.Margin = new System.Windows.Forms.Padding(2);
            this.btn_over.Name = "btn_over";
            this.btn_over.Size = new System.Drawing.Size(78, 38);
            this.btn_over.TabIndex = 15;
            this.btn_over.Text = "/";
            this.btn_over.UseVisualStyleBackColor = true;
            this.btn_over.Click += new System.EventHandler(this.btn_over_Click);
            // 
            // btn_by
            // 
            this.btn_by.Location = new System.Drawing.Point(261, 191);
            this.btn_by.Margin = new System.Windows.Forms.Padding(2);
            this.btn_by.Name = "btn_by";
            this.btn_by.Size = new System.Drawing.Size(78, 38);
            this.btn_by.TabIndex = 16;
            this.btn_by.Text = "*";
            this.btn_by.UseVisualStyleBackColor = true;
            this.btn_by.Click += new System.EventHandler(this.btn_by_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(177, 279);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(78, 38);
            this.btn_equal.TabIndex = 18;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(261, 235);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(78, 38);
            this.btn_minus.TabIndex = 17;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(132, 94);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 48);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "⬅";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btn_ln
            // 
            this.btn_ln.Location = new System.Drawing.Point(357, 94);
            this.btn_ln.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ln.Name = "btn_ln";
            this.btn_ln.Size = new System.Drawing.Size(78, 48);
            this.btn_ln.TabIndex = 25;
            this.btn_ln.Text = "ln";
            this.btn_ln.UseVisualStyleBackColor = true;
            this.btn_ln.Click += new System.EventHandler(this.btn_ln_Click);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(357, 148);
            this.btn_log.Margin = new System.Windows.Forms.Padding(2);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(78, 38);
            this.btn_log.TabIndex = 22;
            this.btn_log.Text = "log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_sin
            // 
            this.btn_sin.Location = new System.Drawing.Point(357, 191);
            this.btn_sin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(78, 38);
            this.btn_sin.TabIndex = 23;
            this.btn_sin.Text = "sin";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
            // 
            // btn_cos
            // 
            this.btn_cos.Location = new System.Drawing.Point(357, 235);
            this.btn_cos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(78, 38);
            this.btn_cos.TabIndex = 24;
            this.btn_cos.Text = "cos";
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
            // 
            // btn_tan
            // 
            this.btn_tan.Location = new System.Drawing.Point(357, 279);
            this.btn_tan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(78, 38);
            this.btn_tan.TabIndex = 21;
            this.btn_tan.Text = "tan";
            this.btn_tan.UseVisualStyleBackColor = true;
            this.btn_tan.Click += new System.EventHandler(this.btn_tan_Click);
            // 
            // btn_faktorial
            // 
            this.btn_faktorial.Location = new System.Drawing.Point(441, 94);
            this.btn_faktorial.Margin = new System.Windows.Forms.Padding(2);
            this.btn_faktorial.Name = "btn_faktorial";
            this.btn_faktorial.Size = new System.Drawing.Size(78, 48);
            this.btn_faktorial.TabIndex = 30;
            this.btn_faktorial.Text = "n!";
            this.btn_faktorial.UseVisualStyleBackColor = true;
            this.btn_faktorial.Click += new System.EventHandler(this.btn_faktorial_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.Location = new System.Drawing.Point(441, 148);
            this.btn_percent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(78, 38);
            this.btn_percent.TabIndex = 27;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            this.btn_percent.Click += new System.EventHandler(this.btn_percent_Click);
            // 
            // btn_root
            // 
            this.btn_root.Location = new System.Drawing.Point(441, 191);
            this.btn_root.Margin = new System.Windows.Forms.Padding(2);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(78, 38);
            this.btn_root.TabIndex = 28;
            this.btn_root.Text = "√";
            this.btn_root.UseVisualStyleBackColor = true;
            this.btn_root.Click += new System.EventHandler(this.btn_root_Click);
            // 
            // btn_power3
            // 
            this.btn_power3.Location = new System.Drawing.Point(441, 235);
            this.btn_power3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_power3.Name = "btn_power3";
            this.btn_power3.Size = new System.Drawing.Size(78, 38);
            this.btn_power3.TabIndex = 29;
            this.btn_power3.Text = "x^3";
            this.btn_power3.UseVisualStyleBackColor = true;
            this.btn_power3.Click += new System.EventHandler(this.btn_power3_Click);
            // 
            // btn_power2
            // 
            this.btn_power2.Location = new System.Drawing.Point(441, 279);
            this.btn_power2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_power2.Name = "btn_power2";
            this.btn_power2.Size = new System.Drawing.Size(78, 38);
            this.btn_power2.TabIndex = 26;
            this.btn_power2.Text = "x^2";
            this.btn_power2.UseVisualStyleBackColor = true;
            this.btn_power2.Click += new System.EventHandler(this.btn_power2_Click);
            // 
            // btn_pi
            // 
            this.btn_pi.Location = new System.Drawing.Point(525, 94);
            this.btn_pi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pi.Name = "btn_pi";
            this.btn_pi.Size = new System.Drawing.Size(78, 48);
            this.btn_pi.TabIndex = 35;
            this.btn_pi.Text = "π";
            this.btn_pi.UseVisualStyleBackColor = true;
            this.btn_pi.Click += new System.EventHandler(this.btn_pi_Click);
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(525, 148);
            this.btn_e.Margin = new System.Windows.Forms.Padding(2);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(78, 38);
            this.btn_e.TabIndex = 32;
            this.btn_e.Text = "e";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(525, 191);
            this.btn_mod.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(78, 126);
            this.btn_mod.TabIndex = 33;
            this.btn_mod.Text = "Mod";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // button_1over
            // 
            this.button_1over.Location = new System.Drawing.Point(260, 94);
            this.button_1over.Margin = new System.Windows.Forms.Padding(2);
            this.button_1over.Name = "button_1over";
            this.button_1over.Size = new System.Drawing.Size(78, 48);
            this.button_1over.TabIndex = 34;
            this.button_1over.Text = "1/x";
            this.button_1over.UseVisualStyleBackColor = true;
            this.button_1over.Click += new System.EventHandler(this.button_1over_Click);
            // 
            // Form_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 331);
            this.Controls.Add(this.btn_pi);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.button_1over);
            this.Controls.Add(this.btn_faktorial);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_root);
            this.Controls.Add(this.btn_power3);
            this.Controls.Add(this.btn_power2);
            this.Controls.Add(this.btn_ln);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_over);
            this.Controls.Add(this.btn_by);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.btn_n3);
            this.Controls.Add(this.btn_n4);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_n5);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.btn_n6);
            this.Controls.Add(this.btn_n7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_n8);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_n9);
            this.Controls.Add(this.btn_p);
            this.Controls.Add(this.btn_z);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_result;
        private TextBox Output;
        private Button btn_clear;
        private Button btn_sum;
        private Button btn_p;
        private Button btn_z;
        private Button btn_n9;
        private Button btn_n8;
        private Button btn_n7;
        private Button btn_n6;
        private Button btn_n5;
        private Button btn_n4;
        private Button btn_n3;
        private Button btn_n1;
        private Button btn_n2;
        private Button btn_over;
        private Button btn_by;
        private Button btn_equal;
        private Button btn_minus;
        private Button btn_back;
        private Button btn_ln;
        private Button btn_log;
        private Button btn_sin;
        private Button btn_cos;
        private Button btn_tan;
        private Button btn_faktorial;
        private Button btn_percent;
        private Button btn_root;
        private Button btn_power3;
        private Button btn_power2;
        private Button btn_pi;
        private Button btn_e;
        private Button btn_mod;
        private Button button_1over;
    }
}