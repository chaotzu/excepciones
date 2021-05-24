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
   
   
        /*static void Main(string[] args)
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
        }*/

        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Control de personas que recibirán vacuna COVID (Ronda de aplicación 40 a 50 años)");
            Console.WriteLine("Introduce tu edad para saber si puedes aplicar la vacuna en esta ronda");
            try{
                edad = Convert.ToInt32(Console.ReadLine());
                if(!(edad >= 40 && edad <= 50))
                    throw new FiltroVacunadosException("Edad fuera de rango, no puede recibir la vacuna");
                else{
                    Console.WriteLine("Si puede recibir la vacuna");
                }
            }
            catch(FiltroVacunadosException fve){
                Console.WriteLine(fve.Message);
            }
            catch(FormatException fe){
                Console.WriteLine("Excepción, formato introducido no válido: " + fe.Message);                
            }
            catch(Exception e){
                Console.WriteLine("Excepción general: " + e.Message);
            }
            finally{
                Console.WriteLine("Gracias por utilizar el sistema de validación");                
            }
            
        }


        

    }
}
