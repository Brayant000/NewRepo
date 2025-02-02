using System;
using System.Linq;

namespace KISS_Principle
{
    class RestaurantBill
    {
        static void Main()
        {
            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            decimal[] prices = Console.ReadLine()
                .Split(',')
                .Select(decimal.Parse)
                .ToArray();

            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            bool customTip = Console.ReadLine().Trim().ToLower() == "s";
            decimal tipPercentage = customTip ? GetCustomTip() : 10;

            decimal total = CalculateTotal(prices, tipPercentage);
            Console.WriteLine($"Total a pagar (con propina del {tipPercentage}%): {total:C}");
        }

        static decimal GetCustomTip()
        {
            Console.Write("Ingrese el porcentaje de propina: ");
            return decimal.Parse(Console.ReadLine());
        }

        static decimal CalculateTotal(decimal[] prices, decimal tipPercentage)
        {
            decimal subtotal = prices.Sum();
            return subtotal + (subtotal * tipPercentage / 100);
        }
    }
}
