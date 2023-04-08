// See https://aka.ms/new-console-template for more information

const Double PRECIO = 0.45;

Double resta = 0;
Int16[] cambioCont = {0, 0, 0, 0, 0, 0};
bool salir = false;

Console.WriteLine("Introduzca pago: ");
resta = Convert.ToDouble(Console.ReadLine()) - PRECIO;

Console.WriteLine("Total a devolver : " + resta);

while (!salir) {
    if (resta - 2 > 0)
    {
        cambioCont[^1] += 1;
        resta -= 2;
    }
    else if (resta - 1 > 0)
    {
        cambioCont[^2] += 1;
        resta -= 1;
    }
    else if (resta - 0.50 > 0)
    {
        cambioCont[^3] += 1;
        resta -= 0.50;
    }
    else if (resta - 0.20 > 0)
    {
        cambioCont[2] += 1;
        resta -= 0.20;
    }
    else if (resta - 0.10 > 0)
    {
        cambioCont[1] += 1;
        resta -= 0.10;
    }
    else if (resta - 0.05 > 0)
    {
        cambioCont[0] += 1;
        resta -= 0.05;
    }
    else {
        salir = true;
    }
}

for (int i = 0; i < cambioCont.Length; i++) {

    switch (i) {
        case 0:
            Console.WriteLine("Monedas de 2E -> " + cambioCont[^1]);
            break;
        case 1:
            Console.WriteLine("Monedas de 1E -> " + cambioCont[^2]);
            break;
        case 2:
            Console.WriteLine("Monedas de 0.50E -> " + cambioCont[^3]);
            break;
        case 3:
            Console.WriteLine("Monedas de 0.20E -> " + cambioCont[2]);
            break;
        case 4:
            Console.WriteLine("Monedas de 0.10E -> " + cambioCont[1]);
            break;
        case 5:
            Console.WriteLine("Monedas de 0.05E -> " + cambioCont[0]);
            break;
    }

}

