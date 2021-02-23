using System;

namespace excepciones
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
         /*
    //Ejemplo divisiones
        static double DivisionSegura(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        public static void Main()
        {
            double a = 98, b = 0;
            double result;

            try
            {
                result = DivisionSegura(a, b);
                Console.WriteLine("{0} dividido por {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("División entre cero.");
            }
        }
    */
    
    
    //Throw 1
    /*
        static void ProcesarCadena(string s){
            if(s == null)
                throw new ArgumentNullException();
        }

        static void Main()
        {
            try
            {
                string s = null;
                ProcesarCadena(s);
            }
            catch (Exception e)
            {                
                Console.WriteLine("{0} Excepción capturada.", e);
            }
        }    
    */
   
   
        static void Main(string[] args)
        {
            int a=3, b = 1, c = 0;
            try{
                c = CalcularDivision(a,b);
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine(a+"/"+b+"="+c);
            }            
        }
        static int CalcularDivision(int numerador, int denominador){
            if(denominador == 0)
                throw new Exception("El denominador no debe ser cero");
            else{
                return (numerador / denominador);
            }
        }
        

    }
}
