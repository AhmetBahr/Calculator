namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.ForeColor = System.Drawing.Color.Gray;
            this.lbSonuc.Location = new System.Drawing.Point(24, 108);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 34);
            this.lbSonuc.TabIndex = 0;
            this.lbSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSonuc.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(5, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(91, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(177, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(263, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.opt);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(91, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(177, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 51);
            this.button6.TabIndex = 11;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(263, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 51);
            this.button7.TabIndex = 10;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.opt);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(177, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 51);
            this.button8.TabIndex = 9;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(91, 341);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 51);
            this.button9.TabIndex = 8;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(5, 341);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 51);
            this.button10.TabIndex = 7;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(263, 392);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 51);
            this.button12.TabIndex = 15;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.opt);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(177, 392);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 51);
            this.button13.TabIndex = 14;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(91, 392);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 51);
            this.button14.TabIndex = 13;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(5, 392);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 51);
            this.button15.TabIndex = 12;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Violet;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(177, 443);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 51);
            this.button16.TabIndex = 21;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(263, 443);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 51);
            this.button17.TabIndex = 20;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.opt);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(91, 443);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 51);
            this.button18.TabIndex = 19;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(5, 443);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(80, 51);
            this.button20.TabIndex = 17;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.RakamOlay);
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.Color.Silver;
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(24, 176);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(313, 45);
            this.txtSonuc.TabIndex = 23;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 502);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}

