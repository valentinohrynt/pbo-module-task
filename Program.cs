using System;
// VALENTINO HARIYANTO 222410101023
namespace Bebas
{
    class Processor
    {
        public string merk, tipe;

        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
        public override string ToString()
        {
            return $"{merk} {tipe}";
        }

        internal class Intel : Processor
        {
            public Intel(string tipe) : base("Intel", tipe) { }
        }

        internal class Corei3 : Intel
        {
            public Corei3() : base("Core i3") { }
        }

        internal class Corei5 : Intel
        {
            public Corei5() : base("Core i5") { }
        }

        internal class Corei7 : Intel
        {
            public Corei7() : base("Core i7") { }
        }

        internal class AMD : Processor
        {
            public AMD(string tipe) : base("AMD", tipe) { }
        }

        internal class Ryzen : AMD
        {
            public Ryzen() : base("RYZEN") { }
        }

        internal class Athlon : AMD
        {
            public Athlon() : base("ATHLON") { }
        }
    }

    class Vga
    {
        public string merk;

        public Vga(string merk)
        {
            this.merk = merk;
        }
        public override string ToString()
        {
            return merk;
        }

        internal class Nvidia : Vga
        {
            public Nvidia() : base("Nvidia") { }
        }

        internal class AMD : Vga
        {
            public AMD() : base("AMD") { }
        }
    }

    class Laptop
    {
        public string merk, tipe;
        public Vga Vga;
        public Processor Processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            Vga = vga;
            Processor = processor;
        }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
        public void SpesifikasiLaptop()
        {
            Console.WriteLine($"Spesifikasi laptop \n Merk: {this.merk} \n Tipe: {this.tipe} \n VGA: {Vga} \n Merk Processor: {Processor.merk} \n Tipe Processor: {Processor.tipe}");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor) { }
    }

    class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor) { }
    }

    class Vivobook : ASUS
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor) { }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor) { }
    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor) { }
    }

    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor) { }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class LENOVO : Laptop
    {
        public LENOVO(string merk, string tipe, Vga vga, Processor processor) : base("LENOVO", tipe, vga, processor) { }
    }

    class Ideapad : ASUS
    {
        public Ideapad(Vga vga, Processor processor) : base("Ideapad", vga, processor) { }
    }

    class Legion : ASUS
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor) { }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1, laptop2;
            Predator predator;

            laptop1 = new Vivobook(new Vga.Nvidia(), new Processor.Corei5());
            laptop2 = new Ideapad(new Vga.AMD(), new Processor.Ryzen());
            predator = new Predator(new Vga.AMD(), new Processor.Corei7());

            // Soal 1: Jalankan method LaptopDinyalakan() dan LaptopDimatikan() pada laptop2. Apa yang terjadi? Mengapa begitu?
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            // Soal 2: Jalankan method Ngoding() pada laptop1. Apa yang terjadi? Mengapa begitu?
            laptop1.Ngoding();

            ((Vivobook)laptop1).Ngoding();

            // Soal 3: Dapatkah Anda menampilkan di console spesifikasi (merk vga, merk processor, tipe processor) apa yang digunakan laptop1? Bagaimana caranya?
            laptop1.SpesifikasiLaptop();

            // Soal 4: Jalankan method BermainGame() pada predator. Apa yang terjadi? Mengapa begitu?
            predator.BermainGame();

            // Soal 5: Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek Predator sebagai nilainya. Jalankan method BermainGame() pada acer. Apa yang terjadi? Mengapa begitu?
            ACER acer = new Predator(new Vga.Nvidia(), new Processor.Ryzen());
            acer.BermainGame();

            if (acer is Predator acer1)
            {
                acer1.BermainGame();
            }

        }
    } 
}
