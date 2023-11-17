// Ejemplo de condicional if

Console.WriteLine("Ingrese su edad: "); //Le pedimos al usario que ingrese su edad
int edad = int.Parse(Console.ReadLine());//Obtenemos la edad por teclado

Console.WriteLine("La edad ingresada es: " + edad);

Console.WriteLine("Ingrese su equipo de futbol: ");
string equipo = Console.ReadLine();

if (edad < 18 && equipo == "river") //Evaluamos la edad
{
    //esta instruccion solo se ejecuta si la edad ingresada es menor a 18
    Console.WriteLine("Usted es menor de edad.");
    Console.WriteLine("Tiene prohibida la entrada.");
}
else
{
    Console.WriteLine("Usted es mayor de edad.");
}