using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuiVuTruong_2001170208_BTVN_Buoi1
{
    public partial class CaroGame : Form
    {
        private int capmt;

        public CaroGame()
        {
            InitializeComponent();
            capmt = int.Parse(txtCapMT.Text);
            addControls(capmt);
        }
        
        private void addControls(int size)
        {
            Button btn;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    btn = createButton(j * 40, i * 40);
                    pnBanCo.Controls.Add(btn);
                }
            }
        }

        private Button createButton(int x, int y)
        {
            Button btn = new Button();
            btn.Width = btn.Height = 40;
            btn.Location = new Point(x, y);
            return btn;
        }

        private void btnTaoBC_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtCapMT.Text);
            if (size <= 50)
            {
                pnBanCo.Controls.Clear();
                addControls(size);
            }
            else
            {
                MessageBox.Show(this, "Cấp ma trận phải <= 50");
            }
        }
    }
}
