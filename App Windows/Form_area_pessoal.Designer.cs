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
            this.Notícias = new System.Windows.Forms.MenuStrip();
            this.menu_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_home = new System.Windows.Forms.ToolStripMenuItem();
            this.label_username = new System.Windows.Forms.Label();
            this.listBox_grupos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_historial = new System.Windows.Forms.Button();
            this.button_corpo_gerente = new System.Windows.Forms.Button();
            this.Notícias.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notícias
            // 
            this.Notícias.Font = new System.Drawing.Font("Segoe UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notícias.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.Notícias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_refresh,
            this.menu_home});
            this.Notícias.Location = new System.Drawing.Point(0, 0);
            this.Notícias.Name = "Notícias";
            this.Notícias.Size = new System.Drawing.Size(827, 33);
            this.Notícias.TabIndex = 11;
            this.Notícias.Text = "menuStrip1";
            // 
            // menu_refresh
            // 
            this.menu_refresh.Image = global::App_Windows.Properties.Resources._5651_200;
            this.menu_refresh.Name = "menu_refresh";
            this.menu_refresh.Size = new System.Drawing.Size(34, 29);
            // 
            // menu_home
            // 
            this.menu_home.Enabled = false;
            this.menu_home.Name = "menu_home";
            this.menu_home.Size = new System.Drawing.Size(92, 29);
            this.menu_home.Text = "Notícias";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(12, 40);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(213, 44);
            this.label_username.TabIndex = 12;
            this.label_username.Text = "Utilizador: ";
            // 
            // listBox_grupos
            // 
            this.listBox_grupos.FormattingEnabled = true;
            this.listBox_grupos.ItemHeight = 16;
            this.listBox_grupos.Location = new System.Drawing.Point(13, 25);
            this.listBox_grupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_grupos.Name = "listBox_grupos";
            this.listBox_grupos.Size = new System.Drawing.Size(214, 404);
            this.listBox_grupos.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_corpo_gerente);
            this.groupBox1.Controls.Add(this.button_historial);
            this.groupBox1.Controls.Add(this.listBox_grupos);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 448);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupos administrados";
            // 
            // button_historial
            // 
            this.button_historial.Location = new System.Drawing.Point(247, 25);
            this.button_historial.Name = "button_historial";
            this.button_historial.Size = new System.Drawing.Size(119, 32);
            this.button_historial.TabIndex = 14;
            this.button_historial.Text = "Historial";
            this.button_historial.UseVisualStyleBackColor = true;
            this.button_historial.Click += new System.EventHandler(this.button_historial_Click);
            // 
            // button_corpo_gerente
            // 
            this.button_corpo_gerente.Location = new System.Drawing.Point(247, 73);
            this.button_corpo_gerente.Name = "button_corpo_gerente";
            this.button_corpo_gerente.Size = new System.Drawing.Size(119, 32);
            this.button_corpo_gerente.TabIndex = 15;
            this.button_corpo_gerente.Text = "Corpo gerente";
            this.button_corpo_gerente.UseVisualStyleBackColor = true;
            // 
            // Form_area_pessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.Notícias);
            this.Name = "Form_area_pessoal";
            this.Text = "Form_utilizador";
            this.Notícias.ResumeLayout(false);
            this.Notícias.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Notícias;
        private System.Windows.Forms.ToolStripMenuItem menu_refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_home;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.ListBox listBox_grupos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_corpo_gerente;
        private System.Windows.Forms.Button button_historial;
    }
}