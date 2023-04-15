using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        bool optDurum = false;
        double sonuc = 0;
        string optSt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if(txtSonuc.Text == "0" || optDurum )
            {
                txtSonuc.Clear();

            }

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }


        private void opt(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;


            lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch(optSt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "*":
                    txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString();
                    break;

            }


            if (sonuc == 0)
            {

                sonuc = double.Parse(0 + txtSonuc.Text);
                txtSonuc.Text = sonuc.ToString();
                optSt = " ";


            }
            else
            {

                sonuc = double.Parse(txtSonuc.Text);
                txtSonuc.Text = sonuc.ToString();
                optSt = yeniOpt;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = " ";
            optSt = " ";
            sonuc = 0;
            optDurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = " ";
            optDurum = true;

            switch (optSt)
            {
                case "+":
                    txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "*":
                    txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString();
                    break;
            }



            if (sonuc == 0 )
            {
                    sonuc = double.Parse(1+txtSonuc.Text);
                    txtSonuc.Text = sonuc.ToString();
                    optSt = "";

            }
            else
            {
                sonuc = double.Parse(txtSonuc.Text);
                txtSonuc.Text = sonuc.ToString();
                optSt = "";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
                txtSonuc.Text = "0";
            else if (optDurum)
                txtSonuc.Text = "0";

            if (!txtSonuc.Text.Contains(","))
                txtSonuc.Text += ",";

            optDurum = false;
        }

        private void txtSonuc_Click(object sender, EventArgs e)
        {

        }

        private void txtSonuc_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
