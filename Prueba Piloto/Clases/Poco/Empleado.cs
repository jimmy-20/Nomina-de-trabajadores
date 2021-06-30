using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Piloto.Clases.Poco
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public  string Cargo { get; set; }
        public decimal SalarioB { get; set; }
        public int HorasExtras { get; set; }
        public decimal SalarioExtra { get; set; }
        public decimal SalarioDev { get; set; }
        public decimal INSS_L { get; set; }
        public decimal IR { get; set; }
        public decimal Deducciones { get; set; }
        public decimal INSS_P { get; set; }
        public decimal INATEC { get; set; }
        
        public decimal Vacaciones { get; set; }
        public decimal Treceavo { get; set; }
        public decimal Indemnizacion { get; set; }
        public decimal SalarioNeto { get; set; }
    }
}
