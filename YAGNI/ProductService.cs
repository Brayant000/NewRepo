using System;

namespace YAGNI_Principle
{
    class ProductService
    {
        static void Main()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                decimal price = decimal.Parse(Console.ReadLine());
                AddProduct(name, price);
            }
            else if (option == 2)
            {
                Console.Write("Ingrese el ID del producto a eliminar: ");
                int productId = int.Parse(Console.ReadLine());
                DeleteProduct(productId);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        static void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto '{name}' agregado con éxito a un precio de {price:C}.");
        }

        static void DeleteProduct(int productId)
        {
            Console.WriteLine($"Producto con ID {productId} eliminado.");
        }
    }
}
