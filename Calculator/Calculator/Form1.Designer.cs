namespace Calculator
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.KQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cong_Click = new System.Windows.Forms.Button();
            this.btn_Tru_Click = new System.Windows.Forms.Button();
            this.btn_Chia_Click = new System.Windows.Forms.Button();
            this.btn_Nhan_Click = new System.Windows.Forms.Button();
            this.btPower = new System.Windows.Forms.Button();
            this.btBrowser = new System.Windows.Forms.Button();
            this.inputURL = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.btURL = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(299, 111);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 22);
            this.txt_1.TabIndex = 1;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(299, 139);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 22);
            this.txt_2.TabIndex = 3;
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(299, 167);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(100, 22);
            this.txt_kq.TabIndex = 5;
            // 
            // KQ
            // 
            this.KQ.AutoSize = true;
            this.KQ.Location = new System.Drawing.Point(235, 170);
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(25, 16);
            this.KQ.TabIndex = 4;
            this.KQ.Text = "KQ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số 2";
            // 
            // btn_Cong_Click
            // 
            this.btn_Cong_Click.Location = new System.Drawing.Point(141, 215);
            this.btn_Cong_Click.Name = "btn_Cong_Click";
            this.btn_Cong_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong_Click.TabIndex = 7;
            this.btn_Cong_Click.Text = "Cộng";
            this.btn_Cong_Click.UseVisualStyleBackColor = true;
            this.btn_Cong_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Tru_Click
            // 
            this.btn_Tru_Click.Location = new System.Drawing.Point(238, 215);
            this.btn_Tru_Click.Name = "btn_Tru_Click";
            this.btn_Tru_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Tru_Click.TabIndex = 8;
            this.btn_Tru_Click.Text = "Trừ";
            this.btn_Tru_Click.UseVisualStyleBackColor = true;
            // 
            // btn_Chia_Click
            // 
            this.btn_Chia_Click.Location = new System.Drawing.Point(440, 215);
            this.btn_Chia_Click.Name = "btn_Chia_Click";
            this.btn_Chia_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Chia_Click.TabIndex = 10;
            this.btn_Chia_Click.Text = "Chia";
            this.btn_Chia_Click.UseVisualStyleBackColor = true;
            // 
            // btn_Nhan_Click
            // 
            this.btn_Nhan_Click.Location = new System.Drawing.Point(343, 215);
            this.btn_Nhan_Click.Name = "btn_Nhan_Click";
            this.btn_Nhan_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhan_Click.TabIndex = 9;
            this.btn_Nhan_Click.Text = "Nhân";
            this.btn_Nhan_Click.UseVisualStyleBackColor = true;
            // 
            // btPower
            // 
            this.btPower.Location = new System.Drawing.Point(238, 265);
            this.btPower.Name = "btPower";
            this.btPower.Size = new System.Drawing.Size(75, 23);
            this.btPower.TabIndex = 11;
            this.btPower.Text = "Power";
            this.btPower.UseVisualStyleBackColor = true;
            this.btPower.Click += new System.EventHandler(this.btPower_Click);
            // 
            // btBrowser
            // 
            this.btBrowser.Location = new System.Drawing.Point(343, 265);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(172, 23);
            this.btBrowser.TabIndex = 12;
            this.btBrowser.Text = "Open Browser";
            this.btBrowser.UseVisualStyleBackColor = true;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // inputURL
            // 
            this.inputURL.AutoSize = true;
            this.inputURL.Location = new System.Drawing.Point(53, 316);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(68, 16);
            this.inputURL.TabIndex = 13;
            this.inputURL.Text = "Input URL:";
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(143, 313);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(618, 22);
            this.txt_URL.TabIndex = 14;
            // 
            // btURL
            // 
            this.btURL.Location = new System.Drawing.Point(238, 341);
            this.btURL.Name = "btURL";
            this.btURL.Size = new System.Drawing.Size(172, 23);
            this.btURL.TabIndex = 15;
            this.btURL.Text = "Open URL";
            this.btURL.UseVisualStyleBackColor = true;
            this.btURL.Click += new System.EventHandler(this.btURL_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(117, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(643, 22);
            this.txtTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Title 09";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(237, 438);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(172, 23);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(166, 413);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(401, 22);
            this.txt_keyword.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search Keyword:";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(237, 477);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(172, 38);
            this.btLogin.TabIndex = 21;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 527);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txt_keyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btURL);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.btBrowser);
            this.Controls.Add(this.btPower);
            this.Controls.Add(this.btn_Chia_Click);
            this.Controls.Add(this.btn_Nhan_Click);
            this.Controls.Add(this.btn_Tru_Click);
            this.Controls.Add(this.btn_Cong_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Label KQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cong_Click;
        private System.Windows.Forms.Button btn_Tru_Click;
        private System.Windows.Forms.Button btn_Chia_Click;
        private System.Windows.Forms.Button btn_Nhan_Click;
        private System.Windows.Forms.Button btPower;
        private System.Windows.Forms.Button btBrowser;
        private System.Windows.Forms.Label inputURL;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button btURL;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLogin;
    }
}

