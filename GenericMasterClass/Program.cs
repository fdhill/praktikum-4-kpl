using System.Numerics;

namespace GenericMaterClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<float> db = new SimpleDataBase<float>();
            var x = new Penjumlahan<float, float, float>();

            Console.Write("Masukkan angka pertama: ");
            float a1 = float.Parse(Console.ReadLine());
            db.AddNewData(a1);

            Console.Write("Masukkan angka kedua: ");
            float a2 = float.Parse(Console.ReadLine());
            db.AddNewData(a2);

            Console.Write("Masukkan angka ketiga: ");
            float a3 = float.Parse(Console.ReadLine());
            db.AddNewData(a3);

            Console.WriteLine("Hasil Perjumlahan dari angka " + a1 + " + " + a2 + " + " + a3 + " adalah " + x.JumlahTigaAngka(a1, a2, a3));

            db.PrintAllData();
        }
    }

    public class Penjumlahan<T1, T2, T3>
        where T1 : IFloatingPoint<T1>
        where T2 : IFloatingPoint<T2>
        where T3 : IFloatingPoint<T3>
    {
        public dynamic JumlahTigaAngka(T1 angkaPertama, T1 angkaKedua, T1 angkaKetiga)
        {
            dynamic hasil = angkaPertama + angkaKedua + angkaKetiga;
            return hasil;
        }
    }

    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data : {storedData[i]} Input Date: {inputDates[i]}");
            }
        }
    }
}