using System;

namespace ProgramaGrupal;

public class Menu : BaseCrud
{
    private string MenuOp;

    public void iniciar()
    {
        do
        {
            
            {
                menu();
            }
            
        } while (MenuOp !="0");
    }

    private void menu()
    {
        Console.WriteLine(" ---- Control Empleados -----");
        Console.WriteLine("\n");
        Console.WriteLine(" ------- Menu -----------");
        Console.WriteLine("\n");
        Console.WriteLine(" 1 [ Crear Registro ]     | 3. [ Eliminar Empleado ] ");
        Console.WriteLine(" 2 [ lista de empleados ] | 4. [ Modificar Empleado ] ");
        Console.WriteLine(" 0 [ salir ] 5. [ Buscar empleado ] ");
        Console.WriteLine("\n");
        Console.Write("Seleccione una opcion: ");
        MenuOp = Console.ReadLine();
        MenuSelection(MenuOp);
    }

    private void MenuSelection(string op)
    {
        
        if (op == " ")
            return;
        switch (op)
        {   
            case "1":
                Console.Clear();
                CrearE();
                ReturnMenu();
                Console.ReadKey();
                break ;
            case "2":
                Console.Clear();
                List();
                ReturnMenu();
                Console.ReadKey();
                break ;
            case "3":
                Console.Clear();
                Delete();
                ReturnMenu();
                Console.ReadKey();
                break ;
            case "4":
                Console.Clear();
                UpDate();
                ReturnMenu();
                Console.ReadKey();
                break ;
            case "5":
                Console.Clear();
                Searh();
                ReturnMenu();
                Console.ReadKey();
                break ;
            case "0":
                Console.Clear();
                menu();
                Console.ReadKey();
                ReturnMenu();
                break ;
            default :
                Console.WriteLine("Seleccion invalida");
                break ;
        }
        
    }

    private void ReturnMenu()
    {
        string op;
        Console.WriteLine("Presione r para volver al menu");
        op = Console.ReadLine();
        MenuSelection(op);
    }

}
