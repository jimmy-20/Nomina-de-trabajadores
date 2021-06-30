using Prueba_Piloto.Clases.Models;
using Prueba_Piloto.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Piloto
{
    public partial class Form1 : Form
    {
        private FrmRegister frmRegister;
        private FrmView frmView;
        private FrmNomina frmNomina;
        private EmpleadoModel empleados;
        public Form1()
        {
            InitializeComponent();
            empleados = new EmpleadoModel();
        }

        private void mniNuevo_Click(object sender, EventArgs e)
        {
            frmRegister = new FrmRegister();
            frmRegister.Empleados = empleados;
            frmRegister.MdiParent = this;
            frmRegister.Show();
        }

        private void mniVer_Click(object sender, EventArgs e)
        {
            frmView = new FrmView();
            frmView.empleados = empleados;
            frmView.MdiParent = this;
            frmView.Show();
        }

        private void mniImprimir_Click(object sender, EventArgs e)
        {
            frmNomina = new FrmNomina();
            frmNomina.Empleados = empleados;
            frmNomina.MdiParent = this;
            frmNomina.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
