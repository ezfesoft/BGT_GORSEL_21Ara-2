﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_GORSEL_21Ara_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Haftanın kaçıncı günü?
            // DateTime.Now.DayOfWeek
            int gun;
            gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            
            switch (gun)
            {
                case 0:
                    MessageBox.Show("Pazar");
                    break;
                case 1:
                    MessageBox.Show("Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Salı");
                    break;
                case 3:
                    MessageBox.Show("Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Cuma");
                    break;
                case 6:
                    MessageBox.Show("Cumartesi");
                    break;
                default:
                    MessageBox.Show("HATA");
                    break;
            }
        }
    }
}
