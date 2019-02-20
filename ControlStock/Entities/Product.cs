using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStock.Entities
{
    class Product
    {
        public string Name { get; set; }
        public int QtyStock { get; set; }
        public double Value { get; set; }

        public Product()
        {

        }

        public Product(string name, int qtyStock, double value)
        {
            Name = name;
            QtyStock = qtyStock;
            Value = value;
        }

        public double AmountInStock()
        {

            return QtyStock * Value;
        }

        public void AddProduct(int Quantity)
        {

            QtyStock += Quantity;
        }

        public void RemoveProduct(int Quantity)
        {

            QtyStock -= Quantity;
        }
    }
}
