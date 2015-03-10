using System.Collections.Generic;
using System.Linq;
using AStore.Data;

namespace AStore.Core.Concrete
{
    public class Cart
    {
        private List<CartLine> _lineCollection = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            var currentItem = _lineCollection.FirstOrDefault(x => x.Product.Id == product.Id);
            if (currentItem != null)
            {
                currentItem.Quantity += quantity;
            }
            else
            {
                _lineCollection.Add(new CartLine
                {
                    Product = product, 
                    Quantity = quantity
                });
            }
        }

        public void Clear()
        {
            _lineCollection.Clear();
        }

        public void RemoveProduct(Product product, int quantity = -1)
        {
            var currentItem = _lineCollection.FirstOrDefault(x => x.Product.Id == product.Id);
            if (currentItem != null)
            {
                // remove all
                if (quantity == -1 || quantity > currentItem.Quantity)
                {
                    _lineCollection.Remove(currentItem);
                }
                else
                {
                    currentItem.Quantity -= quantity;
                }
            }
        }

        public IEnumerable<CartLine> Lines
        {
            get { return _lineCollection; }
        }

        public decimal? ComputeTotalValue()
        {
            return _lineCollection.Sum(x => x.Product.Price*x.Quantity);
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
