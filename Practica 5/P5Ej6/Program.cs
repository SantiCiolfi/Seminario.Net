using P5Ej6;

// Crear una matriz
double[,] datos = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Matriz matriz = new Matriz(datos);

// Acceder a la diagonal principal
double[] diagonalPrincipal = matriz.DiagonalPrincipal;
Console.WriteLine("Diagonal Principal:");
ImprimirVector(diagonalPrincipal);

// Acceder a la diagonal secundaria
double[] diagonalSecundaria = matriz.DiagonalSecundaria;
Console.WriteLine("\nDiagonal Secundaria:");
ImprimirVector(diagonalSecundaria);

// Acceder a un elemento utilizando el indizador
Console.WriteLine("\nElemento en la posición (1, 1): " + matriz[1, 1]);

static void ImprimirVector(double[] vector)
{
    foreach (double elemento in vector)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}