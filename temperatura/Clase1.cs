using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    internal class Clase1
    {
        private double[] celc = new double[10];

        public Clase1() { }
        public Clase1(double[] Celc)
        {
            celc = Celc;
        }
        public void conver(double[] Celc)
        {
            this.celc = Celc;
        }

        public void setcelc(double [] celc) 
        {
          this.celc=celc;
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras", error.Message);
                }
            } while (v == 0);
            return num;
        }
    }
}
