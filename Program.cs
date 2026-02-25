using System;
using System.Diagnostics;
// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;
int n = int.Parse(linea1);

// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO ---
// Instrucción: El alumno debe encontrar el valor máximo del arreglo 'numeros'

Stopwatch tiempo = Stopwatch.StartNew(); // 2. Inicias el cronómetro

// --- INICIO DE TU LÓGICA ---
int maximo = numeros[0];
for (int i = 1; i < n; i++)
{
    if (numeros[i] > maximo)
    {
        maximo = numeros[i];
    }
}
// --- FIN DE TU LÓGICA ---

tiempo.Stop(); // 3. Detienes el cronómetro

Console.WriteLine(maximo);
// 4. Imprimes el tiempo que tardó:
Console.WriteLine($"Tiempo de ejecución real: {tiempo.Elapsed.TotalMilliseconds} ms");