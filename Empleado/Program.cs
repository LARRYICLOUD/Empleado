using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" L&L SERIE.COM\n");

            //Variables locales
            string nombreAr, apellidoAr, nit;
            Console.WriteLine("ingrese los siguientes campos que se le solicitan\n");
            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();
            Console.Write("Digite su NIT para asignarlo a su tarjeta bancaria:   ");
            nit = Console.ReadLine();

            //Instanciamos a la clase Empleado

            Empleado empleado1 = new Empleado(nombreAr, apellidoAr);
            empleado1.Nit = nit;

            //mostrar la info del objeto
            Console.WriteLine(empleado1.ToString());

        }
    }
    class Empleado
    {
        //Campos de tipo privado
        private string nombre, apellido, id, locker, banco, nit;
        //Constructor
        public Empleado (string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //Llamando a los metodos para generar los numeros aleatorios
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();

            
        }

        Random random = new Random();

        //propiedades
        public string Nit
        {
            //lo podemos hacer de cualquiera d elas dos maneras
            //set { nit = value; }  
            set => nit = value;
        }
        //metodos 
        private string GenerarID()
        {
            //Instanciamos a random
            //Random random = new Random();

            //Variables
            int i, numero;
            string id= " ";

            for(i = 0; i < 10; i++)
            {
                numero = random.Next(10);
                id += numero.ToString();
            }
            return id;

        }
        //metodos 
        private string GenerarLocker()
        {
            //Instanciamos a random
            //Random random = new Random();

            //Variables
            int i, numero;
            string locker = " ";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);
                locker += numero.ToString();
            }
            return locker;

        }
        //Metodo
        private string AsignarBanco()
        {
            //instanciamos a Random
            //Random random = new Random();
            //Variables
            int asignarBanco;

            string banco = "";
            asignarBanco = random.Next(1,3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Banco Caja Social";
                        break;

                    case 2:
                    banco = "Banco de Bogota";
                    break;
            }

            return banco;

        }
        public override string ToString()
        {
            string mensaje = "";
            mensaje = "Empleado: " + nombre + " " + apellido + "\nNumero de empleado:  " + id + "\nlocker No. " + locker + "\nBanco asignado: " + banco;
            return mensaje;
        }
    }
}

