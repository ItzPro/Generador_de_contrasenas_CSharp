using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU_Moderno.Paneles_del_contenedor
{
    public partial class FormContador : Form
    {
        public FormContador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Contar_Click(object sender, EventArgs e)
        {

            // Obtener el texto del TextBox
            string texto = txt_Entrada.Text;

            // Contar la cantidad de caracteres
            int cantidadCaracteres = texto.Length;

            // Asignar el resultado al Label
            lbl_Cantidad.Text = cantidadCaracteres.ToString();

        }

    }
}
