/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
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
