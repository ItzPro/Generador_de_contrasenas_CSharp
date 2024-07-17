namespace IU_Moderno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PanelSideMenu = new Panel();
            btnContador2 = new Button();
            btnGenerador2 = new Button();
            panelContrasena = new Panel();
            btnContador = new Button();
            btnGenerador = new Button();
            btnContrasena = new Button();
            PanelLogo = new Panel();
            PanelSuperior = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panelContenedor = new Panel();
            PanelSideMenu.SuspendLayout();
            panelContrasena.SuspendLayout();
            PanelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSideMenu
            // 
            PanelSideMenu.AutoScroll = true;
            PanelSideMenu.BackColor = Color.FromArgb(31, 31, 31);
            PanelSideMenu.Controls.Add(btnContador2);
            PanelSideMenu.Controls.Add(btnGenerador2);
            PanelSideMenu.Controls.Add(panelContrasena);
            PanelSideMenu.Controls.Add(btnContrasena);
            PanelSideMenu.Controls.Add(PanelLogo);
            PanelSideMenu.Dock = DockStyle.Left;
            PanelSideMenu.Location = new Point(0, 0);
            PanelSideMenu.Name = "PanelSideMenu";
            PanelSideMenu.Size = new Size(250, 546);
            PanelSideMenu.TabIndex = 0;
            // 
            // btnContador2
            // 
            btnContador2.Dock = DockStyle.Top;
            btnContador2.FlatAppearance.BorderSize = 0;
            btnContador2.FlatStyle = FlatStyle.Flat;
            btnContador2.ForeColor = SystemColors.ControlLight;
            btnContador2.Location = new Point(0, 286);
            btnContador2.Name = "btnContador2";
            btnContador2.Padding = new Padding(10, 0, 0, 0);
            btnContador2.Size = new Size(250, 45);
            btnContador2.TabIndex = 4;
            btnContador2.Text = "Contador";
            btnContador2.TextAlign = ContentAlignment.MiddleLeft;
            btnContador2.UseVisualStyleBackColor = true;
            btnContador2.Click += btnContador2_Click;
            // 
            // btnGenerador2
            // 
            btnGenerador2.Dock = DockStyle.Top;
            btnGenerador2.FlatAppearance.BorderSize = 0;
            btnGenerador2.FlatStyle = FlatStyle.Flat;
            btnGenerador2.ForeColor = SystemColors.ControlLight;
            btnGenerador2.Location = new Point(0, 241);
            btnGenerador2.Name = "btnGenerador2";
            btnGenerador2.Padding = new Padding(10, 0, 0, 0);
            btnGenerador2.Size = new Size(250, 45);
            btnGenerador2.TabIndex = 3;
            btnGenerador2.Text = "Generador";
            btnGenerador2.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerador2.UseVisualStyleBackColor = true;
            btnGenerador2.Click += btnGenerador2_Click;
            // 
            // panelContrasena
            // 
            panelContrasena.BackColor = Color.FromArgb(46, 46, 46);
            panelContrasena.Controls.Add(btnContador);
            panelContrasena.Controls.Add(btnGenerador);
            panelContrasena.Dock = DockStyle.Top;
            panelContrasena.Location = new Point(0, 155);
            panelContrasena.Name = "panelContrasena";
            panelContrasena.Size = new Size(250, 86);
            panelContrasena.TabIndex = 2;
            // 
            // btnContador
            // 
            btnContador.Dock = DockStyle.Top;
            btnContador.FlatAppearance.BorderSize = 0;
            btnContador.FlatStyle = FlatStyle.Flat;
            btnContador.ForeColor = SystemColors.ControlLight;
            btnContador.Location = new Point(0, 40);
            btnContador.Name = "btnContador";
            btnContador.Padding = new Padding(35, 0, 0, 0);
            btnContador.Size = new Size(250, 40);
            btnContador.TabIndex = 1;
            btnContador.Text = "Contador";
            btnContador.TextAlign = ContentAlignment.MiddleLeft;
            btnContador.UseVisualStyleBackColor = true;
            btnContador.Click += btnContador_Click;
            // 
            // btnGenerador
            // 
            btnGenerador.Dock = DockStyle.Top;
            btnGenerador.FlatAppearance.BorderSize = 0;
            btnGenerador.FlatStyle = FlatStyle.Flat;
            btnGenerador.ForeColor = SystemColors.ControlLight;
            btnGenerador.Location = new Point(0, 0);
            btnGenerador.Name = "btnGenerador";
            btnGenerador.Padding = new Padding(35, 0, 0, 0);
            btnGenerador.Size = new Size(250, 40);
            btnGenerador.TabIndex = 0;
            btnGenerador.Text = "Generador";
            btnGenerador.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerador.UseVisualStyleBackColor = true;
            btnGenerador.Click += btnGenerador_Click;
            // 
            // btnContrasena
            // 
            btnContrasena.Dock = DockStyle.Top;
            btnContrasena.FlatAppearance.BorderSize = 0;
            btnContrasena.FlatStyle = FlatStyle.Flat;
            btnContrasena.ForeColor = SystemColors.ControlLight;
            btnContrasena.Location = new Point(0, 110);
            btnContrasena.Name = "btnContrasena";
            btnContrasena.Padding = new Padding(10, 0, 0, 0);
            btnContrasena.Size = new Size(250, 45);
            btnContrasena.TabIndex = 1;
            btnContrasena.Text = "Contraseña";
            btnContrasena.TextAlign = ContentAlignment.MiddleLeft;
            btnContrasena.UseVisualStyleBackColor = true;
            btnContrasena.Click += btnContrasena_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackgroundImage = (Image)resources.GetObject("PanelLogo.BackgroundImage");
            PanelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(250, 110);
            PanelLogo.TabIndex = 0;
            PanelLogo.MouseDown += PanelLogo_MouseDown_1;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(31, 31, 31);
            PanelSuperior.Controls.Add(button3);
            PanelSuperior.Controls.Add(button2);
            PanelSuperior.Controls.Add(button1);
            PanelSuperior.Controls.Add(label1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(250, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(837, 35);
            PanelSuperior.TabIndex = 1;
            PanelSuperior.MouseDown += PanelSuperior_MouseDown;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(711, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(42, 35);
            button3.TabIndex = 10;
            button3.Text = "-";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(753, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(42, 35);
            button2.TabIndex = 9;
            button2.Text = "□";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(795, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(42, 35);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(233, 212);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(26, 26, 26);
            panelContenedor.BackgroundImage = (Image)resources.GetObject("panelContenedor.BackgroundImage");
            panelContenedor.BackgroundImageLayout = ImageLayout.Zoom;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(837, 511);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1087, 546);
            Controls.Add(panelContenedor);
            Controls.Add(PanelSuperior);
            Controls.Add(PanelSideMenu);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            PanelSideMenu.ResumeLayout(false);
            panelContrasena.ResumeLayout(false);
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSideMenu;
        private Panel PanelLogo;
        private Panel panelContrasena;
        private Button btnContrasena;
        private Button btnContador;
        private Button btnGenerador;
        private Button btnContador2;
        private Button btnGenerador2;
        private Panel PanelSuperior;
        private Label label1;
        private Panel panelContenedor;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
