using IU_Moderno.Paneles_del_contenedor;
using System.Runtime.InteropServices;

namespace IU_Moderno
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //Barra de menu
        //-----------------------------------------------------------------------------------------------------------------------------------------------

        //Codigo para poder mover el formulario
        //-----------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Codigo que permite minimizar el formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimizar el formulario sin borde
                return cp;
            }
        }
        //Elementos del formulario al que le doy la funcionalidad para poder mover el formulario
        //-----------------------------------------------------------------------
        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelLogo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------------------------------------------


        //Eventos para los 3 botones del menu
        //-----------------------------------------------------------------------

        //Cerrar
        //-----------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar
        //-----------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Maximizar
        //-----------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        //-----------------------------------------------------------------------

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //Barra lateral
        //-----------------------------------------------------------------------------------------------------------------------------------------------



        //Ocultar paneles de sub menu
        //-----------------------------------------------------------------------
        private void customizeDesing()
        {
            panelContrasena.Visible = false;

        }
        //-----------------------------------------------------------------------

        //Minimizar el submenu
        //-----------------------------------------------------------------------
        private void hideSubMenu()
        {

            if (panelContrasena.Visible == true)
            {
                panelContrasena.Visible = false;
            }

        }
        //-----------------------------------------------------------------------

        //Mostrar el submenu
        //Si hay un submenu abierto lo cerrara y abrira al que le dimos
        //-----------------------------------------------------------------------
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //-----------------------------------------------------------------------


        //Boton Para mostrar el submenu
        //-----------------------------------------------------------------------
        private void btnContrasena_Click(object sender, EventArgs e)
        {
            showSubMenu(panelContrasena);
        }
        //-----------------------------------------------------------------------

        //Botones dentro del submenu abriran el form y cerraran el submenu
        //-----------------------------------------------------------------------
        private void btnGenerador_Click(object sender, EventArgs e)
        {
            //Mostrar pestaña

            openContenedor(new FormGenerador());

            //Cerrar sub menu
            hideSubMenu();
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            //Mostrar pestaña
            openContenedor(new FormContador());

            //Cerrar sub menu
            hideSubMenu();
        }
        //-----------------------------------------------------------------------

        //Botones fuera del submenu
        //-----------------------------------------------------------------------
        private void btnGenerador2_Click(object sender, EventArgs e)
        {
            //Mostrar pestaña
            openContenedor(new FormGenerador());

            //Cerrar sub menu
            hideSubMenu();
        }

        private void btnContador2_Click(object sender, EventArgs e)
        {
            //Mostrar pestaña
            openContenedor(new FormContador());

            //Cerrar sub menu
            hideSubMenu();
        }

        //-----------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------



        //Sitio Principal
        //-----------------------------------------------------------------------------------------------------------------------------------------------

        //Aqui hay un panel que sera reemplazado por los otros forms que llenaran el mismo espacio que el panel.
        //Cada vez que se abra un nuevo form cerrara el anterior.
        //-----------------------------------------------------------------------
        private Form activeForm = null;

        private void openContenedor(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        //-----------------------------------------------------------------------


    }
}
