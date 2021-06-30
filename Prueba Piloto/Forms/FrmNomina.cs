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
    public partial class FrmNomina : Form
    {
        public EmpleadoModel Empleados;
        private DataTable dt;
        public FrmNomina()
        {
            InitializeComponent();
        }

        private void FrmNomina_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cargo");
            dt.Columns.Add("Salario");
            dt.Columns.Add("Horas extras");
            dt.Columns.Add("Salario extra");
            dt.Columns.Add("Salario devengado");
            dt.Columns.Add("INSS Laboral");
            dt.Columns.Add("IR");
            dt.Columns.Add("Deducciones");
            dt.Columns.Add("INSS Patronal");
            dt.Columns.Add("INATEC");
            dt.Columns.Add("Vacaciones");
            dt.Columns.Add("Treceavo");
            dt.Columns.Add("Indemnizacion");
            dt.Columns.Add("Salario a pagar");

            foreach(Empleado em in Empleados.FindAll())
            {
                DataRow row = dt.NewRow();
                row["Id"] = em.Id;
                row["Nombre"] = em.Nombre;
                row["Cargo"] = em.Cargo;
                row["Salario"] = em.SalarioB;
                row["Horas extras"] = em.HorasExtras;
                row["Salario extra"] = em.SalarioExtra;
                row["Salario devengado"] = em.SalarioDev;
                row["INSS Laboral"] = em.INSS_L;
                row["IR"] = em.IR;
                row["Deducciones"] = em.Deducciones;
                row["INSS Patronal"] = em.INSS_P;
                row["INATEC"] = em.INATEC;
                row["Vacaciones"] = em.Vacaciones;
                row["Treceavo"] = em.Treceavo;
                row["Indemnizacion"] = em.Indemnizacion;
                row["Salario a pagar"] = em.SalarioNeto;
  
                dt.Rows.Add(row);
            }

            dgvNomina.DataSource = dt;
        }
    }
}
