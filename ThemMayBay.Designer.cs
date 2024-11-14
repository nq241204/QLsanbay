namespace QLSanbay
{
    partial class ThemMayBay
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMayBay = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.Label();
            this.txtSoGioBay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm máy bay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Máy Bay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenMayBay
            // 
            this.txtTenMayBay.Location = new System.Drawing.Point(207, 49);
            this.txtTenMayBay.Name = "txtTenMayBay";
            this.txtTenMayBay.Size = new System.Drawing.Size(287, 20);
            this.txtTenMayBay.TabIndex = 2;
            // 
            // txtNamSX
            // 
            this.txtNamSX.AutoSize = true;
            this.txtNamSX.Location = new System.Drawing.Point(122, 88);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(72, 13);
            this.txtNamSX.TabIndex = 3;
            this.txtNamSX.Text = "Năm sản xuất";
            // 
            // txtSoGioBay
            // 
            this.txtSoGioBay.AutoSize = true;
            this.txtSoGioBay.Location = new System.Drawing.Point(122, 124);
            this.txtSoGioBay.Name = "txtSoGioBay";
            this.txtSoGioBay.Size = new System.Drawing.Size(57, 13);
            this.txtSoGioBay.TabIndex = 4;
            this.txtSoGioBay.Text = "Số giờ bay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 6;
            // 
            // ThemMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSoGioBay);
            this.Controls.Add(this.txtNamSX);
            this.Controls.Add(this.txtTenMayBay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ThemMayBay";
            this.Text = "ThemMayBay";
            this.Load += new System.EventHandler(this.ThemMayBay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenMayBay;
        private System.Windows.Forms.Label txtNamSX;
        private System.Windows.Forms.Label txtSoGioBay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}