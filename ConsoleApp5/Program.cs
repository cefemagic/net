// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Introduce tu fecha de nacimiento en formato ddMMyyyy:");
string? fechaInput = Console.ReadLine();

if (DateTime.TryParseExact(fechaInput, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
{
    DateTime hoy = DateTime.Today;
    int edad = hoy.Year - fechaNacimiento.Year;

    if (fechaNacimiento > hoy.AddYears(-edad))
    {
        edad--;
    }

    Console.WriteLine($"Tu edad es: {edad} años");
}
else
{
    Console.WriteLine("Formato de fecha incorrecto. Por favor, usa ddMMyyyy...");
}
=======
    Console.WriteLine($"Introduce tu fecha de nacimiento en formato ddMMyyyy:");
    string? fechaInput = Console.ReadLine();

    if (DateTime.TryParseExact(fechaInput, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento.Year;

        if (fechaNacimiento > hoy.AddYears(-edad))
        {
            edad--;
        }

        Console.WriteLine($"Tu edad es: {edad} años");
    }
    else
    {
        Console.WriteLine("Formato de fecha incorrecto. Por favor, usa ddMMyyyy.");
    }

>>>>>>> 391027465a1640741fad35a0c902d61e0c8277ae


Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
