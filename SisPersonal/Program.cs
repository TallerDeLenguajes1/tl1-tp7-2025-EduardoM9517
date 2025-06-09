using losEmpleados;

//Cargue los datos para 3 empleados en un arreglo de tipo empleados
Empleado[] empleados = new Empleado[3] {
    new Empleado("Jorge", "Rojas", new DateTime(1985, 5, 15), 'C', new DateTime(2010, 3, 1), 50000, Empleado.Cargo.ingeniero),
    new Empleado("Luciana", "Martinez", new DateTime(1990, 8, 20), 'S', new DateTime(2015, 6, 15), 65000, Empleado.Cargo.especialista),
    new Empleado("Carlos", "Oro", new DateTime(1978, 11, 30), 'C', new DateTime(2005, 1, 10), 78500, Empleado.Cargo.administrativo)
};

double totalSueldo = 0;
int antiguedad = 0;
int indiceEmpleado = 0;

for (int i = 0; i < 3; i++)
{
    int aux = 0;
    antiguedad = empleados[i].CalcularAntiguedad(empleados[i].fechaIngresoEmpresa);
    if (antiguedad > aux)
    {
        indiceEmpleado = i;
    }
    aux = antiguedad;
    totalSueldo += empleados[i].sueldoBasico;
}

int edadEmpleado = empleados[indiceEmpleado].CalcularEdad(empleados[indiceEmpleado].fechaNacimiento);
antiguedad = empleados[indiceEmpleado].CalcularAntiguedad(empleados[indiceEmpleado].fechaIngresoEmpresa);
double salario = empleados[indiceEmpleado].calcularSalarioEmpleado(empleados[indiceEmpleado].sueldoBasico, antiguedad, empleados[indiceEmpleado].cargos, empleados[indiceEmpleado].estadoCivil);
int edadParaJubilarse = empleados[indiceEmpleado].CalcularEdadParaJubilarse(empleados[indiceEmpleado].fechaNacimiento);

//Muestre por pantalla los datos del empleado que esté más próximo a jubilarse
Console.WriteLine("Datos del empleado mas proximo a jubilarse:");
Console.WriteLine($"Nombre: {empleados[indiceEmpleado].nombre}");
Console.WriteLine($"Apellido: {empleados[indiceEmpleado].apellido}");
Console.WriteLine($"Fecha de Nacimiento: {empleados[indiceEmpleado].fechaNacimiento.ToShortDateString()}");
Console.WriteLine($"Estado Civil: {empleados[indiceEmpleado].estadoCivil}");
Console.WriteLine($"Fecha de ingreso a la empresa: {empleados[indiceEmpleado].fechaIngresoEmpresa.ToShortDateString()}");
Console.WriteLine($"Sueldo Basico: ${empleados[indiceEmpleado].sueldoBasico}");
Console.WriteLine($"Cargo: {empleados[indiceEmpleado].cargos}");
Console.WriteLine($"Edad: {edadEmpleado} años");
Console.WriteLine($"Antiguedad: {antiguedad} años");
Console.WriteLine($"Salario Total: ${salario}");
Console.WriteLine($"Años para jubilarse: {edadParaJubilarse} años");

Console.WriteLine($"El sueldo total de los empleados es: ${totalSueldo}");