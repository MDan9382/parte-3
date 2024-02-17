using System;

class Program
{
    static void Main(string[] args)
    {
        int selec;
        string cdn, res;

        Console.WriteLine("Ingrese una cadena de texto");
        cdn = Console.ReadLine();

        Console.WriteLine("introduzca la accion que deseea realizar");
        Console.WriteLine("1)imprimir en mayusaculas \n2)imprimir en minusculas \n3)imrpimir al reves");
        selec = Convert.ToInt16(Console.ReadLine());
        switch (selec)
        {
            case 1:
                res = cdn.ToUpper();
                Console.WriteLine(res);
                break;
            case 2:
                res = cdn.ToLower();
                Console.WriteLine(res);
                break;
            case 3:
                res = (string)cdn.Reverse();
                Console.WriteLine(res);
                break;
            default:
                Console.WriteLine("OPCION  INVALIDA");
                break; 
        }
    }
}