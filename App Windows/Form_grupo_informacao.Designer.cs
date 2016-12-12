namespace App_Windows
{
    partial class Form_grupo_informacao
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
            this.label = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_concelho = new System.Windows.Forms.Label();
            this.label_distrito = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.comboBox_distrito = new System.Windows.Forms.ComboBox();
            this.comboBox_concelho = new System.Windows.Forms.ComboBox();
            this.button_informacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.04478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(330, 31);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 33);
            this.label.TabIndex = 19;
            this.label.Text = "Grupo";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(83, 127);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(67, 24);
            this.label_nome.TabIndex = 20;
            this.label_nome.Text = "Nome:";
            // 
            // label_concelho
            // 
            this.label_concelho.AutoSize = true;
            this.label_concelho.Location = new System.Drawing.Point(83, 209);
            this.label_concelho.Name = "label_concelho";
            this.label_concelho.Size = new System.Drawing.Size(97, 24);
            this.label_concelho.TabIndex = 21;
            this.label_concelho.Text = "Concelho:";
            // 
            // label_distrito
            // 
            this.label_distrito.AutoSize = true;
            this.label_distrito.Location = new System.Drawing.Point(83, 167);
            this.label_distrito.Name = "label_distrito";
            this.label_distrito.Size = new System.Drawing.Size(70, 24);
            this.label_distrito.TabIndex = 22;
            this.label_distrito.Text = "Distrito:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(186, 124);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.ReadOnly = true;
            this.textBox_nome.Size = new System.Drawing.Size(328, 29);
            this.textBox_nome.TabIndex = 23;
            // 
            // comboBox_distrito
            // 
            this.comboBox_distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_distrito.FormattingEnabled = true;
            this.comboBox_distrito.Location = new System.Drawing.Point(186, 164);
            this.comboBox_distrito.Name = "comboBox_distrito";
            this.comboBox_distrito.Size = new System.Drawing.Size(328, 32);
            this.comboBox_distrito.TabIndex = 24;
            // 
            // comboBox_concelho
            // 
            this.comboBox_concelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_concelho.FormattingEnabled = true;
            this.comboBox_concelho.Location = new System.Drawing.Point(186, 206);
            this.comboBox_concelho.Name = "comboBox_concelho";
            this.comboBox_concelho.Size = new System.Drawing.Size(328, 32);
            this.comboBox_concelho.TabIndex = 25;
            // 
            // button_informacao
            // 
            this.button_informacao.Location = new System.Drawing.Point(121, 300);
            this.button_informacao.Margin = new System.Windows.Forms.Padding(4);
            this.button_informacao.Name = "button_informacao";
            this.button_informacao.Size = new System.Drawing.Size(215, 45);
            this.button_informacao.TabIndex = 26;
            this.button_informacao.Text = "Informação";
            this.button_informacao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "Informação";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_grupo_informacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_informacao);
            this.Controls.Add(this.comboBox_concelho);
            this.Controls.Add(this.comboBox_distrito);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_distrito);
            this.Controls.Add(this.label_concelho);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_grupo_informacao";
            this.Text = "Grupo - Informação";
            this.Shown += new System.EventHandler(this.Form_grupo_informacao_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_concelho;
        private System.Windows.Forms.Label label_distrito;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.ComboBox comboBox_distrito;
        private System.Windows.Forms.ComboBox comboBox_concelho;
        private System.Windows.Forms.Button button_informacao;
        private System.Windows.Forms.Button button1;
    }
}