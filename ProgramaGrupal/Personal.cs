using System;


namespace ProgramaGrupal;

public class Persons
{
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public  int Edad { get; set; }
    public double Sueldo { get; set; }

    public Persons()
    {
        
    }

    public Persons(string PIdentificacion, string PNombre, int PEdad, double Sueldo)
    {
        this.Identificacion = PIdentificacion;
        this.Nombre = PNombre;
        this.Edad = PEdad;
        this.Sueldo = Sueldo;
    }

    public string edad()
    {
        if (Edad >= 18)
        {
            return "Es mayor de edad";
        }
        else
        {
            return "Es menor de edad";
        }
    }

    public string PagarImp()
    {
        if (Sueldo >= 3000000)
        {
            return "Debe pagar los impuestos";
        }
        else
        {
            return "No debe pagar impuestos";
        }
    }

}



