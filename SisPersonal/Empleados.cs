namespace losEmpleados;

public class Empleado
{
    public string nombre;
    public string apellido;
    public DateTime fechaNacimiento;
    public char estadoCivil;
    public DateTime fechaIngresoEmpresa;
    public double sueldoBasico;
    public enum Cargo
    {
        auxiliar,
        administrativo,
        ingeniero,
        especialista,
        investigador
    }
    public Cargo cargos;

    //calcular antiguedad del empleado
    public int CalcularAntiguedad(DateTime fechaIngreso)
    {
        DateTime fechaActual = DateTime.Now;
        int antiguedad = fechaActual.Year - fechaIngreso.Year;
        if (fechaActual.Month < fechaIngreso.Month || (fechaActual.Month == fechaIngreso.Month && fechaActual.Day < fechaIngreso.Day))
        {
            antiguedad--;
        }
        return antiguedad;
    }

    //calcular edad del empleado
    public int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;
        if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
        {
            edad--;
        }
        return edad;
    }

    //cuanto le falta para jubilarse, teniendo en cunenta que se jubila a los 65 años
    public int CalcularEdadParaJubilarse(DateTime fechaNacimiento)
    {
        int edad = CalcularEdad(fechaNacimiento);
        int edadParaJubilarse = 65;
        if (edad >= edadParaJubilarse)
        {
            return 0;
        }
        else
        {
            return edadParaJubilarse - edad;
        }
    }

    //calcular salario teniendo la formula salario = sueldo basico + adicional del empleado, Para ello el Adicional contempla la antigüedad en años, el cargo y si es casado:
    //i) 1 % del sueldo básico por cada año de antigüedad hasta los 20 años, a partir de este, el porcentaje se fija en 25%
    //ii) Si el cargo es Ingeniero o Especialista, el Adicional se incrementa en un 50%
    //iii) Si es casado al Adicional se le aumenta $150.000
    public double calcularSalarioEmpleado(double sueldoBasico, int antiguedad, Cargo cargo, char estadoCivil)
    {
        double adicional = 0;
        //calcular adicional por antiguedad
        if (antiguedad <= 20)
        {
            adicional += sueldoBasico * (antiguedad / 100.0);
        }
        else
        {
            adicional += sueldoBasico * 0.25;
        }
        //calcular adicional por cargo
        if (cargo == Cargo.ingeniero || cargo == Cargo.especialista)
        {
            adicional += sueldoBasico * 0.5;
        }
        //calcular adicional por estado civil
        if (estadoCivil == 'C' || estadoCivil == 'c')
        {
            adicional += 150000;
        }
        //calcular salario total
        double salarioTotal = sueldoBasico + adicional;
        return salarioTotal;
    }
    
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngresoEmpresa, double sueldoBasico, Cargo cargos)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaIngresoEmpresa = fechaIngresoEmpresa;
        this.sueldoBasico = sueldoBasico;
        this.cargos = cargos;
    }
}