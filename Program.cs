using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    internal class Program
    {
        static void feladat1()
        {
            Console.Write("Meddig akarja összeadni a számokat?  ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine(osszegzes(szam));
        }
        static void feladat2()
        {
            Console.Write("Kérek egy szöveget! ");
            string s = Console.ReadLine();
            Console.WriteLine($"Palindorm a szöveg? {Palindrom(s)}");
        }
        static void feladat3()
        {
            Console.Write("Kérek egy szöveget! ");
            string s = Console.ReadLine() ;
            Console.Write("Milyen karaktert szeretne megszámolni? ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{KarakterSzam(s,c)} db ilyen karakter van a szövegben");
        }
        static void feladat4()
        {
            Console.Write("kérem az első számot! ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("kérem az első számot! ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A legnagyobb közös osztójuk a {lnko(a,b)}");
        }
        static void feladat5()
        {
            Console.Write("Melyik számtól akarod kiiratni a szamokat? ");
            int n = int.Parse(Console.ReadLine());
            KiirVisszafele(n);
        }
        static void feladat6()
        {
            Console.Write("Kérek egy szót! ");
            string s = Console.ReadLine();
            Console.WriteLine($"A szó hossza: {Szohossz(s)}");
        }
        static void feladat7()
        {
            
        }
        public static int osszegzes(int szam)
        {
            if (szam > 0)
            {
                return osszegzes(szam - 1) + szam;
            }
            else return 0; 
        }
        public static bool Palindrom(string s)
        {
            if (s.Length <= 1) return true;
            if (s[0] != s[s.Length - 1]) return false;
            return Palindrom(s.Substring(1, s.Length - 2));
        }
        public static int KarakterSzam(string s, char c)
        {
            if (s.Length == 0) return 0;
            return (s[0] == c ? 1 : 0) + KarakterSzam(s.Substring(1), c);
        }
        public static int lnko(int a, int b)
        {
            if (b == 0) return a;
            return lnko(b, a % b);
        }
        public static void KiirVisszafele(int n)
        {
            if (n < 1) return;
            Console.WriteLine(n);
            KiirVisszafele(n - 1);
        }
        public static int Szohossz(string s)
        {
            if (s.Length == 0) return 0;
            return 1 + Szohossz(s.Substring(1));
        }
        static void Main(string[] args)
        {
            feladat7();
        }
    }
}
