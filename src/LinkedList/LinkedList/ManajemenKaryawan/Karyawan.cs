using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.ManajemenKaryawan
{
    public class Karyawan
    {
        public string NomorKaryawan;
        public string Nama;
        public string Posisi;

        public Karyawan(string nomorKaryawan, string nama, string posisi)
        {
            NomorKaryawan = nomorKaryawan;
            Nama = nama;
            Posisi = posisi;
        }
    }
    public class KaryawanNode
    {
        public Karyawan Karyawan;
        public KaryawanNode Next;
        public KaryawanNode Prev;

        public KaryawanNode(Karyawan Karyawan)
        {
            this.Karyawan = Karyawan;
            Next = null;
            Prev = null;
        }
    }

    public class DaftarKaryawan
    {
        private KaryawanNode head;
        private KaryawanNode tail;
        public DaftarKaryawan()
        {
            head = null;
            tail = null;
        }

        // methods

        public void TambahKaryawan(Karyawan karyawan)
        {
            KaryawanNode newNode = new(karyawan);

            newNode.Next = null;
            newNode.Prev = tail;

            if (tail != null)
            {
                tail.Next = newNode;
            }

            tail = newNode;

            if (head == null)
            {
                head = newNode;
            }
        }

        public bool HapusKaryawan(string nomorKaryawan)
        {
            KaryawanNode current = head;
            if (head == null)
            {
                return false;
            }

            while (current != null && current.Karyawan.NomorKaryawan != nomorKaryawan)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return false;
            }

            if (current == head)        // di head
            {
                head = current.Next;
            }

            if (current.Prev != null)
            {
                current.Prev.Next = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Prev = current.Prev;
            }

            if (current == tail)   // di tail
            {
                tail = current.Prev;
            }

            return true;
        }

        public Karyawan[] CariKaryawan(string kataKunci)
        {
            List<Karyawan> list = new();

            KaryawanNode current = head;
            while (current != null)
            {
                if (current.Karyawan.Nama.Contains(kataKunci) || current.Karyawan.Posisi.Contains(kataKunci))
                {
                    list.Add(current.Karyawan);
                }
                current = current.Next;
            }
            return list.ToArray();
        }

        public string TampilkanDaftar()
        {
            StringBuilder sb = new();
            KaryawanNode current = tail;

            while (current != null)
            {
                sb.AppendLine($"{current.Karyawan.NomorKaryawan}; {current.Karyawan.Nama}; {current.Karyawan.Posisi}");
                current = current.Prev;
            }
            return sb.ToString().TrimEnd();
        }
    }
}
