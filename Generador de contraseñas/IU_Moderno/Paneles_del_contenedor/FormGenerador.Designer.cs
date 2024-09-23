namespace IU_Moderno.Paneles_del_contenedor
{
    partial class FormGenerador
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
            btn_Generar = new Controles.Boton_Personalizado();
            label10 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            CK_Caracteres = new Controles.Checkbox_Personalizado();
            label9 = new Label();
            label6 = new Label();
            CK_Numeros = new Controles.Checkbox_Personalizado();
            label7 = new Label();
            label4 = new Label();
            CK_Letras = new Controles.Checkbox_Personalizado();
            label5 = new Label();
            Generado = new TextBox();
            btn_Copiar = new Controles.Boton_Personalizado();
            Tamano = new TextBox();
            label1 = new Label();
            CK_Custom = new Controles.Checkbox_Personalizado();
            label11 = new Label();
            custom_characters = new TextBox();
            SuspendLayout();
            // 
            // btn_Generar
            // 
            btn_Generar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Generar.BackColor = Color.RoyalBlue;
            btn_Generar.BackgroundColor = Color.RoyalBlue;
            btn_Generar.BorderColor = Color.RoyalBlue;
            btn_Generar.BorderRadius = 0;
            btn_Generar.BorderSize = 0;
            btn_Generar.FlatAppearance.BorderSize = 0;
            btn_Generar.FlatStyle = FlatStyle.Flat;
            btn_Generar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Generar.ForeColor = Color.White;
            btn_Generar.Location = new Point(664, 434);
            btn_Generar.Name = "btn_Generar";
            btn_Generar.OnPressBackColor = Color.FromArgb(40, 96, 144);
            btn_Generar.OnPressForeColor = Color.White;
            btn_Generar.Size = new Size(150, 40);
            btn_Generar.TabIndex = 28;
            btn_Generar.Text = "Generar";
            btn_Generar.TextAlign = ContentAlignment.TopCenter;
            btn_Generar.TextColor = Color.White;
            btn_Generar.UseVisualStyleBackColor = false;
            btn_Generar.Click += btn_Generar_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(353, 420);
            label10.Name = "label10";
            label10.Size = new Size(89, 21);
            label10.TabIndex = 27;
            label10.Text = "Caracteres";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(216, 420);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 26;
            label3.Text = "Numeros";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(94, 420);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 25;
            label2.Text = "Letras";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(337, 455);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 24;
            label8.Text = "OFF";
            // 
            // CK_Caracteres
            // 
            CK_Caracteres.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CK_Caracteres.AutoSize = true;
            CK_Caracteres.Checked = true;
            CK_Caracteres.CheckState = CheckState.Checked;
            CK_Caracteres.Location = new Point(375, 452);
            CK_Caracteres.MinimumSize = new Size(45, 22);
            CK_Caracteres.Name = "CK_Caracteres";
            CK_Caracteres.OffBackColor = Color.Gray;
            CK_Caracteres.OffToggleColor = Color.Gainsboro;
            CK_Caracteres.OnBackColor = Color.DodgerBlue;
            CK_Caracteres.OnToggleColor = Color.WhiteSmoke;
            CK_Caracteres.Size = new Size(45, 22);
            CK_Caracteres.TabIndex = 23;
            CK_Caracteres.UseVisualStyleBackColor = true;
            CK_Caracteres.CheckedChanged += CK_Caracteres_CheckedChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(426, 455);
            label9.Name = "label9";
            label9.Size = new Size(28, 17);
            label9.TabIndex = 22;
            label9.Text = "ON";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(197, 454);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 21;
            label6.Text = "OFF";
            // 
            // CK_Numeros
            // 
            CK_Numeros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CK_Numeros.AutoSize = true;
            CK_Numeros.Checked = true;
            CK_Numeros.CheckState = CheckState.Checked;
            CK_Numeros.Location = new Point(235, 451);
            CK_Numeros.MinimumSize = new Size(45, 22);
            CK_Numeros.Name = "CK_Numeros";
            CK_Numeros.OffBackColor = Color.Gray;
            CK_Numeros.OffToggleColor = Color.Gainsboro;
            CK_Numeros.OnBackColor = Color.DodgerBlue;
            CK_Numeros.OnToggleColor = Color.WhiteSmoke;
            CK_Numeros.Size = new Size(45, 22);
            CK_Numeros.TabIndex = 20;
            CK_Numeros.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(286, 454);
            label7.Name = "label7";
            label7.Size = new Size(28, 17);
            label7.TabIndex = 19;
            label7.Text = "ON";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(62, 454);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 18;
            label4.Text = "OFF";
            // 
            // CK_Letras
            // 
            CK_Letras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CK_Letras.AutoSize = true;
            CK_Letras.Checked = true;
            CK_Letras.CheckState = CheckState.Checked;
            CK_Letras.Location = new Point(100, 451);
            CK_Letras.MinimumSize = new Size(45, 22);
            CK_Letras.Name = "CK_Letras";
            CK_Letras.OffBackColor = Color.Gray;
            CK_Letras.OffToggleColor = Color.Gainsboro;
            CK_Letras.OnBackColor = Color.DodgerBlue;
            CK_Letras.OnToggleColor = Color.WhiteSmoke;
            CK_Letras.Size = new Size(45, 22);
            CK_Letras.TabIndex = 17;
            CK_Letras.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(151, 454);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 16;
            label5.Text = "ON";
            // 
            // Generado
            // 
            Generado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Generado.BackColor = Color.FromArgb(46, 46, 46);
            Generado.BorderStyle = BorderStyle.FixedSingle;
            Generado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Generado.ForeColor = SystemColors.Control;
            Generado.Location = new Point(62, 93);
            Generado.Name = "Generado";
            Generado.Size = new Size(752, 29);
            Generado.TabIndex = 29;
            // 
            // btn_Copiar
            // 
            btn_Copiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Copiar.BackColor = Color.RoyalBlue;
            btn_Copiar.BackgroundColor = Color.RoyalBlue;
            btn_Copiar.BorderColor = Color.RoyalBlue;
            btn_Copiar.BorderRadius = 0;
            btn_Copiar.BorderSize = 0;
            btn_Copiar.FlatAppearance.BorderSize = 0;
            btn_Copiar.FlatStyle = FlatStyle.Flat;
            btn_Copiar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Copiar.ForeColor = Color.White;
            btn_Copiar.Location = new Point(495, 434);
            btn_Copiar.Name = "btn_Copiar";
            btn_Copiar.OnPressBackColor = Color.FromArgb(40, 96, 144);
            btn_Copiar.OnPressForeColor = Color.White;
            btn_Copiar.Size = new Size(150, 40);
            btn_Copiar.TabIndex = 30;
            btn_Copiar.Text = "Copiar";
            btn_Copiar.TextAlign = ContentAlignment.TopCenter;
            btn_Copiar.TextColor = Color.White;
            btn_Copiar.UseVisualStyleBackColor = false;
            btn_Copiar.Click += btn_Copiar_Click;
            // 
            // Tamano
            // 
            Tamano.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Tamano.BackColor = Color.FromArgb(46, 46, 46);
            Tamano.BorderStyle = BorderStyle.FixedSingle;
            Tamano.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tamano.ForeColor = SystemColors.Control;
            Tamano.Location = new Point(62, 365);
            Tamano.Name = "Tamano";
            Tamano.RightToLeft = RightToLeft.No;
            Tamano.Size = new Size(117, 27);
            Tamano.TabIndex = 31;
            Tamano.Text = "80";
            Tamano.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(84, 327);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 32;
            label1.Text = "Tamaño";
            // 
            // CK_Custom
            // 
            CK_Custom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CK_Custom.AutoSize = true;
            CK_Custom.Location = new Point(62, 234);
            CK_Custom.MinimumSize = new Size(45, 22);
            CK_Custom.Name = "CK_Custom";
            CK_Custom.OffBackColor = Color.Gray;
            CK_Custom.OffToggleColor = Color.Gainsboro;
            CK_Custom.OnBackColor = Color.DodgerBlue;
            CK_Custom.OnToggleColor = Color.WhiteSmoke;
            CK_Custom.Size = new Size(45, 22);
            CK_Custom.TabIndex = 33;
            CK_Custom.UseVisualStyleBackColor = true;
            CK_Custom.CheckedChanged += CK_Custom_CheckedChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(62, 199);
            label11.Name = "label11";
            label11.Size = new Size(208, 21);
            label11.TabIndex = 34;
            label11.Text = "Caracteres personalizados";
            // 
            // custom_characters
            // 
            custom_characters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            custom_characters.BackColor = Color.FromArgb(46, 46, 46);
            custom_characters.BorderStyle = BorderStyle.FixedSingle;
            custom_characters.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custom_characters.ForeColor = SystemColors.Control;
            custom_characters.Location = new Point(62, 274);
            custom_characters.Name = "custom_characters";
            custom_characters.Size = new Size(218, 29);
            custom_characters.TabIndex = 35;
            custom_characters.Text = "!@#$%^&*()_+-=[]{}|;:'\\\",.<>?";
            // 
            // FormGenerador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(837, 511);
            Controls.Add(custom_characters);
            Controls.Add(label11);
            Controls.Add(CK_Custom);
            Controls.Add(label1);
            Controls.Add(Tamano);
            Controls.Add(btn_Copiar);
            Controls.Add(Generado);
            Controls.Add(btn_Generar);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(CK_Caracteres);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(CK_Numeros);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(CK_Letras);
            Controls.Add(label5);
            Name = "FormGenerador";
            Text = "FormGenerador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.Boton_Personalizado btn_Generar;
        private Label label10;
        private Label label3;
        private Label label2;
        private Label label8;
        private Controles.Checkbox_Personalizado CK_Caracteres;
        private Label label9;
        private Label label6;
        private Controles.Checkbox_Personalizado CK_Numeros;
        private Label label7;
        private Label label4;
        private Controles.Checkbox_Personalizado CK_Letras;
        private Label label5;
        private TextBox Generado;
        private Controles.Boton_Personalizado btn_Copiar;
        private TextBox Tamano;
        private Label label1;
        private Controles.Checkbox_Personalizado CK_Custom;
        private Label label11;
        private TextBox custom_characters;
    }
}