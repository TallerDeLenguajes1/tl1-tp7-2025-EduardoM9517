using miCalculadora;

bool salir = false;
Console.WriteLine("----------Mi Calculadora---------");
do
{
    int opcion;
    Console.WriteLine("1. Realizar Suma");
    Console.WriteLine("2. Realizar Resta");
    Console.WriteLine("3. Realizar Multiplicacion");
    Console.WriteLine("4. Realizar Division");
    Console.WriteLine("5. Limpiar");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());
    var calculadora = new Calculadora(0);
    
    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el numero a sumar: ");
            double numeroSuma = double.Parse(Console.ReadLine());
            calculadora.Sumar(numeroSuma);
            Console.WriteLine($"Resultado: {calculadora.Resultado()}");
            break;
        case 2:
            Console.Write("Ingrese el numero a restar: ");
            double numeroResta = double.Parse(Console.ReadLine());
            calculadora.Restar(numeroResta);
            Console.WriteLine($"Resultado: {calculadora.Resultado()}");
            break;
        case 3:
            Console.Write("Ingrese el numero a multiplicar: ");
            double numeromultipli = double.Parse(Console.ReadLine());
            calculadora.Multiplicar(numeromultipli);
            Console.WriteLine($"Resultado: {calculadora.Resultado()}");
            break;
        case 4:
            Console.Write("Ingrese el numero a dividir: ");
            double numeroDividir = double.Parse(Console.ReadLine());
            if (numeroDividir != 0)
            {
                calculadora.Dividir(numeroDividir);
                Console.WriteLine($"Resultado: {calculadora.Resultado()}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            break;
        case 5:
            calculadora.Limpiar();
            Console.WriteLine("Calculadora limpiada");
            break;
    }
    if (opcion < 1 || opcion > 6)
    {
        Console.WriteLine("Opcion no valida, por favor intente de nuevo");
        salir = true;
    }
    else
    {
        Console.WriteLine("¿Desea realizar otra operacion? (s/n)");
        string respuesta = Console.ReadLine().ToLower();
        salir = respuesta == "s" || respuesta == "si";
        if (!salir)
        {
            Console.WriteLine("Saliedo de la calculadora...");
        }
        else
        {
            Console.WriteLine("Continuando con la calculadora...");
        }
    }
} while (salir);