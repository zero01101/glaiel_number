﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace glaiel_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number = 0;
        double numberGoUp = 0.1;
        double numberGoUpCost = 10;
        bool go = false;
        Stopwatch thewholeshebang = new Stopwatch();
        Stopwatch instant = new Stopwatch();
        int buyins = 0;        

        private void Form1_Load(object sender, EventArgs e)
        {            
            lblNumber.Text = number.ToString();
            lblNumberGoUp.Text = numberGoUp.ToString() + "x";
            lblThisMany.Text = numberGoUpCost.ToString();
            this.Text = "the more you wait the more times you can click";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!(go))
            {
                zynga.Enabled = false;
                number = 0;
                numberGoUp = 0.1;
                numberGoUpCost = 10;
                go = true;
                btnGo.Text = "stop";
                thewholeshebang.Start();
                instant.Start();
                timer1.Start();
            }
            else if (go)
            {
                buyins = 0;
                zynga.Enabled = true;
                go = false;
                btnGo.Text = "go";
                thewholeshebang.Stop();
                instant.Stop();
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInstant.Text = instant.ElapsedMilliseconds.ToString();
            lblShebang.Text = thewholeshebang.ElapsedMilliseconds.ToString();
            number += 1.0 * numberGoUp;            
            lblNumber.Text = Math.Floor(number).ToString();
            lblThisMany.Text = Math.Floor(numberGoUpCost).ToString();
            string ngo = numberGoUp.ToString();
            if (ngo.Length >= 6)
            {
                ngo = ngo.Substring(0, 5);
            }
            lblNumberGoUp.Text = ngo + "x";
            if (number > numberGoUpCost)
            {
                btnNumberGoUp.Enabled = true;
            }
            else
            {
                btnNumberGoUp.Enabled = false;
            }
        }

        private void btnNumberGoUp_Click(object sender, EventArgs e)
        {
            buyins++;
            instant.Stop();
            instant.Reset();
            number -= Math.Floor(numberGoUpCost);
            numberGoUp += Math.Sqrt(numberGoUp * 2) / 9;
            numberGoUpCost += Math.Sqrt(numberGoUpCost * 0.4) * 4.75;
            if (zynga.Checked) numberGoUpCost += Math.Sqrt(buyins);
            btnNumberGoUp.Enabled = false;
            instant.Start();
        }
    }
}
