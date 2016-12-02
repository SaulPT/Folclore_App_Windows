namespace App_Windows
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_noticias = new System.Windows.Forms.Button();
            this.label_conteudo = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.listBox_noticias = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(514, 26);
            this.button_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(235, 66);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(139, 26);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(350, 29);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(139, 63);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(350, 29);
            this.textBox_password.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_noticias);
            this.groupBox1.Controls.Add(this.label_conteudo);
            this.groupBox1.Controls.Add(this.label_data);
            this.groupBox1.Controls.Add(this.label_titulo);
            this.groupBox1.Controls.Add(this.listBox_noticias);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 482);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notícias";
            // 
            // button_noticias
            // 
            this.button_noticias.Enabled = false;
            this.button_noticias.Location = new System.Drawing.Point(21, 35);
            this.button_noticias.Name = "button_noticias";
            this.button_noticias.Size = new System.Drawing.Size(213, 45);
            this.button_noticias.TabIndex = 8;
            this.button_noticias.Text = "Mostrar";
            this.button_noticias.UseVisualStyleBackColor = true;
            this.button_noticias.Click += new System.EventHandler(this.button_noticias_Click);
            // 
            // label_conteudo
            // 
            this.label_conteudo.AutoSize = true;
            this.label_conteudo.Location = new System.Drawing.Point(262, 120);
            this.label_conteudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_conteudo.Name = "label_conteudo";
            this.label_conteudo.Size = new System.Drawing.Size(93, 24);
            this.label_conteudo.TabIndex = 6;
            this.label_conteudo.Text = "Conteúdo";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(263, 74);
            this.label_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(36, 18);
            this.label_data.TabIndex = 7;
            this.label_data.Text = "data";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(260, 42);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(92, 32);
            this.label_titulo.TabIndex = 6;
            this.label_titulo.Text = "Título";
            // 
            // listBox_noticias
            // 
            this.listBox_noticias.FormattingEnabled = true;
            this.listBox_noticias.ItemHeight = 24;
            this.listBox_noticias.Location = new System.Drawing.Point(21, 97);
            this.listBox_noticias.Name = "listBox_noticias";
            this.listBox_noticias.Size = new System.Drawing.Size(213, 364);
            this.listBox_noticias.TabIndex = 0;
            this.listBox_noticias.SelectedIndexChanged += new System.EventHandler(this.listBox_noticias_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_conteudo;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.ListBox listBox_noticias;
        private System.Windows.Forms.Button button_noticias;
    }
}

