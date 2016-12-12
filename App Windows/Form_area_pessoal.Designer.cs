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
            this.button_informacao = new System.Windows.Forms.Button();
            this.button_corpo_gerente = new System.Windows.Forms.Button();
            this.button_historial = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_editar_username = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_grupos
            // 
            this.listBox_grupos.FormattingEnabled = true;
            this.listBox_grupos.ItemHeight = 24;
            this.listBox_grupos.Location = new System.Drawing.Point(18, 38);
            this.listBox_grupos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_grupos.Name = "listBox_grupos";
            this.listBox_grupos.Size = new System.Drawing.Size(233, 388);
            this.listBox_grupos.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_informacao);
            this.groupBox1.Controls.Add(this.button_corpo_gerente);
            this.groupBox1.Controls.Add(this.button_historial);
            this.groupBox1.Controls.Add(this.listBox_grupos);
            this.groupBox1.Location = new System.Drawing.Point(16, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(710, 448);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupos administrados";
            // 
            // button_informacao
            // 
            this.button_informacao.Location = new System.Drawing.Point(279, 38);
            this.button_informacao.Margin = new System.Windows.Forms.Padding(4);
            this.button_informacao.Name = "button_informacao";
            this.button_informacao.Size = new System.Drawing.Size(215, 45);
            this.button_informacao.TabIndex = 16;
            this.button_informacao.Text = "Informação";
            this.button_informacao.UseVisualStyleBackColor = true;
            this.button_informacao.Click += new System.EventHandler(this.button_informacao_Click);
            // 
            // button_corpo_gerente
            // 
            this.button_corpo_gerente.Location = new System.Drawing.Point(279, 147);
            this.button_corpo_gerente.Margin = new System.Windows.Forms.Padding(4);
            this.button_corpo_gerente.Name = "button_corpo_gerente";
            this.button_corpo_gerente.Size = new System.Drawing.Size(215, 45);
            this.button_corpo_gerente.TabIndex = 15;
            this.button_corpo_gerente.Text = "Corpo gerente";
            this.button_corpo_gerente.UseVisualStyleBackColor = true;
            // 
            // button_historial
            // 
            this.button_historial.Location = new System.Drawing.Point(279, 94);
            this.button_historial.Margin = new System.Windows.Forms.Padding(4);
            this.button_historial.Name = "button_historial";
            this.button_historial.Size = new System.Drawing.Size(215, 45);
            this.button_historial.TabIndex = 14;
            this.button_historial.Text = "Historial";
            this.button_historial.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(15, 66);
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
            this.button_editar_username.Location = new System.Drawing.Point(179, 66);
            this.button_editar_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_editar_username.Name = "button_editar_username";
            this.button_editar_username.Size = new System.Drawing.Size(148, 45);
            this.button_editar_username.TabIndex = 20;
            this.button_editar_username.TabStop = false;
            this.button_editar_username.Text = "Editar";
            this.button_editar_username.UseVisualStyleBackColor = true;
            // 
            // Form_area_pessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 603);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_grupos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_corpo_gerente;
        private System.Windows.Forms.Button button_historial;
        private System.Windows.Forms.Button button_informacao;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_editar_username;
    }
}