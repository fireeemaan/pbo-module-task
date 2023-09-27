using System;

namespace PBO_1074_M1
{
    class Processor
    {
        public string merk;
        public string tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core I3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core I5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7() 
        {
            tipe = "Core I7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "Ryzen";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "Athlon";
        }
    }

    class VGA
    {
        public string merk;
    }

    class Nvidia : VGA
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }

    class Amd : VGA
    {
        public Amd()
        {
            merk = "AMD";
        }
    }
    
    class Laptop
    {
        public string merk;
        public string tipe;
        public string vga;
        public string processor;

        public Laptop(VGA vga, Processor processor)
        {
            this.vga = vga.merk;
            this.processor = $"{processor.merk} {processor.tipe}";
        }
        
        public void LaptopDinyalakan()
        {
            Console.Out.WriteLine($"Laptop {merk} {tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.Out.WriteLine($"Laptop {merk} {tipe} mati");
        }

        public void SpillSpek()
        {
            Console.Out.WriteLine($"Spesifikasi : \n" +
                                  $"Merk : {merk}\n" +
                                  $"Tipe : {tipe}\n" +
                                  $"VGA : {vga}\n" +
                                  $"Processor : {processor}\n");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(VGA vga, Processor processor) : base(vga, processor)
        {
            merk = "ASUS";
        }
    }
    
    class ACER : Laptop
    {
        public ACER(VGA vga, Processor processor) : base(vga, processor)
        {
            merk = "ACER";
        }
    }
    
    class Lenovo : Laptop
    {
        public Lenovo(VGA vga, Processor processor) : base(vga, processor)
        {
            merk = "Lenovo";
        }
    }

    class ROG : ASUS
    {
        public ROG(VGA vga, Processor processor) : base(vga, processor)
        {
            tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook(VGA vga, Processor processor) : base(vga, processor)
        {
            tipe = "Vivobook";
        }

        public void Ngoding()
        {
            Console.Out.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Swift : ACER
    {
        public Swift(VGA vga, Processor processor) : base(vga, processor)
        {
            tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator(VGA vga, Processor processor) : base(vga, processor)
        {
            tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.Out.WriteLine($"Laptop {merk} {tipe} sedang memainkan game!");
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(VGA vga, Processor processor) : base(vga, processor)
        {
            tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion(VGA vga, Processor processor) : base(vga, processor)
        {
            tipe = "Legion";
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook(new Nvidia(), new CoreI5());
            Laptop laptop2 = new IdeaPad(new Amd(), new Ryzen());
            Predator predator = new Predator(new Amd(), new CoreI7());
            
            // Jalankan method LaptopDinyalakan() dan LaptopDimatikan() pada laptop2.
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            
            // Jalankan method Ngoding() pada laptop1.
            laptop1.Ngoding();
            
            // Tampilkan Spesifikasi dari Laptop 1
            laptop1.SpillSpek();
            
            // Jalankan method BermainGame() pada predator.
            predator.BermainGame();
            
            // Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek Predator sebagai nilainya. Jalankan method BermainGame() pada acer. 
            ACER acer = new Predator(new Amd(), new CoreI7());
            acer.BermainGame();
            
           

        }
    }


}

