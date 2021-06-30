using Prueba_Piloto.Clases.Models;
using Prueba_Piloto.Clases.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Piloto.Forms
{
    public partial class FrmRegister : Form
    {
        public EmpleadoModel Empleados { get; set; }
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //DATOS INGRESADOS
            int id = Convert.ToInt32(nudId.Value);
            string nombre = txtNombre.Text;
            string cargo = txtCargo.Text;
            decimal salarioBasico = Convert.ToDecimal(txtSalario.Text);
            int horasExtras = Convert.ToInt32(txtHorasEx.Text);

            //CALCULO DE HORAS EXTRAS
            decimal salarioExtra = horasExtras * 2 * (salarioBasico / 240);
            decimal salarioDev = salarioBasico + salarioExtra;

            //DEDUCCIONES
            decimal Inss = salarioDev * 0.07m;
            decimal Ir = calculoIR(salarioDev - Inss);
            decimal deducciones = Inss + Ir;
            decimal salarioNeto = salarioDev - deducciones;

            //PRESTACIONES SOCIALES
            decimal InssP = salarioBasico * 0.0625m;
            decimal Inatec = salarioBasico * 0.07m;
            decimal vacaciones = salarioBasico * 0.0833m;
            decimal treceavo = vacaciones;
            decimal indemnizacion = treceavo;

            

            Empleado empleado = new Empleado()
            {
                Id = id,
                Nombre = nombre,
                Cargo = cargo,
                SalarioB = salarioBasico,

                HorasExtras = horasExtras,
                SalarioExtra = salarioExtra,
                SalarioDev = salarioDev,

                INSS_L = Inss,
                IR = Ir,
                Deducciones = deducciones,

                INSS_P = InssP,
                INATEC = Inatec,
                Vacaciones = vacaciones,
                Treceavo = treceavo,
                Indemnizacion = indemnizacion,
                SalarioNeto = salarioNeto
            };

            MessageBox.Show("Empleado agregado correctamente", "Mensaje de confirmación", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Empleados.Add(empleado);
        }

        public decimal calculoIR(decimal deduccion)
        {
            decimal IR = 0;
            double value = (double)deduccion;
            if (value <= 8333.33)
            {
                return IR;
            }else if(value > 8333.33 && value <= 16666.66)
            {
                IR = (decimal)((value - 8333.33 ) *0.15);
                return IR;
            }else if(value > 16666.66 && value <= 29166.66)
            {
                IR = (decimal)((value - 16666.66 ) *0.2 + 1250);
                return IR;
            }else if(value > 29166.66 && value <= 41666.66)
            {
                IR = (decimal)((value - 29166.66)*0.25 + 3750);
                return IR;
            }else if(value > 41666.66)
            {
                IR = (decimal)((value - 41666.66) * 0.3 + 6875);
                return IR;
            }

            return IR;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
