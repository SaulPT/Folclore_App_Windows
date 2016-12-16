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
            this.menu_utilizador = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_area_pessoal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_terminar_sessao = new System.Windows.Forms.ToolStripMenuItem();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_noticias = new System.Windows.Forms.TabPage();
            this.listBox_noticias = new System.Windows.Forms.ListBox();
            this.label_noticia_conteudo = new System.Windows.Forms.Label();
            this.label_noticia_data = new System.Windows.Forms.Label();
            this.label_noticia_titulo = new System.Windows.Forms.Label();
            this.tab_eventos = new System.Windows.Forms.TabPage();
            this.label_evento_local = new System.Windows.Forms.Label();
            this.label_evento_descricao = new System.Windows.Forms.Label();
            this.label_evento_data = new System.Windows.Forms.Label();
            this.label_evento_titulo = new System.Windows.Forms.Label();
            this.listBox_eventos = new System.Windows.Forms.ListBox();
            this.tab_grupos = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_grupo_abreviatura = new System.Windows.Forms.Label();
            this.label_grupo_concelho = new System.Windows.Forms.Label();
            this.label_grupo_distrito = new System.Windows.Forms.Label();
            this.label_grupo_nome = new System.Windows.Forms.Label();
            this.listBox_grupos = new System.Windows.Forms.ListBox();
            this.menu.SuspendLayout();
            this.tab.SuspendLayout();
            this.tab_noticias.SuspendLayout();
            this.tab_eventos.SuspendLayout();
            this.tab_grupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_refresh,
            this.menu_utilizador});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(984, 33);
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
            // tab
            // 
            this.tab.Controls.Add(this.tab_noticias);
            this.tab.Controls.Add(this.tab_eventos);
            this.tab.Controls.Add(this.tab_grupos);
            this.tab.Location = new System.Drawing.Point(12, 36);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(959, 507);
            this.tab.TabIndex = 15;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tab_noticias
            // 
            this.tab_noticias.Controls.Add(this.listBox_noticias);
            this.tab_noticias.Controls.Add(this.label_noticia_conteudo);
            this.tab_noticias.Controls.Add(this.label_noticia_data);
            this.tab_noticias.Controls.Add(this.label_noticia_titulo);
            this.tab_noticias.Location = new System.Drawing.Point(4, 33);
            this.tab_noticias.Name = "tab_noticias";
            this.tab_noticias.Padding = new System.Windows.Forms.Padding(3);
            this.tab_noticias.Size = new System.Drawing.Size(951, 470);
            this.tab_noticias.TabIndex = 0;
            this.tab_noticias.Text = "Notícias";
            this.tab_noticias.UseVisualStyleBackColor = true;
            // 
            // listBox_noticias
            // 
            this.listBox_noticias.FormattingEnabled = true;
            this.listBox_noticias.ItemHeight = 24;
            this.listBox_noticias.Location = new System.Drawing.Point(18, 17);
            this.listBox_noticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_noticias.Name = "listBox_noticias";
            this.listBox_noticias.Size = new System.Drawing.Size(213, 436);
            this.listBox_noticias.TabIndex = 19;
            this.listBox_noticias.SelectedIndexChanged += new System.EventHandler(this.listBox_noticias_SelectedIndexChanged);
            // 
            // label_noticia_conteudo
            // 
            this.label_noticia_conteudo.AutoSize = true;
            this.label_noticia_conteudo.Location = new System.Drawing.Point(256, 95);
            this.label_noticia_conteudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_noticia_conteudo.Name = "label_noticia_conteudo";
            this.label_noticia_conteudo.Size = new System.Drawing.Size(93, 24);
            this.label_noticia_conteudo.TabIndex = 16;
            this.label_noticia_conteudo.Text = "Conteúdo";
            // 
            // label_noticia_data
            // 
            this.label_noticia_data.AutoSize = true;
            this.label_noticia_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noticia_data.Location = new System.Drawing.Point(257, 49);
            this.label_noticia_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_noticia_data.Name = "label_noticia_data";
            this.label_noticia_data.Size = new System.Drawing.Size(36, 18);
            this.label_noticia_data.TabIndex = 18;
            this.label_noticia_data.Text = "data";
            // 
            // label_noticia_titulo
            // 
            this.label_noticia_titulo.AutoSize = true;
            this.label_noticia_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noticia_titulo.Location = new System.Drawing.Point(254, 17);
            this.label_noticia_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_noticia_titulo.Name = "label_noticia_titulo";
            this.label_noticia_titulo.Size = new System.Drawing.Size(92, 32);
            this.label_noticia_titulo.TabIndex = 17;
            this.label_noticia_titulo.Text = "Título";
            // 
            // tab_eventos
            // 
            this.tab_eventos.Controls.Add(this.label_evento_local);
            this.tab_eventos.Controls.Add(this.label_evento_descricao);
            this.tab_eventos.Controls.Add(this.label_evento_data);
            this.tab_eventos.Controls.Add(this.label_evento_titulo);
            this.tab_eventos.Controls.Add(this.listBox_eventos);
            this.tab_eventos.Location = new System.Drawing.Point(4, 33);
            this.tab_eventos.Name = "tab_eventos";
            this.tab_eventos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_eventos.Size = new System.Drawing.Size(951, 470);
            this.tab_eventos.TabIndex = 1;
            this.tab_eventos.Text = "Eventos";
            this.tab_eventos.UseVisualStyleBackColor = true;
            // 
            // label_evento_local
            // 
            this.label_evento_local.AutoSize = true;
            this.label_evento_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_evento_local.Location = new System.Drawing.Point(257, 67);
            this.label_evento_local.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_evento_local.Name = "label_evento_local";
            this.label_evento_local.Size = new System.Drawing.Size(39, 18);
            this.label_evento_local.TabIndex = 22;
            this.label_evento_local.Text = "local";
            // 
            // label_evento_descricao
            // 
            this.label_evento_descricao.AutoSize = true;
            this.label_evento_descricao.Location = new System.Drawing.Point(256, 104);
            this.label_evento_descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_evento_descricao.Name = "label_evento_descricao";
            this.label_evento_descricao.Size = new System.Drawing.Size(94, 24);
            this.label_evento_descricao.TabIndex = 19;
            this.label_evento_descricao.Text = "Descrição";
            // 
            // label_evento_data
            // 
            this.label_evento_data.AutoSize = true;
            this.label_evento_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_evento_data.Location = new System.Drawing.Point(257, 49);
            this.label_evento_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_evento_data.Name = "label_evento_data";
            this.label_evento_data.Size = new System.Drawing.Size(36, 18);
            this.label_evento_data.TabIndex = 21;
            this.label_evento_data.Text = "data";
            // 
            // label_evento_titulo
            // 
            this.label_evento_titulo.AutoSize = true;
            this.label_evento_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_evento_titulo.Location = new System.Drawing.Point(254, 17);
            this.label_evento_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_evento_titulo.Name = "label_evento_titulo";
            this.label_evento_titulo.Size = new System.Drawing.Size(92, 32);
            this.label_evento_titulo.TabIndex = 20;
            this.label_evento_titulo.Text = "Título";
            // 
            // listBox_eventos
            // 
            this.listBox_eventos.FormattingEnabled = true;
            this.listBox_eventos.ItemHeight = 24;
            this.listBox_eventos.Location = new System.Drawing.Point(18, 17);
            this.listBox_eventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_eventos.Name = "listBox_eventos";
            this.listBox_eventos.Size = new System.Drawing.Size(213, 436);
            this.listBox_eventos.TabIndex = 16;
            this.listBox_eventos.SelectedIndexChanged += new System.EventHandler(this.listBox_eventos_SelectedIndexChanged);
            // 
            // tab_grupos
            // 
            this.tab_grupos.Controls.Add(this.listBox1);
            this.tab_grupos.Controls.Add(this.label_grupo_abreviatura);
            this.tab_grupos.Controls.Add(this.label_grupo_concelho);
            this.tab_grupos.Controls.Add(this.label_grupo_distrito);
            this.tab_grupos.Controls.Add(this.label_grupo_nome);
            this.tab_grupos.Controls.Add(this.listBox_grupos);
            this.tab_grupos.Location = new System.Drawing.Point(4, 33);
            this.tab_grupos.Name = "tab_grupos";
            this.tab_grupos.Size = new System.Drawing.Size(951, 470);
            this.tab_grupos.TabIndex = 2;
            this.tab_grupos.Text = "Grupos";
            this.tab_grupos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(256, 17);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(558, 124);
            this.listBox1.TabIndex = 28;
            // 
            // label_grupo_abreviatura
            // 
            this.label_grupo_abreviatura.AutoSize = true;
            this.label_grupo_abreviatura.Location = new System.Drawing.Point(252, 212);
            this.label_grupo_abreviatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grupo_abreviatura.Name = "label_grupo_abreviatura";
            this.label_grupo_abreviatura.Size = new System.Drawing.Size(114, 24);
            this.label_grupo_abreviatura.TabIndex = 27;
            this.label_grupo_abreviatura.Text = "(abreviatura)";
            // 
            // label_grupo_concelho
            // 
            this.label_grupo_concelho.AutoSize = true;
            this.label_grupo_concelho.Location = new System.Drawing.Point(252, 238);
            this.label_grupo_concelho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grupo_concelho.Name = "label_grupo_concelho";
            this.label_grupo_concelho.Size = new System.Drawing.Size(97, 24);
            this.label_grupo_concelho.TabIndex = 26;
            this.label_grupo_concelho.Text = "Concelho:";
            // 
            // label_grupo_distrito
            // 
            this.label_grupo_distrito.AutoSize = true;
            this.label_grupo_distrito.Location = new System.Drawing.Point(252, 262);
            this.label_grupo_distrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grupo_distrito.Name = "label_grupo_distrito";
            this.label_grupo_distrito.Size = new System.Drawing.Size(70, 24);
            this.label_grupo_distrito.TabIndex = 24;
            this.label_grupo_distrito.Text = "Distrito:";
            // 
            // label_grupo_nome
            // 
            this.label_grupo_nome.AutoSize = true;
            this.label_grupo_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grupo_nome.Location = new System.Drawing.Point(250, 182);
            this.label_grupo_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grupo_nome.Name = "label_grupo_nome";
            this.label_grupo_nome.Size = new System.Drawing.Size(94, 32);
            this.label_grupo_nome.TabIndex = 25;
            this.label_grupo_nome.Text = "Nome";
            // 
            // listBox_grupos
            // 
            this.listBox_grupos.FormattingEnabled = true;
            this.listBox_grupos.ItemHeight = 24;
            this.listBox_grupos.Location = new System.Drawing.Point(18, 17);
            this.listBox_grupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_grupos.Name = "listBox_grupos";
            this.listBox_grupos.Size = new System.Drawing.Size(213, 436);
            this.listBox_grupos.TabIndex = 23;
            this.listBox_grupos.SelectedIndexChanged += new System.EventHandler(this.listBox_grupos_SelectedIndexChanged);
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_home";
            this.Text = "Folclore Online";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_home_FormClosing);
            this.Shown += new System.EventHandler(this.Form_home_Shown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tab_noticias.ResumeLayout(false);
            this.tab_noticias.PerformLayout();
            this.tab_eventos.ResumeLayout(false);
            this.tab_eventos.PerformLayout();
            this.tab_grupos.ResumeLayout(false);
            this.tab_grupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_utilizador;
        private System.Windows.Forms.ToolStripMenuItem menu_refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_area_pessoal;
        public System.Windows.Forms.ToolStripMenuItem menu_terminar_sessao;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_noticias;
        private System.Windows.Forms.Label label_noticia_conteudo;
        private System.Windows.Forms.Label label_noticia_data;
        private System.Windows.Forms.Label label_noticia_titulo;
        private System.Windows.Forms.TabPage tab_eventos;
        private System.Windows.Forms.Label label_evento_descricao;
        private System.Windows.Forms.Label label_evento_data;
        private System.Windows.Forms.Label label_evento_titulo;
        private System.Windows.Forms.ListBox listBox_eventos;
        private System.Windows.Forms.Label label_evento_local;
        private System.Windows.Forms.ListBox listBox_noticias;
        private System.Windows.Forms.TabPage tab_grupos;
        private System.Windows.Forms.Label label_grupo_distrito;
        private System.Windows.Forms.Label label_grupo_nome;
        private System.Windows.Forms.ListBox listBox_grupos;
        private System.Windows.Forms.Label label_grupo_abreviatura;
        private System.Windows.Forms.Label label_grupo_concelho;
        private System.Windows.Forms.ListBox listBox1;
    }
}

