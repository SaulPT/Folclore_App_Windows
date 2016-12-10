namespace App_Windows
{
    partial class Form_home
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
            this.groupBox_notcias = new System.Windows.Forms.GroupBox();
            this.label_conteudo = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.listBox_noticias = new System.Windows.Forms.ListBox();
            this.label_username = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.Notícias = new System.Windows.Forms.MenuStrip();
            this.menu_area_pessoal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_notcias.SuspendLayout();
            this.Notícias.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_notcias
            // 
            this.groupBox_notcias.Controls.Add(this.label_conteudo);
            this.groupBox_notcias.Controls.Add(this.label_data);
            this.groupBox_notcias.Controls.Add(this.label_titulo);
            this.groupBox_notcias.Controls.Add(this.listBox_noticias);
            this.groupBox_notcias.Location = new System.Drawing.Point(14, 115);
            this.groupBox_notcias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_notcias.Name = "groupBox_notcias";
            this.groupBox_notcias.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_notcias.Size = new System.Drawing.Size(737, 493);
            this.groupBox_notcias.TabIndex = 5;
            this.groupBox_notcias.TabStop = false;
            this.groupBox_notcias.Text = "Notícias";
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
            this.listBox_noticias.Location = new System.Drawing.Point(21, 38);
            this.listBox_noticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_noticias.Name = "listBox_noticias";
            this.listBox_noticias.Size = new System.Drawing.Size(213, 436);
            this.listBox_noticias.TabIndex = 0;
            this.listBox_noticias.SelectedIndexChanged += new System.EventHandler(this.listBox_noticias_SelectedIndexChanged);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(28, 52);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(213, 44);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "Utilizador: ";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(538, 52);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(213, 42);
            this.button_login.TabIndex = 9;
            this.button_login.TabStop = false;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Notícias
            // 
            this.Notícias.Font = new System.Drawing.Font("Segoe UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notícias.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.Notícias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_refresh,
            this.menu_area_pessoal});
            this.Notícias.Location = new System.Drawing.Point(0, 0);
            this.Notícias.Name = "Notícias";
            this.Notícias.Size = new System.Drawing.Size(768, 33);
            this.Notícias.TabIndex = 10;
            this.Notícias.Text = "menuStrip1";
            // 
            // menu_area_pessoal
            // 
            this.menu_area_pessoal.Enabled = false;
            this.menu_area_pessoal.Name = "menu_area_pessoal";
            this.menu_area_pessoal.Size = new System.Drawing.Size(130, 29);
            this.menu_area_pessoal.Text = "Área Pessoal";
            this.menu_area_pessoal.Click += new System.EventHandler(this.menu_area_pessoal_Click);
            // 
            // menu_refresh
            // 
            this.menu_refresh.Image = global::App_Windows.Properties.Resources._5651_200;
            this.menu_refresh.Name = "menu_refresh";
            this.menu_refresh.Size = new System.Drawing.Size(34, 29);
            this.menu_refresh.Click += new System.EventHandler(this.menu_refresh_Click);
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 626);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.groupBox_notcias);
            this.Controls.Add(this.Notícias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.Notícias;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_home";
            this.Text = "Home";
            this.Shown += new System.EventHandler(this.Form_home_Shown);
            this.groupBox_notcias.ResumeLayout(false);
            this.groupBox_notcias.PerformLayout();
            this.Notícias.ResumeLayout(false);
            this.Notícias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_notcias;
        private System.Windows.Forms.Label label_conteudo;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.ListBox listBox_noticias;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.MenuStrip Notícias;
        private System.Windows.Forms.ToolStripMenuItem menu_area_pessoal;
        private System.Windows.Forms.ToolStripMenuItem menu_refresh;
    }
}

