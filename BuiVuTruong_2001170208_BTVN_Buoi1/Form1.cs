﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiVuTruong_2001170208_BTVN_Buoi1
{
    public partial class Form1 : Form
    {
        private Button[,] banCo;
        private int size;

        public Form1()
        {
            InitializeComponent();

            size = 10;
            banCo = new Button[size, size];
            addControls();
        }

        private void addControls()
        {
            Button btn;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btn = createButton(j * 40, i * 40);
                    pnBanCo.Controls.Add(btn);
                    banCo[i, j] = btn;
                }
            }

            //them
            int a = 5;
            int b = 100 + a;
            MessageBox.Show("b: " + b);
        }

        private Button createButton(int x, int y)
        {
            Button btn = new Button();
            btn.Width = btn.Height = 40;
            btn.Location = new Point(x, y);
            btn.Click += new System.EventHandler(oCoClicked);

            return btn;
        }

        private void oCoClicked(object sen, EventArgs ev)
        {
            Button btn = (Button)sen;
            btn.BackColor = Color.LightBlue;
        }
    }
}
