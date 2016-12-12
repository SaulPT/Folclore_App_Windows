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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_noticias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_eventos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_utilizador = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_area_pessoal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_terminar_sessao = new System.Windows.Forms.ToolStripMenuItem();
            this.label_conteudo = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.listBox_noticias = new System.Windows.Forms.ListBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_refresh,
            this.menu_menu,
            this.menu_utilizador});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(768, 33);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // menu_refresh
            // 
            this.menu_refresh.Image = global::App_Windows.Properties.Resources._5651_200;
            this.menu_refresh.Name = "menu_refresh";
            this.menu_refresh.Size = new System.Drawing.Size(34, 29);
            this.menu_refresh.Click += new System.EventHandler(this.menu_refresh_Click);
            // 
            // menu_menu
            // 
            this.menu_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_noticias,
            this.menu_eventos});
            this.menu_menu.Name = "menu_menu";
            this.menu_menu.Size = new System.Drawing.Size(73, 29);
            this.menu_menu.Text = "Menu";
            // 
            // menu_noticias
            // 
            this.menu_noticias.Name = "menu_noticias";
            this.menu_noticias.Size = new System.Drawing.Size(162, 30);
            this.menu_noticias.Text = "Notícias";
            // 
            // menu_eventos
            // 
            this.menu_eventos.Name = "menu_eventos";
            this.menu_eventos.Size = new System.Drawing.Size(162, 30);
            this.menu_eventos.Text = "Eventos";
            // 
            // menu_utilizador
            // 
            this.menu_utilizador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_area_pessoal,
            this.menu_terminar_sessao});
            this.menu_utilizador.Name = "menu_utilizador";
            this.menu_utilizador.Size = new System.Drawing.Size(106, 29);
            this.menu_utilizador.Text = "Utilizador";
            // 
            // menu_area_pessoal
            // 
            this.menu_area_pessoal.Name = "menu_area_pessoal";
            this.menu_area_pessoal.Size = new System.Drawing.Size(230, 30);
            this.menu_area_pessoal.Text = "Área Pessoal";
            this.menu_area_pessoal.Click += new System.EventHandler(this.menu_area_pessoal_Click);
            // 
            // menu_terminar_sessao
            // 
            this.menu_terminar_sessao.Name = "menu_terminar_sessao";
            this.menu_terminar_sessao.Size = new System.Drawing.Size(230, 30);
            this.menu_terminar_sessao.Text = "Terminar Sessão";
            this.menu_terminar_sessao.Visible = false;
            this.menu_terminar_sessao.Click += new System.EventHandler(this.menu_terminar_sessao_Click);
            // 
            // label_conteudo
            // 
            this.label_conteudo.AutoSize = true;
            this.label_conteudo.Location = new System.Drawing.Point(271, 139);
            this.label_conteudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_conteudo.Name = "label_conteudo";
            this.label_conteudo.Size = new System.Drawing.Size(93, 24);
            this.label_conteudo.TabIndex = 12;
            this.label_conteudo.Text = "Conteúdo";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(272, 93);
            this.label_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(36, 18);
            this.label_data.TabIndex = 14;
            this.label_data.Text = "data";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(269, 61);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(92, 32);
            this.label_titulo.TabIndex = 13;
            this.label_titulo.Text = "Título";
            // 
            // listBox_noticias
            // 
            this.listBox_noticias.FormattingEnabled = true;
            this.listBox_noticias.ItemHeight = 24;
            this.listBox_noticias.Location = new System.Drawing.Point(30, 57);
            this.listBox_noticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_noticias.Name = "listBox_noticias";
            this.listBox_noticias.Size = new System.Drawing.Size(213, 436);
            this.listBox_noticias.TabIndex = 11;
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 523);
            this.Controls.Add(this.label_conteudo);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.listBox_noticias);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_home";
            this.Text = "Folclore Online - Noticias";
            this.Shown += new System.EventHandler(this.Form_home_Shown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_utilizador;
        private System.Windows.Forms.ToolStripMenuItem menu_refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_noticias;
        private System.Windows.Forms.ToolStripMenuItem menu_eventos;
        private System.Windows.Forms.ToolStripMenuItem menu_area_pessoal;
        public System.Windows.Forms.ToolStripMenuItem menu_terminar_sessao;
        private System.Windows.Forms.Label label_conteudo;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.ListBox listBox_noticias;
    }
}

