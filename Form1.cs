using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculodelSueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Llamando el procedimiento
            limpiar();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Entrada de Datos
            double SueldoxHora = Convert.ToDouble(txtSueldoxHora.Text);
            double HorasT = Convert.ToDouble(txtHorasT.Text);
            double HorasExtras = Convert.ToDouble(txtHorasE.Text);

            //LLamando la funcion y asignando en la misma linea de código
            txtSueldoNeto.Text = Convert.ToString(Calcular(HorasT, HorasExtras, SueldoxHora));
        }

        //Procedimiento Limpiar
        private void limpiar()
        {
            txtNombre.Clear();
            txtSueldoxHora.Clear();
            txtHorasT.Clear();
            txtHorasE.Clear();
            txtSueldoB.Clear();
            txtImpuesto.Clear();
            txtSueldoNeto.Clear();

            txtNombre.Focus();

        }

        private double Calcular(double HorasT, double HorasExtras, double SueldoxHora)
        {

            
            double SueldoNormal = (SueldoxHora * HorasT);
            double SueldoExtra = (SueldoxHora * 2) * HorasExtras;
            double SueldoBruto = (SueldoNormal + SueldoExtra);
            double Impuesto = (SueldoBruto * 0.15);
            double SueldoNeto = (SueldoBruto - Impuesto);

            //Asignando valores
            txtSueldoB.Text = Convert.ToString(SueldoBruto);
            txtImpuesto.Text = Convert.ToString(Impuesto); //Impuesto 15% del Sueldo Bruto

            return SueldoNeto;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
