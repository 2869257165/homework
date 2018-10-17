﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            string s = textBox1.Text;
            double a = Double.Parse(s);
            per1 = a;
            s = textBox2.Text;
             a = Double.Parse(s);
            per2 = a;
            s = textBox3.Text;
            a = Double.Parse(s);
            th1 = a * Math.PI / 180;
            s = textBox4.Text;
            a = Double.Parse(s);
            th2= a * Math.PI / 180;
            drawCayleyTree(5, 200, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1 ;
        double th2 ;
        double per1 ;
        double per2 ;       
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0,x1,y1);           
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}