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

        public EmpleadoModel()
        {

        }

        public void Add(Empleado e)
        {
            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
                return;
            }

            Empleado[] temp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados,temp,empleados.Length);
            temp[empleados.Length] = e;
            empleados = temp;
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
