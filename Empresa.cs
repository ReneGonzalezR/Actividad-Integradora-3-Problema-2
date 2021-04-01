using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_3_Problema_2
{
    class Empresa
    {
        private Empleado[] empleados;
        int contador = 0;
        public Empresa() { }
        public void setEmpleado(Empleado valor) { empleados[contador] = valor; contador++; }
        public Empleado getEmpleado(int valor) { return empleados[valor]; }
        public int getEnumerador() { return contador; }
    }
}
