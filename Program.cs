// See https://aka.ms/new-console-template for more information
Console.WriteLine("Series");
Console.WriteLine();

{
    string[] nombresPeliculas = new string[10];
    string[] categoriasPeliculas = new string[10];

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ingrese el nombre de la película " + (i + 1) + ":");
        nombresPeliculas[i] = Console.ReadLine();

        Console.WriteLine("Ingrese la categoría de la película " + (i + 1) + ":");
        categoriasPeliculas[i] = Console.ReadLine();
    }

    Console.WriteLine("\nDatos de las películas:");

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Película: " + nombresPeliculas[i] + ", Categoría: " + categoriasPeliculas[i]);
    }
}
