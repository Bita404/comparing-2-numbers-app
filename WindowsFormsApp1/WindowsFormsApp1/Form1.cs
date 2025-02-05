﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button_compare.Enabled= true ;
            else
                button_compare.Enabled = false ;
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                button_compare.Enabled = true;
            else
                button_compare.Enabled = false;
        }
    

        private void button_compare_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
            { label1.Text = " > "; }
            if (Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text))
            { label1.Text = " < "; }
            if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox2.Text))
            { label1.Text = " = "; }
            { label2.Text = ""; }
            { label3.Text = ""; } 
          
        }
        private void button_sort_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text))
            { label1.Text = "-"; }
            { label2.Text = "min"; }
            { label3.Text = "max"; }
            if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
            {
                String a, b;
                a = textBox1.Text;
                b = textBox2.Text;

                textBox1.Text = b;
                textBox2.Text = a;
            }
            { label1.Text = "-"; }
            { label2.Text = "min"; }
            { label3.Text = "max"; }
            if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox2.Text))
            {
                { label1.Text = "-"; }
                { label2.Text = ""; }
                { label3.Text = ""; }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_compare_MouseEnter(object sender, EventArgs e)
        {
            button_compare.ForeColor = Color.CornflowerBlue ;
        }

        private void button_compare_MouseLeave(object sender, EventArgs e)
        {
            button_compare.ForeColor = Color.DarkBlue;

        }

        private void button_sort_MouseEnter(object sender, EventArgs e)
        {
            button_sort.ForeColor = Color.HotPink;
        
        }

        private void button_sort_MouseLeave(object sender, EventArgs e)
        {
            button_sort.ForeColor = Color.DarkViolet;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button_delete_MouseEnter(object sender, EventArgs e)
        {
            button_delete.ForeColor = Color.Red;
        }

        private void button_delete_MouseLeave(object sender, EventArgs e)
        {
            button_delete.ForeColor = Color.DarkRed;
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            label4.Text = "programmed by s9919314 - bita saeed";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button_info_MouseEnter(object sender, EventArgs e)
        {
            button_info.ForeColor = Color.DeepPink;
        }

        private void button_info_MouseLeave(object sender, EventArgs e)
        {
            button_info.ForeColor = Color.DarkMagenta;
        }
    }
}
