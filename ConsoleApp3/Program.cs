using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Клону который может:");
            Clown clow = new Clown(new Deistvie());
            clow.Datcomjiv();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Клону который может:");
 
            clow.Vypolnittruk();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Клону который может:");
            clow.Rassmewit();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Акробат который может:");
            Acrobat acro = new Acrobat(new Deistvie());
            acro.Rassmewit();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Дрессировшщик который может:");
            Dresirovshik dre = new Dresirovshik(new Deistvie());
            dre.Rassmewit();

            Console.ReadLine();
        }
    }
    interface Vystupat
    {

        public void Vypolnittruk();
        public void Datcomjiv();
        public void Rassmewit();
    }




    class Deistvie : Vystupat
    {
        public void Rassmewit()
        {
            Console.WriteLine("рассмешить");
        }
        public void Vypolnittruk() {
            Console.WriteLine("выполнить трюк ");
        }

        public void Datcomjiv() {

            Console.WriteLine("дать команду животному");
        }
    }

    class Clown
    {
        public Clown(Vystupat deist)
        {
            Deistt = deist;
        }
        public Vystupat Deistt { private get; set; }
        public void Rassmewit()
        {
            Deistt.Rassmewit();
            Deistt.Vypolnittruk();
            Deistt.Datcomjiv();
        }
        public void Vypolnittruk() {
            Deistt.Rassmewit();
            Deistt.Vypolnittruk();
       
        }
        public void Datcomjiv()
        {
            Deistt.Rassmewit();
        }

    }
    class Acrobat
    {
        public Acrobat(Vystupat deist)
        {
            Deistt = deist;
        }
        public Vystupat Deistt { private get; set; }
        public void Rassmewit()
        {
            Deistt.Vypolnittruk();
        }

    }

    class Dresirovshik
    {
        public Dresirovshik(Vystupat deist)
        {
            Deistt = deist;
        }
        public Vystupat Deistt { private get; set; }
        public void Rassmewit()
        {
            Deistt.Datcomjiv();
        }

    }

}
