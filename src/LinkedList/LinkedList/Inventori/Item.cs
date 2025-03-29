using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Inventori
{
    public class Item
    {
        public string Nama;
        public int Kuantitas;

        public Item(string nama, int kuantitas)
        {
            Nama = nama;
            Kuantitas = kuantitas;
        }
    }

    public class ManajemenInventori
    {
        private LinkedList<Item> Items = new();
        public void TambahItem (Item item)
        {
            Items.AddLast(item);
        }

        public bool HapusItem(string nama)
        {
            LinkedListNode<Item> current = Items.First;
            while (current != null)
            {
                if (current.Value.Nama == nama)
                {
                    Items.Remove(current);
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string TampilkanInventori()
        {
            StringBuilder sb = new StringBuilder();
            LinkedListNode<Item> current = Items.First;
            while (current != null)
            {
                sb.AppendLine($"{current.Value.Nama}; {current.Value.Kuantitas}");  
                current = current.Next;
            }
            return sb.ToString().TrimEnd();
        }
    }
}
