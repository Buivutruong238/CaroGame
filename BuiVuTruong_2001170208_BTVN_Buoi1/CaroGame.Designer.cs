namespace BuiVuTruong_2001170208_BTVN_Buoi1
{
    partial class CaroGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBanCo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapMT = new System.Windows.Forms.TextBox();
            this.btnTaoBC = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBanCo
            // 
            this.pnBanCo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBanCo.Location = new System.Drawing.Point(-1, 146);
            this.pnBanCo.Name = "pnBanCo";
            this.pnBanCo.Size = new System.Drawing.Size(863, 429);
            this.pnBanCo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTaoBC);
            this.panel2.Controls.Add(this.txtCapMT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 140);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấp ma trận: ";
            // 
            // txtCapMT
            // 
            this.txtCapMT.Location = new System.Drawing.Point(123, 49);
            this.txtCapMT.Name = "txtCapMT";
            this.txtCapMT.Size = new System.Drawing.Size(100, 22);
            this.txtCapMT.TabIndex = 1;
            this.txtCapMT.Text = "10";
            // 
            // btnTaoBC
            // 
            this.btnTaoBC.Location = new System.Drawing.Point(66, 86);
            this.btnTaoBC.Name = "btnTaoBC";
            this.btnTaoBC.Size = new System.Drawing.Size(106, 30);
            this.btnTaoBC.TabIndex = 2;
            this.btnTaoBC.Text = "Tạo bàn cờ";
            this.btnTaoBC.UseVisualStyleBackColor = true;
            this.btnTaoBC.Click += new System.EventHandler(this.btnTaoBC_Click);
            // 
            // CaroGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnBanCo);
            this.Name = "CaroGame";
            this.Text = "CaroGame";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBanCo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaoBC;
        private System.Windows.Forms.TextBox txtCapMT;
        private System.Windows.Forms.Label label1;
    }
}