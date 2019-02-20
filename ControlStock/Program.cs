using ControlStock.Entities;
using System;

namespace ControlStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==================== CASAS BAHIA ====================");
            Console.Write("Which product do you want ?  ");
            string nameProduct = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Quantity: ");
            int Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Preace: ");
            double Preace = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Product p = new Product(nameProduct,Quantity,Preace);

            Console.Write("Cliente: ");
            string NomeClient = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter you Balance: ");
            double Balance = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(NomeClient, Balance);
            client.addProduct(p);

            Console.Write(client.ClientPayment(Balance));

            
            Console.ReadKey();

          
        }
    }
}
