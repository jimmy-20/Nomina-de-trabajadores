using Prueba_Piloto.Clases.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Piloto.Clases.Models
{
    public class EmpleadoModel
    {
        private Empleado[] empleados;
        public int Id { get; set; }

        public EmpleadoModel()
        {
            Id = 1;
        }

        public void Add(Empleado e)
        {
            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
                Id = 2;
                return;
            }

            Empleado[] temp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados,temp,empleados.Length);
            temp[empleados.Length] = e;
            empleados = temp;

            Id++;
        }

        public void Edit()
        {

        }

        public Empleado[] FindAll()
        {
            return empleados;
        }

        public bool Delete()
        {


            return true;
        }
    }
}
