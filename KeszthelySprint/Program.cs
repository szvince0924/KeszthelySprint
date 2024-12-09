namespace KeszthelySprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new();

            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new Versenyzo (sor));
            }

            Console.WriteLine($"A versenyt {versenyzok.Count}versenyzo fejezte be");





            int junior = 0;
            foreach (var v in versenyzok)
            {
                if (v.kategoria=="elit junior")
                {
                    junior++;
                }

            }
            Console.WriteLine($"3.feladat:versenyzok szama az elit junior kategoriaba:{junior}fő");


            //4
            int össz_életkor = 0;
            foreach (var v in versenyzok)
            {
                össz_életkor += DateTime.Now.Year - v.szuletesi_ev;
            }
            Console.WriteLine(&"")
        }
        
    }
}
