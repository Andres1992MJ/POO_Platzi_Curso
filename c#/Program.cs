using System;

namespace c_
{
    class Program
    {

      
        static void Main(string[] args)
        {

        
           // Console.WriteLine("Hello World!");

            //Account Conductor = new Account ("Andres Medina", "AND452");

            User Usuario1 = new User(1, "Andres Jurado", "1073", "prueba@ghj.com","clave");

            //Car carro = new Car("MWE875", Conductor);

           UberX Carrox = new UberX("MWE875", Usuario1, "chevrolet", "Camaro");

           Carrox.Imprimir();

            //carro.Imprimir();

            // Car carro1 = new Car();


            // carro1.Licence = "AWS785";

            // carro1.Driver = "Angie Rincon";

            // carro1.Imprimir();
          
        }
    }
}
