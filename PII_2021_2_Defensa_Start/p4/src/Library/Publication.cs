using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication : IPublicationItem
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<IPublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<IPublicationItem>(this.items);
            }
        }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (IPublicationItem item in this.items)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        private IList<IPublicationItem> items = new List<IPublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public IPublicationItem AddItem(Material material, int quantity, int price)
        {
            this.items.Add(Item);
            return Item;
        }

        public void RemoveItem(IPublicationItem item)
        {
            this.items.Remove(item);
        }
    }
}