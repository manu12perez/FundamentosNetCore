using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR vacío");
            this.SalarioMinimo += 200; //200€ + que el salario mínimo
        }

        //METODO SOBRESCRITO
        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }

        //METODO IMPLEMENTADO
        public int GetDiasVacaciones(int extras)
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}
