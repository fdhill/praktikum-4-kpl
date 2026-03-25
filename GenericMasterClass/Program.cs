using System.Numerics;

namespace GenericMaterClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = new Penjumlahan<float, float, float>();

            Console.Write("Masukkan angka pertama: ");
            float a1 = float.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            float a2 = float.Parse(Console.ReadLine());

            Console.Write("Masukkan angka ketiga: ");
            float a3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Hasil Perjumlahan dari angka " + a1 + " + " + a2 + " + " + a3 + " adalah " + x.JumlahTigaAngka(a1, a2, a3));

        }
    }

    public class Penjumlahan<T1, T2, T3>
        where T1 : IFloatingPoint<T1>
        where T2 : IFloatingPoint<T2>
        where T3 : IFloatingPoint<T3>
    {
        public dynamic JumlahTigaAngka(T1 angkaPertama, T1 angkaKedua, T1 angkaKetiga)
        {
            dynamic hasil =  angkaPertama + angkaKedua + angkaKetiga;
            return hasil;
        }
    }


}