namespace PrtInsManagement
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblCode = new System.Windows.Forms.Label();
            this.pic重新給驗證碼 = new System.Windows.Forms.PictureBox();
            this.TxtBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_密碼 = new System.Windows.Forms.TextBox();
            this.txtbox_註冊時的帳號 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic重新給驗證碼)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblCode.Location = new System.Drawing.Point(171, 313);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(184, 19);
            this.LblCode.TabIndex = 19;
            this.LblCode.Text = "Press Refresh Button-->";
            // 
            // pic重新給驗證碼
            // 
            this.pic重新給驗證碼.Image = ((System.Drawing.Image)(resources.GetObject("pic重新給驗證碼.Image")));
            this.pic重新給驗證碼.Location = new System.Drawing.Point(361, 298);
            this.pic重新給驗證碼.Name = "pic重新給驗證碼";
            this.pic重新給驗證碼.Size = new System.Drawing.Size(53, 54);
            this.pic重新給驗證碼.TabIndex = 18;
            this.pic重新給驗證碼.TabStop = false;
            this.pic重新給驗證碼.Click += new System.EventHandler(this.pic重新給驗證碼_Click);
            // 
            // TxtBoxCode
            // 
            this.TxtBoxCode.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCode.Location = new System.Drawing.Point(102, 260);
            this.TxtBoxCode.Name = "TxtBoxCode";
            this.TxtBoxCode.Size = new System.Drawing.Size(246, 29);
            this.TxtBoxCode.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Verification Code";
            // 
            // txtbox_密碼
            // 
            this.txtbox_密碼.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_密碼.Location = new System.Drawing.Point(102, 201);
            this.txtbox_密碼.Name = "txtbox_密碼";
            this.txtbox_密碼.PasswordChar = '*';
            this.txtbox_密碼.Size = new System.Drawing.Size(246, 29);
            this.txtbox_密碼.TabIndex = 15;
            this.txtbox_密碼.Text = "0000";
            // 
            // txtbox_註冊時的帳號
            // 
            this.txtbox_註冊時的帳號.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_註冊時的帳號.Location = new System.Drawing.Point(102, 143);
            this.txtbox_註冊時的帳號.Name = "txtbox_註冊時的帳號";
            this.txtbox_註冊時的帳號.Size = new System.Drawing.Size(246, 29);
            this.txtbox_註冊時的帳號.TabIndex = 14;
            this.txtbox_註冊時的帳號.Text = "Ai@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Agent Username(Email)";
            // 
            // btn登入
            // 
            this.btn登入.Location = new System.Drawing.Point(242, 386);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(106, 52);
            this.btn登入.TabIndex = 11;
            this.btn登入.Text = "Login";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn取消
            // 
            this.btn取消.Location = new System.Drawing.Point(104, 386);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(112, 52);
            this.btn取消.TabIndex = 10;
            this.btn取消.Text = "Exit";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Refresh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(463, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Insurance Management System";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(560, 466);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.pic重新給驗證碼);
            this.Controls.Add(this.TxtBoxCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_密碼);
            this.Controls.Add(this.txtbox_註冊時的帳號);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.btn取消);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrnLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic重新給驗證碼)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.PictureBox pic重新給驗證碼;
        private System.Windows.Forms.TextBox TxtBoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_密碼;
        private System.Windows.Forms.TextBox txtbox_註冊時的帳號;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}