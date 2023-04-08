// See https://aka.ms/new-console-template for more information

Int16? numUsu = null;

Console.WriteLine("Introduzca un número entero ");
numUsu = Convert.ToInt16(Console.ReadLine());

if (numUsu == null)
{
    Console.WriteLine("Porfavor introduzca un valor válido");
}
else {
    Console.WriteLine("Has introducido el siguiente número: " + numUsu);
}