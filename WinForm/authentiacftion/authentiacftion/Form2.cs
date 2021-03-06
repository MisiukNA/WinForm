﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
   

namespace authentiacftion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "                                                                               Registration";
            textBox1.Validating+= textBox1_Validating;


        }
        static public string str = "";      //Пароль первый



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Arya")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.Font = new Font("Arial", 12);
                
            }
         
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Arya";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font("Arial", 12);
            }
            //Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{3,9}$");


            //if (login_regex.Match(textBox1.Text).Success) // если совпадение удачно 
            //{
            //    MessageBox.Show("Login is correct");
            //}
            //else
            //{
            //    MessageBox.Show("Login is incorrect");
            //}


        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "arya_stark@mail.ru")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.Font = new Font("Arial", 12);

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "arya_stark@mail.ru";
                textBox2.ForeColor = Color.Gray;
                textBox2.Font = new Font("Arial", 12);
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "********")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.Font = new Font("Arial", 12);
            }
           
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "********";
                textBox3.ForeColor = Color.Gray;
                textBox3.Font = new Font("Arial", 12);
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "********")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                textBox4.Font = new Font("Arial", 12);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "********";
                textBox4.ForeColor = Color.Gray;
                textBox4.Font = new Font("Arial", 12);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Multiline = true;
           // textBox1.Height = 132;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");


            if (login_regex.Match(textBox1.Text).Success) // если совпадение удачно 
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox1, "From 3 to 9 characters");
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex login_regex = new Regex("^([a-zA-Z0-9._]+)@(([[0-9]{1,3}" +
                                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");


            if (login_regex.Match(textBox2.Text).Success) // если совпадение удачно 
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox2, "Incorrect email");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex login_regex = new Regex("^(?=.*?[A-ZА-Я])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");


            if (login_regex.Match(textBox3.Text).Success) // если совпадение удачно 
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox3, "Password length from 8 to 15 characters.\nThe password must contain the required\ncharacters one capital letter, one digit,\none special character.");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text!=textBox3.Text)
            {
                errorProvider1.SetError(textBox4, "Passwords do not match.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration completed successfully!!!");
            this.Close();
        }
    }
}




