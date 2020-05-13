using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuiVuTruong_2001170208_BTVN_Buoi1
{
    public partial class TrucXanhGame : Form
    {
        private int size;

        public TrucXanhGame()
        {
            InitializeComponent();
            size = (int.Parse(txtSoCap.Text))*2;
            addControls(size);
        }

        private void addControls(int size)
        {     
            Button btn;
            int x = timx(size);
            int y = size / x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    btn = createButton(j * 50, i * 50);
                    panel2.Controls.Add(btn);
                }
            }
        }

        private Button createButton(int x, int y)
        {
            Button btn = new Button();
            btn.Width = btn.Height = 50;
            btn.Text = "Hihi";
            btn.Location = new Point(x, y);
            return btn;
        }
        private int timx(int sopt)
        {
            int max = 1;
            for (int i = 1; i <= Math.Sqrt(sopt); i++)
            {
                for (int j = sopt-1; j >= Math.Sqrt(sopt); j--)
                {
                    if(i * j == sopt)
                    {
                        if(i > max)
                        {
                            max = i;
                        }
                    }
                }
            }
            return max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int socap = (int.Parse(txtSoCap.Text)) * 2;
            panel2.Controls.Clear();
            addControls(socap);
        }
    }
}
