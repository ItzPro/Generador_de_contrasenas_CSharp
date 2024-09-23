namespace IU_Moderno.Paneles_del_contenedor
{
    partial class FormContador
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
            label1 = new Label();
            label2 = new Label();
            lbl_Cantidad = new Label();
            btn_Contar = new Controles.Boton_Personalizado();
            txt_Entrada = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(50, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 33;
            label1.Text = "Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(50, 149);
            label2.Name = "label2";
            label2.Size = new Size(191, 21);
            label2.TabIndex = 34;
            label2.Text = "Cantidad de caracteres: ";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Cantidad.ForeColor = SystemColors.Control;
            lbl_Cantidad.Location = new Point(247, 149);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(0, 21);
            lbl_Cantidad.TabIndex = 35;
            // 
            // btn_Contar
            // 
            btn_Contar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Contar.BackColor = Color.RoyalBlue;
            btn_Contar.BackgroundColor = Color.RoyalBlue;
            btn_Contar.BorderColor = Color.RoyalBlue;
            btn_Contar.BorderRadius = 0;
            btn_Contar.BorderSize = 0;
            btn_Contar.FlatAppearance.BorderSize = 0;
            btn_Contar.FlatStyle = FlatStyle.Flat;
            btn_Contar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contar.ForeColor = Color.White;
            btn_Contar.Location = new Point(652, 440);
            btn_Contar.Name = "btn_Contar";
            btn_Contar.OnPressBackColor = Color.FromArgb(40, 96, 144);
            btn_Contar.OnPressForeColor = Color.White;
            btn_Contar.Size = new Size(150, 40);
            btn_Contar.TabIndex = 36;
            btn_Contar.Text = "Contar";
            btn_Contar.TextAlign = ContentAlignment.TopCenter;
            btn_Contar.TextColor = Color.White;
            btn_Contar.UseVisualStyleBackColor = false;
            btn_Contar.Click += btn_Contar_Click;
            // 
            // txt_Entrada
            // 
            txt_Entrada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Entrada.BackColor = Color.FromArgb(46, 46, 46);
            txt_Entrada.BorderStyle = BorderStyle.FixedSingle;
            txt_Entrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Entrada.ForeColor = SystemColors.Control;
            txt_Entrada.Location = new Point(50, 80);
            txt_Entrada.Name = "txt_Entrada";
            txt_Entrada.Size = new Size(752, 29);
            txt_Entrada.TabIndex = 37;
            // 
            // FormContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(837, 511);
            Controls.Add(txt_Entrada);
            Controls.Add(btn_Contar);
            Controls.Add(lbl_Cantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormContador";
            Text = "FormContador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Generado;
        private Label label1;
        private Label label2;
        private Label lbl_Cantidad;
        private Controles.Boton_Personalizado btn_Contar;
        private TextBox txt_Entrada;
    }
}