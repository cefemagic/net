// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Ingresa tu fecha de nacimiento en formato ddMMyyyy:");
string? fechaInput = Console.ReadLine();

if (DateTime.TryParseExact(fechaInput, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
{
    DateTime hoy = DateTime.Today;
    int edad = hoy.Year - fechaNacimiento.Year;

    if (fechaNacimiento > hoy.AddYears(-edad))
    {
        edad--;
    }

    Console.WriteLine($"Tu tienes: {edad} años de edad");
}
else
{
    Console.WriteLine("Formato de fecha incorrecto. Por favor, usa ddMMyyyy...");
}
