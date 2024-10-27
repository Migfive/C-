// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

public class Figura 
{
    public int A, B;

    public void VariableA(int a)
    {
        this.A = a;
    }
    public void VariableB(int b)
    {
        this.B = b;
    }
    public int operation()
    {
        return A * B;
    }
}
public class Area:Figura
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Hallando el área");
        Console.WriteLine("Escribe el valor de la vairable: A ");
        int lado1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Escribe el valor de la vairable: B ");
        int lado2 = Convert.ToInt32(Console.ReadLine());

        Area area = new Area();
        area.VariableA(lado1);
        area.VariableB(lado2); 


        int resultado = area.operation();
        Console.WriteLine("El area es "+ resultado);

        Console.WriteLine("Represental el angulo");
        for (int i = 0; i < lado2; i++)
        {
            for (int j = 0; j < lado1; j++) { Console.Write("* "); }
            Console.WriteLine(); 
        }

    }
}
