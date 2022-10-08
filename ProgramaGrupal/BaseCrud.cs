using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace ProgramaGrupal
{
    public class BaseCrud
    {

        List<Persons> dataset = new List<Persons>();
        string Nombre, Identificacion;
        int Edad;
        double sueldo;

        public void CrearE()
        {
            Console.WriteLine(" -Crear empleados- ");
            Console.WriteLine(" \n ");

            Console.Write(" ingrese identficacion : ");
            Identificacion = Console.ReadLine();
            Console.Write(" ingrese nombre : ");
            Nombre = Console.ReadLine();
            Console.Write(" ingrese edad : ");
            Edad = int.Parse(Console.ReadLine());
            Console.Write(" ingrese sueldo : ");
            sueldo = double.Parse(Console.ReadLine());

            dataset.Add(new Persons(Identificacion, Nombre, Edad, sueldo));
        }

        public bool LVacia()
        {
            if (dataset.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string listv = "La lista esta vacia";

        public void List()
        {
            if (LVacia() == true)
            {
                Console.WriteLine(listv);
            }
            else
            {
                Console.WriteLine("Total de empleados: " + dataset.Count);
                Console.WriteLine("-----Lista-----");
                foreach (Persons item in dataset)
                {
                    Imprimir(item);
                }
            }

            Console.WriteLine("\n");
        }

        private void Imprimir(Persons dato)
        {
            Console.WriteLine(" ---------------------------------------------------- ");
            Console.WriteLine("| Identificacion : {0} | Nombre : {1} | Edad : {2} | Sueldo : {3} |",dato.Identificacion, dato.Nombre, dato.Edad, dato.Sueldo);
            Console.WriteLine(">> {0} >> {1}", dato.edad(), dato.PagarImp());
        }

        public void Delete()
        {
            string Buscar;
            if (LVacia() == true)
            {
                Console.WriteLine(listv);
            }
            else
            {
                Console.WriteLine("Ingrese identificacion: ");
                Buscar = Console.ReadLine();
                foreach (var item in dataset)
                {
                    if (Buscar == item.Identificacion)
                    {
                        Console.WriteLine(" ---------------------------------------------------- ");
                        Console.WriteLine("| Identificacion : {0} | Nombre : {1} | Edad : {2} | Sueldo : {3} |", item.Identificacion, item.Nombre, item.Edad, item.Sueldo);
                        Console.WriteLine(">> {0} >> {1}", item.edad(), item.PagarImp());

                    }
                    else
                    {
                        Console.WriteLine("No se encuentra la identificacion");
                    }
                }
            }
        }

        public void UpDate()
        {
            if (LVacia() == true)
            {
                Console.WriteLine(listv);
            }
            else
            {
                Persons pn = new Persons();
                Console.WriteLine("Ingrese identificacion: ");
                string buscar = Console.ReadLine();
                foreach (Persons item in dataset)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine(" ---------------------------------------------------- ");
                        Console.WriteLine("| Identificacion : {0} | Nombre : {1} | Edad : {2} | Sueldo : {3} |",item.Identificacion, item.Nombre, item.Edad, item.Sueldo);
                        Console.WriteLine(">> {0} >> {1}", item.edad(), item.PagarImp());
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Ingrese identificacion: ");
                        pn.Identificacion = Console.ReadLine();
                        item.Identificacion = pn.Identificacion;
                        pn.Nombre = Console.ReadLine();
                        item.Nombre = pn.Nombre;
                        Console.WriteLine("Ingrese edad: ");
                        pn.Edad = int.Parse(Console.ReadLine());
                        item.Edad = pn.Edad;
                        Console.WriteLine("Ingrese sueldo: ");
                        pn.Sueldo = double.Parse(Console.ReadLine());
                        item.Sueldo = pn.Sueldo;
                        pn.PagarImp();
                        Console.WriteLine("\n");
                        Console.WriteLine("Datos Modificados");

                    }
                }
            }
        }

        public void Searh()
        {
            if (LVacia()==true)
            {
                Console.WriteLine(listv);
            }
            else
            {
                Console.WriteLine("Ingrese identificacion");
                string buscar = Console.ReadLine();
                foreach (Persons item in dataset)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine("| Identificacion : {0} | Nombre : {1} | Edad : {2} | Sueldo : {3} |", item.Identificacion, item.Nombre, item.Edad, item.Sueldo);
                        Console.WriteLine(">> {0} >> {1}", item.edad(), item.PagarImp());
                    }
                    else
                    {
                        Console.WriteLine(listv);
                    }
                }

            }
        }
            
            
    }


}

