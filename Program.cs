using System;

class Hewan
{
    public string Nama;
    public int Umur;
    public Hewan(string Nama, int Umur)
    {
        this.Nama = Nama;
        this.Umur = Umur;
    }
    public virtual string Suara()
    {
        return ("Hewan ini bersuara");
    }
    public virtual string InfoHewan()
    {
        return ($"Nama : {Nama}, Umur : {Umur} tahun");
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;
    public Mamalia(string Nama, int Umur, int jumlahKaki) :base(Nama, Umur)
    {
        this.jumlahKaki = jumlahKaki;
    }
    public override string Suara()
    {
        return base.Suara();
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {jumlahKaki}";
    }
}

class Reptil : Hewan
{
    public int panjangTubuh;
    public Reptil(string Nama, int Umur, int panjangTubuh) : base(Nama, Umur)
    {
        this.panjangTubuh = panjangTubuh;
    }
    public override string Suara()
    {
        return base.Suara();
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang tubuh: {panjangTubuh} cm";
    }
}

class Singa : Mamalia
{
    public Singa(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, 4) { }
    public override string Suara()
    {
        return base.Suara();
    }
    public void Mengaum()
    {
        Console.WriteLine("Suara singa Rawrrr!!!!");
    }
}
class Gajah : Mamalia
{
    public Gajah(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, 4) { }
    public override string Suara()
    {
        return "Gajah mengeluarkan suara seperti terompet";
    }
}
class Ular : Reptil
{
    public Ular(string Nama, int Umur, int panjangTubuh) : base(Nama, Umur, 100) { }
    public override string Suara()
    {
        return "Ular mengeluarkan suara mendesis";
    }
    public void Merayap()
    {
        Console.WriteLine("Ular ini merayap di sawah");
    }
}

class Buaya : Reptil
{
    public Buaya(string Nama, int Umur, int panjangTubuh) : base (Nama, Umur, 150) { }
    public override string Suara()
    {
        return "Buaya bersuara, kamu kenapa? sini cerita";
    }
}

class KebunBinatang
{
    private List<Hewan> koleksi = new List<Hewan>();

    public void TambahKoleksi(Hewan hewan)
    {
        koleksi.Add(hewan);
    }

    public void DaftarKoleksi()
    {
        Console.WriteLine("Daftar hewan di Zoo :");
        foreach (var hewan in koleksi)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang zoo = new KebunBinatang();
        Singa singa = new Singa("Singa Maung", 10, 4);
        Gajah gajah = new Gajah("Gajah Thailand", 12, 4);
        Ular ular = new Ular("Ular Daun", 10, 100);
        Buaya buaya = new Buaya("Buaya Darat", 10, 150);
        Reptil reptil = new Buaya("Buaya Asin", 15, 120);
        Console.WriteLine(reptil.Suara());


        zoo.TambahKoleksi(singa);
        zoo.TambahKoleksi(gajah);
        zoo.TambahKoleksi(ular);
        zoo.TambahKoleksi(buaya);

        zoo.DaftarKoleksi();

        Console.WriteLine("\nSuara hewan - hewan :");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\nSuara khusus :");
        singa.Mengaum();
        ular.Merayap();
    }
}