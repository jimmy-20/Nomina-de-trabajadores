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
    public partial class FrmView : Form
    {
        private DataTable dt;
        public EmpleadoModel empleados { get; set; }
        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cargo");
            dt.Columns.Add("Salario");
            dt.Columns.Add("Horas extras");

            if (empleados.FindAll() == null)
            {
                return;
            }

            foreach(Empleado em in empleados.FindAll())
            {
                DataRow row = dt.NewRow();
                row["Id"] = em.Id;
                row["Nombre"] = em.Nombre;
                row["Cargo"] = em.Cargo;
                row["Salario"] = em.SalarioB;
                row["Horas extras"] = em.HorasExtras;

                dt.Rows.Add(row);
            }

            dgvEmpleados.DataSource = dt;

        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEmpleados.DataSource;
            bs.Filter = $"Nombre like '%{txtFinder.Text}%'";
            dgvEmpleados.DataSource = bs;


        }
    }
}
