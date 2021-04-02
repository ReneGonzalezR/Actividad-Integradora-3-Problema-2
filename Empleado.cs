/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>

namespace Actividad_Integradora_3_Problema_2
{
    class Empleado
    {
        private int claveEmpleado;
        private string nombre;
        private double sueldo;

        public Empleado() { }
        public void setClaveEmpleado(int valor) { claveEmpleado = valor; }
        public void setNombre(string valor) { nombre = valor; }
        public void setSueldo(double valor) { sueldo = valor; }
        public int getClaveEmpleado() { return claveEmpleado; }
        public string getNombre() { return nombre; }
        public double getSueldo() { return sueldo; }
    }
}
