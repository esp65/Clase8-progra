using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_progra
{
    internal class Carrito1
    {
        public string marca { get; }
        public int modelo { get; }
        public string color { get; set; }

        public string owner { get; set;}

        private int encendido = 0;
        private int apagar = 0;
        private int bocina = 0;
        private int velocidad_actual = 0;
        
        public int maxvelocidad { get; }
        private const int freno = 10;
        

        public Carrito1 (string _marca, int _modelo, string _color, int _maxvel)
        {
            marca = _marca;
            modelo = _modelo;
            color = _color;
            encendido = 0;
            this.velocidad_actual = 0;
            maxvelocidad = _maxvel;

        }
       
        public Carrito1(string _marca, int _modelo, int _maxvel, string _owner)
        {
            marca = _marca;
            modelo = _modelo;
            this.velocidad_actual = 0;
            maxvelocidad = _maxvel;
            owner = _owner;

        }
        public Carrito1(string _marca, string _owner)
        {
            marca = _marca;
            owner = _owner;
        }
        public int Getvelocidadactual()
        {
            return velocidad_actual;

        }
        public string encender_motor()
        {
            if (encendido == 0)
            {
               
                encendido = 1;
                this.velocidad_actual = 0;
                return("run run run run, ya puedes correr");
            }
            else
            {

                return ($"El carro ya esta encendido");
            }
        }
        public string apagar_motor()
        {
            if (apagar == 0)
            {
                return ("El carro se encuentra apagado por favor enciendelo");
                apagar = 1;

            }
            else
            {

                return ($"El carro ya esta encendido");
            }
        }
        public string acelerar()
        {
            string mensaje = "";
            if (encendido == 0)
            {
                mensaje = ("No puedo acelerar con el carro apagado");
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= maxvelocidad)
            {
                mensaje = $"{ +velocidad_actual} KMP";
            }
            else
            {
                velocidad_actual = maxvelocidad;
                mensaje = $"{velocidad_actual} KMP Cuidado vas muy rapido, ya no puedes seguir acelerando llegaste a la velocidad maxima";
            }
            return mensaje;

        }
        public string acelerar(int cuantosKMP)
        {
            string mensaje = "";
            if (encendido == 0)
            {
                mensaje = ("No puedo acelerar con el carro apagado");
                return mensaje;
            }
            velocidad_actual += cuantosKMP;
            if (velocidad_actual <= maxvelocidad)
            {
                mensaje = $"{ +velocidad_actual} KMP";
            }
            else
            {
                velocidad_actual = maxvelocidad;
                mensaje = $"{velocidad_actual} KMP Cuidado vas muy rapido, ya no puedes seguir acelerando llegaste a la velocidad maxima";
            }
            return mensaje;
        }
        public string desacelerar()
        {
            string mensaje = "";
            if (encendido == 0)
            {
                mensaje = ("No puedo acelerar con el carro apagado");
                return mensaje;
            }
            velocidad_actual += 50;
            if (velocidad_actual <= 50)
            {
                mensaje = $"{ +velocidad_actual} KMP";
            }
            else
            {
                velocidad_actual = 50;
                mensaje = $"Muy bien acabas de desacelerar a {velocidad_actual} KMP vas mas despacio";
            }
            return mensaje;
        }
        public string frenar()
        {
            string mensaje = "";
            if (encendido == 0)
            {
                mensaje = ("No puedo acelerar con el carro apagado");
                return mensaje;
            }
            velocidad_actual -= freno;
            if (velocidad_actual >= 20)
            {
                mensaje = $"Muy bien acabas de frenar vas a {velocidad_actual} KMP";
            }
            return mensaje;
        }
        public string bocinar()
        {
            string mensaje = "";
            if (encendido == 0)
            {
                encendido = bocina;
            }

            {
                mensaje = $"PIIIIIIIIP PIIIIIIIP  PIIIIIIIP";
                encendido = 1;
            }
            return mensaje;
        }

    }
}
