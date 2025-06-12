// See https://aka.ms/new-console-template for more information


Console.WriteLine("¿Cuántas preguntas deseas hacer?");
if (int.TryParse(Console.ReadLine(), out int nPreguntas) && nPreguntas > 0)
{
    for (int i = 1; i <= nPreguntas; i++)
    {
        Console.WriteLine($"[{i}] Introduce tu fecha de nacimiento en formato ddMMyyyy:");
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
    }
}
else
{
    Console.WriteLine("Número de preguntas no válido.");
}

Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
