
namespace QLBH
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTDN = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // lbTDN
            // 
            this.lbTDN.AutoSize = true;
            this.lbTDN.Location = new System.Drawing.Point(46, 104);
            this.lbTDN.Name = "lbTDN";
            this.lbTDN.Size = new System.Drawing.Size(108, 15);
            this.lbTDN.TabIndex = 1;
            this.lbTDN.Text = "TÊN ĐĂNG NHẬP";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(64, 192);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(77, 15);
            this.lbMK.TabIndex = 2;
            this.lbMK.Text = "MẬT KHẨU";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(101, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 35);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(257, 256);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(82, 35);
            this.btnEXIT.TabIndex = 4;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(211, 104);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(163, 22);
            this.txtTDN.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(211, 185);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(163, 22);
            this.txtMK.TabIndex = 6;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(198, 224);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(122, 19);
            this.chkShow.TabIndex = 7;
            this.chkShow.Text = "Hiển thị mật khẩu ";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 345);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTDN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Đăng nhập ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTDN;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.CheckBox chkShow;
    }
}

