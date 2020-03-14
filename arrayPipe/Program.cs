using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;

namespace arrayPipe
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> listaPersonas = new List<Persona>();
            Console.WriteLine("capacidad: " + listaPersonas.Capacity);

            //Persona miPersona = new Persona();
            //ArrayList listaPersonas = new ArrayList();

            //Agregar persona a la list:
            //Primer forma: la tortuosa, no es automatica.

            //listaPersonas.Add(new Persona("Martin", 56));
            //listaPersonas.Add(new Persona("Olmeiro", 89));
            //listaPersonas.Add(new Persona("Felipe", 104));
            //listaPersonas.Add(new Persona("Luisa", 18));
            //listaPersonas.Add(new Persona("Carolina", 25));
            //listaPersonas.Add(new Persona("Donante", 19));

            //2 Forma:
            //Instancio la clase
            Persona unaPersona = new Persona();

            Console.WriteLine("Agregue clientes");
            string agregar = "si";

            while (agregar != "no")
            {
                Console.WriteLine("Ingrese nombre de la persona");
                string NombrePersona = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona");
                int edadPersona = int.Parse(Console.ReadLine());

                
                //unaPersona.nombre = NombrePersona;
                //unaPersona.edad = edadPersona;
                //llamando este objeto unaPersona en listaPersonas.Add() me genera problemas porque me repite la instancia, mejor:

                listaPersonas.Add(new Persona(NombrePersona,edadPersona));
                //listaPersonas.Clear();

                Console.WriteLine("desea agregar más personas?");
                string rtaAgregar = Console.ReadLine();
                if (rtaAgregar == "si")
                {
                    agregar = "si";
                } 
                else if(rtaAgregar.Equals("no"))
                {
                    agregar = "no";
                }

                
            }            

            foreach (Persona per in listaPersonas)
            {
                Console.WriteLine(per.nombre + " " + per.edad);
            }

            //Modificar persona en la lista: Si busco la persona por nombre no puedo modificar su nombre!!!

            Console.WriteLine("modificar persona: ");

            Console.WriteLine("Ingrese nombre de la persona a modificar");
            string modPersona = Console.ReadLine();

            foreach (var item in listaPersonas)
            {
                if (item.nombre.Equals(modPersona))
                {
                    Console.WriteLine("ingrese nueva edad");
                    int nuevaEdad = int.Parse(Console.ReadLine());
                    item.edad = nuevaEdad;
                }
            }

            foreach (Persona per in listaPersonas)
            {
                Console.WriteLine(per.nombre + " " + per.edad);
            }

            //Eliminar persona:

            Console.WriteLine();
            Console.WriteLine("ingrese el nombre de la persona a eliminar");
            string nombreDel = Console.ReadLine();
            Console.WriteLine();

            for (var index = listaPersonas.Count - 1; index >= 0; index--)
            {
                if (listaPersonas[index].nombre.Equals(nombreDel))
                {
                    listaPersonas.RemoveAt(index);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Nueva lista");
            Console.WriteLine();

            listaPersonas.ForEach(
                per => Console.WriteLine(per.nombre));

            Console.ReadKey();
        }
    }
}


