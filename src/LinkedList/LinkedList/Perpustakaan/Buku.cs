using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul;
        public string Penulis;
        public int Tahun;

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }

    public class BukuNode
    {
        public Buku Data;
        public BukuNode Next;

        public BukuNode(Buku data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class KoleksiPerpustakaan
    {
        private BukuNode head;

        public KoleksiPerpustakaan()
        {
            this.head = null;
        }

        // methods

        public void TambahBuku(Buku data)
        {
            BukuNode newNode = new BukuNode(data);
            newNode.Next = head;
            head = newNode;
        }

        public bool HapusBuku(string judul)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Data.Judul == judul)
            {
                head = head.Next;
                return true;
            }

            BukuNode current = head;
            while (current.Next != null && current.Next.Data.Judul != judul)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return false;
            }

            current.Next = current.Next.Next;
            return true;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> list = new List<Buku>();

            BukuNode current = head;
            while (current != null)
            {
                if (current.Data.Judul.Contains(kataKunci))
                {
                    list.Add(current.Data);
                }
                current = current.Next;
            }
            return list.ToArray();
        }

        public string TampilkanKoleksi()
        {
            StringBuilder sb = new StringBuilder();
            BukuNode current = head;

            while (current != null)
            {
                sb.AppendLine($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }
            return sb.ToString().TrimEnd();
        }
    }
}
