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
        List<Product> Products { get; set; } = new List<Product>();

        public Client()
        {

        }

        public Client(string nome, double card, double money)
        {
            Nome = nome;
            Card = card;
            Money = money;
        }

        public void addProduct(Product product) {

            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {

            Products.Remove(product);
        }
    }
}
