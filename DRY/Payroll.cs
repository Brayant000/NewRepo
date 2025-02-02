using System;

namespace DRY_Principle
{
    class Payroll
    {
        static void Main()
        {
            Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
            int employeeType = int.Parse(Console.ReadLine());

            decimal salary;
            if (employeeType == 1)
            {
                Console.Write("Ingrese el salario base: ");
                salary = decimal.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Ingrese el sueldo por hora: ");
                decimal hourlyRate = decimal.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas: ");
                int hoursWorked = int.Parse(Console.ReadLine());
                salary = hourlyRate * hoursWorked;
            }

            decimal netSalary = CalculateNetSalary(salary);
            Console.WriteLine($"Salario neto después de impuestos y bono: {netSalary:C}");
        }

        static decimal CalculateNetSalary(decimal baseSalary)
        {
            decimal tax = baseSalary * 0.18m;
            decimal bonus = baseSalary * 0.05m;
            return baseSalary - tax + bonus;
        }
    }
}
