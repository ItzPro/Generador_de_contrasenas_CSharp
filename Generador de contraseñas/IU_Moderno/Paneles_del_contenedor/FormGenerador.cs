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
    public partial class FormGenerador : Form
    {
        public FormGenerador()
        {
            InitializeComponent();

            Tamano.KeyPress += new KeyPressEventHandler(Tamano_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tamano_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            // Inicializar la cadena de caracteres permitidos
            string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";
            string caracteresEspeciales = "!@#$%^&*()_+-=[]{}|;:'\",.<>?";

            // Construir la cadena de caracteres permitidos según los CheckBox seleccionados
            string caracteresPermitidos = "";

            if (CK_Letras.Checked)
            {
                caracteresPermitidos += letras;
            }

            if (CK_Numeros.Checked)
            {
                caracteresPermitidos += numeros;
            }

            if (CK_Caracteres.Checked)
            {
                caracteresPermitidos += caracteresEspeciales;
            }

            // Obtener el tamaño especificado en el TextBox
            int tamano;
            if (int.TryParse(Tamano.Text, out tamano) && tamano > 0 && (CK_Letras.Checked || CK_Numeros.Checked || CK_Caracteres.Checked))
            {
                // Generar la cadena aleatoria
                Random random = new Random();
                char[] resultado = new char[tamano];
                for (int i = 0; i < tamano; i++)
                {
                    resultado[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
                }

                // Asignar la cadena generada al TextBox Generado
                Generado.Text = new string(resultado);
            }
            else
            {
                MessageBox.Show("Por favor, asegúrese de que el tamaño sea mayor que 0 y que al menos uno de los checkbox esté activado.");
            }
        }


        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Generado.Text))
            {
                Clipboard.SetText(Generado.Text);
            }
            else
            {
                MessageBox.Show("No hay texto para copiar.");
            }
        }
    }
}
