// See https://aka.ms/new-console-template for more information
using temperatura;

public class temp
{
    public static void Main(string[] args)
    {
        Clase1 c = new Clase1();
        double[] cc = new double[10];
        double t , sal;
        double [] f = new double [10];
        double[] k = new double[10];

        do
        {


            do
            {
                t = c.validar("Digite la cantidad de temperatura celsius:  ");


            } while (t <= 0 || t > 10);

            for (int i = 0; i < t; i++)
            {
                do
                {
                    cc[i] = c.validar("Celsius " + (1 + i) + ":");
                    c.setcelc(cc);

                } while (cc[i] <= -273.15 || cc[i] > 100);

                f[i] = (cc[i] * 9 / 5) + 32;
                k[i]= cc[i] + 273.15;
            }
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < t; i++) 
            {
                Console.WriteLine("Celsius:" + cc[i] + " Farenheit: " + f[i] + " Kelvin: " + k[i]);
                Console.WriteLine("------------------------");

            }

            do
            {
                sal = c.validar("Desea seguir en el programa? 1.Si 2.No" + "\t");

            } while (sal <= 0 || sal > 2);



        } while (sal==1);
    }
}
