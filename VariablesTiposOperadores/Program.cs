
// See https://aka.ms/new-console-template for more information
//Variables, Tipos, Operadores
//Ejercicio sesión 2
//--------------------------------------------------------------

//Ejercicio 1
//Variables Escribe un programa que reciba datos de una persona y 
//genera un mensaje, usa una variable para cada dato y otra para el mensaje. 
//Ej: nombre, apellido, edad, sabe programar, etc.
Console.WriteLine("Introduce tu nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Introduce tu apellido: ");
string? apellido = Console.ReadLine();

Console.WriteLine("Introduce tu edad: ");
int edad = int.Parse(Console.ReadLine() ?? " ");

Console.WriteLine("Sabes programar: (si/no)");
string? programar = Console.ReadLine();

Console.WriteLine("Hola " + nombre + "!" + " " + "Tu apellido es: " + apellido + " " + "Tu edad es: " + edad + " " + "Sabes programar: " + programar);


//Ejercicio 2
//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
//Coche: puertas, ruedas, marca, ITV vigente 
//Mesa: peso, largo, material, color

Console.WriteLine("Describe las caracteristicas de tu Coche: ");
Console.WriteLine("Introduce el numero de puertas: ");
int puertas = int.Parse(Console.ReadLine() ?? " ");
Console.WriteLine("Introduce el numero de ruedas: ");
int ruedas = int.Parse(Console.ReadLine() ?? " ");
Console.WriteLine("Introduce la marca: ");
string? marca = Console.ReadLine();
Console.WriteLine("Introduce si la ITV esta vigente: ");
string? itv = Console.ReadLine();

Console.WriteLine("Tu coche tiene las siguientes caracteristicas: " + puertas + " " + "puertas" + " " + ruedas + " " + "ruedas" + " " + "marca" + " " + marca + " " + "ITV vigente" + " " + itv);

Console.WriteLine("Describe las caracteristicas de tu Mesa: ");
Console.WriteLine("Introduce el peso: ");
double peso = double.Parse(Console.ReadLine() ?? " ");
Console.WriteLine("Introduce el largo: ");
double largo = int.Parse(Console.ReadLine() ?? " ");
Console.WriteLine("Introduce el material: ");
string? material = Console.ReadLine();
Console.WriteLine("Introduce el color: ");
string? color = Console.ReadLine();

Console.WriteLine("Tu mesa tiene las siguientes caracteristicas: " + peso + " " + "peso" + " " + largo + " " + "largo" + " " + "material" + " " + material + " " + "color" + " " + color);


//Ejercicio 3
//Operadores Determina los operadores para verificar las siguientes condiciones:

//Un número es mayor o igual a 18
//Un char es ‘a’
//Se cumplen dos conciones a la vez (ambas verdaderas)
//Se cumple una de dos condiciones a la vez (una true y otra false)

Console.WriteLine("Introduce un numero: ");
int numero = int.Parse(Console.ReadLine() ?? " ");

if (numero >= 18)
{
    Console.WriteLine("El numero es mayor o igual a 18");
}
else
{
    Console.WriteLine("El numero es menor a 18");
}

//Un char es ‘a’

Console.WriteLine("Introduce la letra a ");
string? letra = Console.ReadLine();

if (letra == "a")
{
    Console.WriteLine("La letra es igual 'a' un caracter char");
}
else
{
    Console.WriteLine("La letra o lo ingresado no es igual a letra 'a'");
}

//Se cumplen dos condiciones a la vez (ambas verdaderas)

Console.WriteLine("Introduce dos condiciones para cocer un huevo");
string? condicion1 = Console.ReadLine();
string? condicion2 = Console.ReadLine();

if (condicion1 == "agua" && condicion2 == "fuego")
{
    Console.WriteLine("Cumple con ambas condiciones para cocer un huevo");
}
else if (condicion1 == "fuego" && condicion2 == "agua")
{
    Console.WriteLine("Cumple con ambas condiciones para cocer un huevo");
}

else
{
    Console.WriteLine("No ha cumplido con las condiciones o una de ellas no coincide");
}
