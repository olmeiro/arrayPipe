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
            Persona miPersona = new Persona();
            //ArrayList listaPersonas = new ArrayList();


            listaPersonas.Add(new Persona("Martin", 56));
            listaPersonas.Add(new Persona("Olmeiro", 89));
            listaPersonas.Add(new Persona("Felipe", 104));
            listaPersonas.Add(new Persona("Luisa", 18));
            listaPersonas.Add(new Persona("Carolina", 25));
            listaPersonas.Add(new Persona("Donante", 19));


            foreach (Persona per in listaPersonas)
            {
                Console.WriteLine(per.nombre + " " + per.edad);
                
            }

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


