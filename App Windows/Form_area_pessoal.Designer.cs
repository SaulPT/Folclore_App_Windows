namespace App_Windows
{
    partial class Form_area_pessoal
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
            this.listBox_grupos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_editar_username = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_informacao = new System.Windows.Forms.TabPage();
            this.textBox_abreviatura = new System.Windows.Forms.TextBox();
            this.label_abreviatura = new System.Windows.Forms.Label();
            this.button_concluido = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.comboBox_concelho = new System.Windows.Forms.ComboBox();
            this.comboBox_distrito = new System.Windows.Forms.ComboBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_distrito = new System.Windows.Forms.Label();
            this.label_concelho = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.tab_eventos = new System.Windows.Forms.TabPage();
            this.listBox_grupo_eventos = new System.Windows.Forms.ListBox();
            this.tab_historial = new System.Windows.Forms.TabPage();
            this.button_grupo_evento_concluido = new System.Windows.Forms.Button();
            this.button_grupo_evento_editar = new System.Windows.Forms.Button();
            this.button_grupo_evento_eliminar = new System.Windows.Forms.Button();
            this.button_grupo_evento_adicionar = new System.Windows.Forms.Button();
            this.textBox_grupo_evento_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_grupo_evento_concelho = new System.Windows.Forms.ComboBox();
            this.comboBox_grupo_evento_distrito = new System.Windows.Forms.ComboBox();
            this.textBox_grupo_evento_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_grupo_evento_data = new System.Windows.Forms.DateTimePicker();
            this.textBox_grupo_evento_local = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_informacao.SuspendLayout();
            this.tab_eventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_grupos
            // 
            this.listBox_grupos.FormattingEnabled = true;
            this.listBox_grupos.ItemHeight = 24;
            this.listBox_grupos.Location = new System.Drawing.Point(18, 38);
            this.listBox_grupos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_grupos.Name = "listBox_grupos";
            this.listBox_grupos.Size = new System.Drawing.Size(342, 388);
            this.listBox_grupos.TabIndex = 13;
            this.listBox_grupos.SelectedIndexChanged += new System.EventHandler(this.listBox_grupos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_grupos);
            this.groupBox1.Location = new System.Drawing.Point(16, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 448);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupos administrados";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(85, 65);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(148, 45);
            this.button_logout.TabIndex = 17;
            this.button_logout.TabStop = false;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.04478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 17);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 33);
            this.label.TabIndex = 18;
            this.label.Text = "Utilizador: ";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.04478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(173, 17);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(0, 33);
            this.label_username.TabIndex = 19;
            // 
            // button_editar_username
            // 
            this.button_editar_username.Location = new System.Drawing.Point(249, 65);
            this.button_editar_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_editar_username.Name = "button_editar_username";
            this.button_editar_username.Size = new System.Drawing.Size(148, 45);
            this.button_editar_username.TabIndex = 20;
            this.button_editar_username.TabStop = false;
            this.button_editar_username.Text = "Editar";
            this.button_editar_username.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.BackgroundImage = global::App_Windows.Properties.Resources._5651_200;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh.Location = new System.Drawing.Point(18, 65);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(45, 45);
            this.button_refresh.TabIndex = 21;
            this.button_refresh.TabStop = false;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_informacao);
            this.tabControl.Controls.Add(this.tab_eventos);
            this.tabControl.Controls.Add(this.tab_historial);
            this.tabControl.Location = new System.Drawing.Point(417, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(665, 521);
            this.tabControl.TabIndex = 22;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab_informacao
            // 
            this.tab_informacao.Controls.Add(this.textBox_abreviatura);
            this.tab_informacao.Controls.Add(this.label_abreviatura);
            this.tab_informacao.Controls.Add(this.button_concluido);
            this.tab_informacao.Controls.Add(this.button_editar);
            this.tab_informacao.Controls.Add(this.comboBox_concelho);
            this.tab_informacao.Controls.Add(this.comboBox_distrito);
            this.tab_informacao.Controls.Add(this.textBox_nome);
            this.tab_informacao.Controls.Add(this.label_distrito);
            this.tab_informacao.Controls.Add(this.label_concelho);
            this.tab_informacao.Controls.Add(this.label_nome);
            this.tab_informacao.Location = new System.Drawing.Point(4, 33);
            this.tab_informacao.Name = "tab_informacao";
            this.tab_informacao.Padding = new System.Windows.Forms.Padding(3);
            this.tab_informacao.Size = new System.Drawing.Size(657, 484);
            this.tab_informacao.TabIndex = 0;
            this.tab_informacao.Text = "Informação";
            this.tab_informacao.UseVisualStyleBackColor = true;
            // 
            // textBox_abreviatura
            // 
            this.textBox_abreviatura.Enabled = false;
            this.textBox_abreviatura.Location = new System.Drawing.Point(154, 68);
            this.textBox_abreviatura.Name = "textBox_abreviatura";
            this.textBox_abreviatura.Size = new System.Drawing.Size(470, 29);
            this.textBox_abreviatura.TabIndex = 40;
            // 
            // label_abreviatura
            // 
            this.label_abreviatura.AutoSize = true;
            this.label_abreviatura.Location = new System.Drawing.Point(44, 71);
            this.label_abreviatura.Name = "label_abreviatura";
            this.label_abreviatura.Size = new System.Drawing.Size(110, 24);
            this.label_abreviatura.TabIndex = 39;
            this.label_abreviatura.Text = "Abreviatura:";
            // 
            // button_concluido
            // 
            this.button_concluido.Enabled = false;
            this.button_concluido.Location = new System.Drawing.Point(372, 218);
            this.button_concluido.Margin = new System.Windows.Forms.Padding(4);
            this.button_concluido.Name = "button_concluido";
            this.button_concluido.Size = new System.Drawing.Size(215, 45);
            this.button_concluido.TabIndex = 38;
            this.button_concluido.Text = "Concluído";
            this.button_concluido.UseVisualStyleBackColor = true;
            this.button_concluido.Click += new System.EventHandler(this.button_concluido_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(87, 218);
            this.button_editar.Margin = new System.Windows.Forms.Padding(4);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(215, 45);
            this.button_editar.TabIndex = 37;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // comboBox_concelho
            // 
            this.comboBox_concelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_concelho.Enabled = false;
            this.comboBox_concelho.FormattingEnabled = true;
            this.comboBox_concelho.Location = new System.Drawing.Point(154, 141);
            this.comboBox_concelho.Name = "comboBox_concelho";
            this.comboBox_concelho.Size = new System.Drawing.Size(470, 32);
            this.comboBox_concelho.TabIndex = 36;
            // 
            // comboBox_distrito
            // 
            this.comboBox_distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_distrito.Enabled = false;
            this.comboBox_distrito.FormattingEnabled = true;
            this.comboBox_distrito.Location = new System.Drawing.Point(154, 103);
            this.comboBox_distrito.Name = "comboBox_distrito";
            this.comboBox_distrito.Size = new System.Drawing.Size(470, 32);
            this.comboBox_distrito.TabIndex = 35;
            this.comboBox_distrito.SelectedIndexChanged += new System.EventHandler(this.comboBox_distrito_SelectedIndexChanged);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Enabled = false;
            this.textBox_nome.Location = new System.Drawing.Point(154, 33);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(470, 29);
            this.textBox_nome.TabIndex = 34;
            // 
            // label_distrito
            // 
            this.label_distrito.AutoSize = true;
            this.label_distrito.Location = new System.Drawing.Point(44, 106);
            this.label_distrito.Name = "label_distrito";
            this.label_distrito.Size = new System.Drawing.Size(70, 24);
            this.label_distrito.TabIndex = 33;
            this.label_distrito.Text = "Distrito:";
            // 
            // label_concelho
            // 
            this.label_concelho.AutoSize = true;
            this.label_concelho.Location = new System.Drawing.Point(44, 144);
            this.label_concelho.Name = "label_concelho";
            this.label_concelho.Size = new System.Drawing.Size(97, 24);
            this.label_concelho.TabIndex = 32;
            this.label_concelho.Text = "Concelho:";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(44, 36);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(67, 24);
            this.label_nome.TabIndex = 31;
            this.label_nome.Text = "Nome:";
            // 
            // tab_eventos
            // 
            this.tab_eventos.Controls.Add(this.textBox_grupo_evento_local);
            this.tab_eventos.Controls.Add(this.dateTimePicker_grupo_evento_data);
            this.tab_eventos.Controls.Add(this.label6);
            this.tab_eventos.Controls.Add(this.label5);
            this.tab_eventos.Controls.Add(this.label2);
            this.tab_eventos.Controls.Add(this.textBox_grupo_evento_descricao);
            this.tab_eventos.Controls.Add(this.label1);
            this.tab_eventos.Controls.Add(this.comboBox_grupo_evento_concelho);
            this.tab_eventos.Controls.Add(this.comboBox_grupo_evento_distrito);
            this.tab_eventos.Controls.Add(this.textBox_grupo_evento_nome);
            this.tab_eventos.Controls.Add(this.label3);
            this.tab_eventos.Controls.Add(this.label4);
            this.tab_eventos.Controls.Add(this.button_grupo_evento_adicionar);
            this.tab_eventos.Controls.Add(this.button_grupo_evento_eliminar);
            this.tab_eventos.Controls.Add(this.button_grupo_evento_concluido);
            this.tab_eventos.Controls.Add(this.button_grupo_evento_editar);
            this.tab_eventos.Controls.Add(this.listBox_grupo_eventos);
            this.tab_eventos.Location = new System.Drawing.Point(4, 33);
            this.tab_eventos.Name = "tab_eventos";
            this.tab_eventos.Size = new System.Drawing.Size(657, 484);
            this.tab_eventos.TabIndex = 2;
            this.tab_eventos.Text = "Eventos";
            this.tab_eventos.UseVisualStyleBackColor = true;
            // 
            // listBox_grupo_eventos
            // 
            this.listBox_grupo_eventos.FormattingEnabled = true;
            this.listBox_grupo_eventos.ItemHeight = 24;
            this.listBox_grupo_eventos.Location = new System.Drawing.Point(33, 26);
            this.listBox_grupo_eventos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_grupo_eventos.Name = "listBox_grupo_eventos";
            this.listBox_grupo_eventos.Size = new System.Drawing.Size(591, 148);
            this.listBox_grupo_eventos.TabIndex = 14;
            this.listBox_grupo_eventos.SelectedIndexChanged += new System.EventHandler(this.listBox_grupo_eventos_SelectedIndexChanged);
            // 
            // tab_historial
            // 
            this.tab_historial.Location = new System.Drawing.Point(4, 33);
            this.tab_historial.Name = "tab_historial";
            this.tab_historial.Padding = new System.Windows.Forms.Padding(3);
            this.tab_historial.Size = new System.Drawing.Size(657, 484);
            this.tab_historial.TabIndex = 1;
            this.tab_historial.Text = "Historial";
            this.tab_historial.UseVisualStyleBackColor = true;
            // 
            // button_grupo_evento_concluido
            // 
            this.button_grupo_evento_concluido.Enabled = false;
            this.button_grupo_evento_concluido.Location = new System.Drawing.Point(341, 418);
            this.button_grupo_evento_concluido.Margin = new System.Windows.Forms.Padding(4);
            this.button_grupo_evento_concluido.Name = "button_grupo_evento_concluido";
            this.button_grupo_evento_concluido.Size = new System.Drawing.Size(130, 45);
            this.button_grupo_evento_concluido.TabIndex = 40;
            this.button_grupo_evento_concluido.Text = "Concluído";
            this.button_grupo_evento_concluido.UseVisualStyleBackColor = true;
            this.button_grupo_evento_concluido.Click += new System.EventHandler(this.button_grupo_evento_concluido_Click);
            // 
            // button_grupo_evento_editar
            // 
            this.button_grupo_evento_editar.Location = new System.Drawing.Point(186, 418);
            this.button_grupo_evento_editar.Margin = new System.Windows.Forms.Padding(4);
            this.button_grupo_evento_editar.Name = "button_grupo_evento_editar";
            this.button_grupo_evento_editar.Size = new System.Drawing.Size(130, 45);
            this.button_grupo_evento_editar.TabIndex = 39;
            this.button_grupo_evento_editar.Text = "Editar";
            this.button_grupo_evento_editar.UseVisualStyleBackColor = true;
            this.button_grupo_evento_editar.Click += new System.EventHandler(this.button_grupo_evento_editar_Click);
            // 
            // button_grupo_evento_eliminar
            // 
            this.button_grupo_evento_eliminar.Location = new System.Drawing.Point(494, 418);
            this.button_grupo_evento_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.button_grupo_evento_eliminar.Name = "button_grupo_evento_eliminar";
            this.button_grupo_evento_eliminar.Size = new System.Drawing.Size(130, 45);
            this.button_grupo_evento_eliminar.TabIndex = 41;
            this.button_grupo_evento_eliminar.Text = "Eliminar";
            this.button_grupo_evento_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_grupo_evento_adicionar
            // 
            this.button_grupo_evento_adicionar.Location = new System.Drawing.Point(33, 418);
            this.button_grupo_evento_adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.button_grupo_evento_adicionar.Name = "button_grupo_evento_adicionar";
            this.button_grupo_evento_adicionar.Size = new System.Drawing.Size(130, 45);
            this.button_grupo_evento_adicionar.TabIndex = 42;
            this.button_grupo_evento_adicionar.Text = "Adicionar";
            this.button_grupo_evento_adicionar.UseVisualStyleBackColor = true;
            this.button_grupo_evento_adicionar.Click += new System.EventHandler(this.button_grupo_evento_adicionar_Click);
            // 
            // textBox_grupo_evento_descricao
            // 
            this.textBox_grupo_evento_descricao.Enabled = false;
            this.textBox_grupo_evento_descricao.Location = new System.Drawing.Point(148, 240);
            this.textBox_grupo_evento_descricao.Name = "textBox_grupo_evento_descricao";
            this.textBox_grupo_evento_descricao.Size = new System.Drawing.Size(470, 29);
            this.textBox_grupo_evento_descricao.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Data:";
            // 
            // comboBox_grupo_evento_concelho
            // 
            this.comboBox_grupo_evento_concelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_grupo_evento_concelho.Enabled = false;
            this.comboBox_grupo_evento_concelho.FormattingEnabled = true;
            this.comboBox_grupo_evento_concelho.Location = new System.Drawing.Point(425, 278);
            this.comboBox_grupo_evento_concelho.Name = "comboBox_grupo_evento_concelho";
            this.comboBox_grupo_evento_concelho.Size = new System.Drawing.Size(193, 32);
            this.comboBox_grupo_evento_concelho.TabIndex = 48;
            // 
            // comboBox_grupo_evento_distrito
            // 
            this.comboBox_grupo_evento_distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_grupo_evento_distrito.Enabled = false;
            this.comboBox_grupo_evento_distrito.FormattingEnabled = true;
            this.comboBox_grupo_evento_distrito.Location = new System.Drawing.Point(148, 275);
            this.comboBox_grupo_evento_distrito.Name = "comboBox_grupo_evento_distrito";
            this.comboBox_grupo_evento_distrito.Size = new System.Drawing.Size(168, 32);
            this.comboBox_grupo_evento_distrito.TabIndex = 47;
            this.comboBox_grupo_evento_distrito.SelectedIndexChanged += new System.EventHandler(this.comboBox_grupo_evento_distrito_SelectedIndexChanged);
            // 
            // textBox_grupo_evento_nome
            // 
            this.textBox_grupo_evento_nome.Enabled = false;
            this.textBox_grupo_evento_nome.Location = new System.Drawing.Point(148, 205);
            this.textBox_grupo_evento_nome.Name = "textBox_grupo_evento_nome";
            this.textBox_grupo_evento_nome.Size = new System.Drawing.Size(470, 29);
            this.textBox_grupo_evento_nome.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Concelho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Distrito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Local:";
            // 
            // dateTimePicker_grupo_evento_data
            // 
            this.dateTimePicker_grupo_evento_data.Location = new System.Drawing.Point(148, 322);
            this.dateTimePicker_grupo_evento_data.Name = "dateTimePicker_grupo_evento_data";
            this.dateTimePicker_grupo_evento_data.Size = new System.Drawing.Size(470, 29);
            this.dateTimePicker_grupo_evento_data.TabIndex = 54;
            // 
            // textBox_grupo_evento_local
            // 
            this.textBox_grupo_evento_local.Enabled = false;
            this.textBox_grupo_evento_local.Location = new System.Drawing.Point(148, 358);
            this.textBox_grupo_evento_local.Name = "textBox_grupo_evento_local";
            this.textBox_grupo_evento_local.Size = new System.Drawing.Size(470, 29);
            this.textBox_grupo_evento_local.TabIndex = 55;
            // 
            // Form_area_pessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 608);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_editar_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_area_pessoal";
            this.Text = "Área Pessoal";
            this.Load += new System.EventHandler(this.Form_area_pessoal_Load);
            this.Shown += new System.EventHandler(this.Form_area_pessoal_Shown);
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_informacao.ResumeLayout(false);
            this.tab_informacao.PerformLayout();
            this.tab_eventos.ResumeLayout(false);
            this.tab_eventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_grupos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_editar_username;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_informacao;
        private System.Windows.Forms.TabPage tab_historial;
        private System.Windows.Forms.TextBox textBox_abreviatura;
        private System.Windows.Forms.Label label_abreviatura;
        private System.Windows.Forms.Button button_concluido;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.ComboBox comboBox_concelho;
        private System.Windows.Forms.ComboBox comboBox_distrito;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_distrito;
        private System.Windows.Forms.Label label_concelho;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TabPage tab_eventos;
        private System.Windows.Forms.ListBox listBox_grupo_eventos;
        private System.Windows.Forms.Button button_grupo_evento_eliminar;
        private System.Windows.Forms.Button button_grupo_evento_concluido;
        private System.Windows.Forms.Button button_grupo_evento_editar;
        private System.Windows.Forms.Button button_grupo_evento_adicionar;
        private System.Windows.Forms.TextBox textBox_grupo_evento_local;
        private System.Windows.Forms.DateTimePicker dateTimePicker_grupo_evento_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_grupo_evento_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_grupo_evento_concelho;
        private System.Windows.Forms.ComboBox comboBox_grupo_evento_distrito;
        private System.Windows.Forms.TextBox textBox_grupo_evento_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}