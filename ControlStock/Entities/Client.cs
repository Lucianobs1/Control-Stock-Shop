using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStock.Entities
{
    class Client
    {
        public string Nome { get; set; }
        public double Card { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Client()
        {

        }

        public Client(string nome, double card)
        {
            Nome = nome;
            Card = card;
        }


        public Client(string nome, double card, double money)
        {
            Nome = nome;
            Card = card;
            Money = money;
        }


        public void addProduct(Product product)
        {

            Products.Add(product);

        }

        public void RemoveProduct(Product product)
        {

            Products.Remove(product);

        }

        public Boolean ClientPayment(double Saldo)
        {

            foreach (Product ItensPurchase in Products)
            {
                if (Saldo >= ItensPurchase.AmountInStock())
                {
                    Console.WriteLine("Payment Approved");
                    return true;
                }
            }
            Console.WriteLine("Payment Repproved");

           return false;
        }
    }
}
