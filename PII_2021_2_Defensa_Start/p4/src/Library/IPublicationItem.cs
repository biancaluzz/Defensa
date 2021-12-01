using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public interface IPublicationItem
    {
        public IReadOnlyCollection<IPublicationItem> Items { get; set; }

        public PublicationItem AddItem(Material material, int quantity, int price)
        {
            PublicationItem item = new PublicationItem(material, quantity, price);
        }

        public void RemoveItem(PublicationItem item)
        {
           
        }

    }
}