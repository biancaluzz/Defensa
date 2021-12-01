using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }

        public string AsText()
        {
            List<string> result = new List<string>(); 
            result.Add($"Fecha: {this.EndDate}\n");
            foreach (PublicationItem item in items)
            {
                result.Add($"{item.Quantity} de {item.Material} a {item.Price}\n");
            }

            return result.ToString();
        }

    }
}