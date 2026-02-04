using IntroduccionCSharp.Ejemplos;

//Persona persona1 = new Persona("Mario", "Salinas", "M", 19);

//Console.WriteLine("Hola " + persona1.Nombres + " " + persona1.Apellidos + ", tienes " + persona1.Edad + " años.");



/*class Program
{
    static void Main()
    {
        Console.WriteLine("Hola mundo");
        Console.WriteLine ("¿Como te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine("¿Que edad tienes?");
        string edad = Console.ReadLine();

        Console.WriteLine("\nHola " + nombre +" Tienes "+ edad + "años.");
    }
}*/


// Calculadora calculadora = new Calculadora();

// Console.WriteLine("===============SUMAR===============");
// Console.WriteLine("");
// string operación = "";
// int n1 = 0;
// int n2 = 0;

// try
// {

//     Console.WriteLine("Ingrese la operación (+, -, *, /): ");
//     operación = Console.ReadLine();

//     Console.WriteLine("Ingrese el primer numero: ");
//     n1 =int.Parse(Console.ReadLine());

//     Console.WriteLine("Ingrese el segundo numero: ");
//     n2 =int.Parse(Console.ReadLine());
    
// }
// catch
// {
//     Console.WriteLine("Se produjo un error al realizar la suma");
// }

// int resultado = 0;

// switch (operación)
// {
//     case "+":
//         resultado = calculadora.Sumar(n1, n2);
//     break;

//     case "-":
//         resultado = calculadora.Restar(n1, n2);
//     break;

//     case "*":
//         resultado = calculadora.Multiplicar(n1, n2);
//     break;

//     case "/":
//         resultado = calculadora.Dividir(n1, n2);
//     break;


//     default:

//     throw new Exception("No ingreso una operación valida");
// }

    
// Console.WriteLine("El resultado de la operación es: " + resultado); 

/////////////////////////////////////////////////////////////////////////////////////////////////
 
Console.WriteLine("Ingrese el tamaño del arreglo: ");
int tamaño = int.Parse(Console.ReadLine());
Arreglos arreglos = new Arreglos(tamaño);

//TODO: Solo ingresar valores positivos

//Menu
// 1. Crear el arreglo
// 2. Agregar valores
// 3. Imprimir valores
// 4. Salir

int a = 0;
int opción;
do
{
    Console.WriteLine("=================MENU================");
    Console.WriteLine("1. Crear el arreglo");
    Console.WriteLine("2. Agregar valores");
    Console.WriteLine("3. Imprimir valores");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Seleccione una opción: ");

    opción = int.Parse(Console.ReadLine());

    switch (opción)
    {
        case 1:
            //Console.WriteLine("Ingrese el tamaño del arreglo: ");
            //tamaño = int.Parse(Console.ReadLine());
            arreglos = new Arreglos(tamaño);
            a = 1;
            Console.WriteLine("Arreglo de tamaño " + tamaño + " creado.");
            break;

        case 2:
            if (a == 0)
            {
                Console.WriteLine("Primero debe crear el arreglo.");
                break;
            }

            if (arreglos.CurrentPosition >= tamaño)
            {
                Console.WriteLine("El arreglo ya está lleno.");
                break;
            }

            Console.WriteLine("Ingrese un valor positivo para agregar al arreglo: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                arreglos.AddValue(valor);
                Console.WriteLine("Valor agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Solo se permiten valores positivos.");
            }
            break;

        case 3:
            if (a == 0)
            {
                Console.WriteLine("Primero debe crear el arreglo.");
            }
            else
            {
                arreglos.Print();
            }
            break;

        case 4:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

} while (opción != 4);