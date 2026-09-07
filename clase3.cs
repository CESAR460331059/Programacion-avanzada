using System.Reflection.Emit;

Console.WriteLine("------------Calculadora basica--------------");
Console.WriteLine("Ingresa un numero");
int num_1;
int num_2;
int opc;
int resultado;
num_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el numero 2");
num_2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------Menu de operaciones----------");
Console.WriteLine("1.Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3.Multiplicacion");
Console.WriteLine("4.Divison");
Console.WriteLine("5.Residuo");
Console.WriteLine("6.Binomio cuadrado perfecto");
opc=Convert.ToInt32(Console.ReadLine());
switch(opc)
{
    case 1:
    Console.WriteLine($"El resultado de la suma es:,{num_1+num_2}");
    break;
    case 2:
    Console.WriteLine($"El resultado de la Resta es:,{num_1-num_2}");
    break;
    case 3:
    Console.WriteLine($"El resultado de la Multiplicacion es:,{num_1*num_2}");
    break;
    case 4:
    Console.WriteLine($"El resultado de la Division es:,{num_1 / num_2}");
    break;
    case 5:
    Console.WriteLine($"El resultado del Modulo es:,{num_1 % num_2}");
    break;
    case 6:
    resultado=((num_1*num_1) + (2*(num_1*num_2))+(num_2*num_2));
    Console.WriteLine($"El resultado del Binomio es:,{num_1 / num_2}");
    break;
     default:
      Console.WriteLine("La opcion ingresada no es correcta");
      break;
}

    


