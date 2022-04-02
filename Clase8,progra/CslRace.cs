using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_progra
{
    internal class CslRace
    {
        private readonly Carrito1 CarroA;
        private Carrito1 CarroB;
        private Carrito1 CarroC;
        
        public void pedirdatcarrera()
        {
            Carrito1 CarroA;
            Carrito1 CarroB;
            Carrito1 CarroC;
            CarroA = GetData();
            Console.WriteLine("Ingrese los datos que le asignara al B");
            CarroB = GetData();
            Console.WriteLine("Ingrese los datos que le asignara al c");
            CarroC = GetData();
        }
        public void iniciarcarrera()
        {
            string msjCarroA, msjCarroB, msjCarroC;

            Random vrand = new Random();

            msjCarroA = CarroA.encender_motor();
            msjCarroB = CarroB.encender_motor();
            msjCarroC = CarroC.encender_motor();
            Console.WriteLine($"{CarroA.marca} {msjCarroA}");
            Console.WriteLine($"{CarroB.marca} {msjCarroB}");
            Console.WriteLine($"{CarroB.marca} {msjCarroC}");

            for (int i = 0; i < 10; i++)
            {
                int acelerar;
                acelerar = vrand.Next(1, 21);
                msjCarroA = CarroA.acelerar(acelerar);
                acelerar = vrand.Next(1, 21);
                msjCarroB = CarroB.acelerar(acelerar);
                acelerar = vrand.Next(1, 21);
                msjCarroC = CarroC.acelerar(acelerar);
                Console.WriteLine($"{i}- {CarroA.owner} {msjCarroA} {CarroB.owner} {msjCarroB} {CarroC.owner} {msjCarroC}");
                while(i<=acelerar)
                {
                    Console.WriteLine(i);
                    i = i + acelerar;
                }
                Console.WriteLine($"La acumulacion es de: {i}");
                Console.ReadKey();
     
            }

            Console.WriteLine("En el marcador va ganando:");

            if (CarroA.Getvelocidadactual() > CarroB.Getvelocidadactual())
            {
                Console.WriteLine($"Yupiiiiii!!!!!! Ganaste {CarroA.owner} ");
            }
            else
            {
                Console.WriteLine($"Yupiiiiii!!!!!! Ganaste {CarroB.owner} ");
            }
        }
        private Carrito1 GetData()
        {
            string marca;
            //int modelo;
            int velocidad;
            string propietario;
            string owner;
            Carrito1 carrtempo;

            Console.WriteLine("Ingrese su nombre");
            owner= Console.ReadLine();
            //Console.WriteLine("Ingrese un modelo para su auto");
            //modelo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese velocidad Max");
            // velocidad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Propietario:");
            //propietario = (Console.ReadLine());
            Console.WriteLine("Ingrese una marca");
            marca = Console.ReadLine();
            carrtempo = new Carrito1(marca, owner);
            return carrtempo;
        }


    }
}
