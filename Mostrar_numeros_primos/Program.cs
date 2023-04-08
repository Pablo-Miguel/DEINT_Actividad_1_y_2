// See https://aka.ms/new-console-template for more information

const int NUM_PRIMOS = 5;
int cont = 0, index = 0;

for (int i = 2; index < NUM_PRIMOS; i++) {
    for ( int j = i; j >= 1; j-- ) {

        if ( i % j == 0 ) {
            cont++;
        }

    }

    if (cont == 2) {

        Console.WriteLine(i + "\n");
        index++;

    }

    cont = 0;
}