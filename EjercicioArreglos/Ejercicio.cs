using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArreglos
{
    class Ejercicio
    {
        // Inicialice el vector con los nombres de los dia de la semana
        private string[] diasSemana= new string[] {  "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"  };  // Aquí
        public string[] DiasSemana
        {
            get { return diasSemana; }
        }

        public int TerminanEn(char c)
        {
            int n = 0;
            for (int x = 0; x < diasSemana.Length; x++)
            {
                string dia = diasSemana[x];
                if (dia[dia.Length-1]==c)
                {
                    n++;
                }
            }
            return n;
        }
    }
}
