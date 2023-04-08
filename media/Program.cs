// See https://aka.ms/new-console-template for more information

const int NUM_MEDIA = 4;

Decimal suma = 0, media = 0;

for (int i = 0; i < NUM_MEDIA; i++) {
    Console.WriteLine("Introduzca el valor de la " + (i + 1) + " nota: ");
    suma += Convert.ToDecimal(Console.ReadLine());
}

media = suma / NUM_MEDIA;

Console.WriteLine("La media de las " + NUM_MEDIA + " notas es -> " + media);
