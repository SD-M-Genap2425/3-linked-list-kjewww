using LinkedList.Inventori;
using LinkedList.ManajemenKaryawan;
using LinkedList.Perpustakaan;

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan

        Buku buku1 = new("Harry Potter 1", "J.K. Rowling", 1997);
        Buku buku2 = new("Harry Potter 2", "J.K. Rowling", 1998);
        Buku buku3 = new("Harry Potter 3", "J.K. Rowling", 1999);

        KoleksiPerpustakaan list = new KoleksiPerpustakaan();

        list.TambahBuku(buku1);
        list.TambahBuku(buku2);
        list.TambahBuku(buku3);

        Console.WriteLine(list.TampilkanKoleksi());

        // Soal ManajemenKaryawan

        Karyawan karyawan1 = new("001", "John Doe", "Manager");
        Karyawan karyawan2 = new("002", "Jane Doe", "HR");
        Karyawan karyawan3 = new("003", "Bob Smith", "IT");

        DaftarKaryawan listK = new DaftarKaryawan();

        listK.TambahKaryawan(karyawan1);
        listK.TambahKaryawan(karyawan2);
        listK.TambahKaryawan(karyawan3);

        Console.WriteLine(listK.TampilkanDaftar());

        // Soal Inventori

        Item item1 = new("Apple", 50);
        Item item2 = new("Orange", 30);
        Item item3 = new("Banana", 20);

        ManajemenInventori inventori = new();

        inventori.TambahItem(item1);
        inventori.TambahItem(item2);
        inventori.TambahItem(item3);

        Console.WriteLine(inventori.TampilkanInventori());
    }
}
