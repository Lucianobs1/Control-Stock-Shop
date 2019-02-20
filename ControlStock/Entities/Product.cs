using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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

        public void AddItem(int Quantity)
        {

            QtyStock += Quantity;
        }

        public void RemoveItem(int Quantity)
        {

            QtyStock -= Quantity;
        }

        public override string ToString()
        {
            return "\nName: "
                    + Name
                    + "\nQuantity: "
                    + QtyStock
                    + "\nPreace each: "
                    + Value.ToString("F2",CultureInfo.InvariantCulture)
                    + "\nTotal: "
                    + AmountInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
