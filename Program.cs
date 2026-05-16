using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("TOSHKENT KO'CHALARI: KATTA POYGA");
        Console.WriteLine("========================================");

        // 1-Mashina: Malibu (Yo'qilg'isi ko'p - 80L, lekin yili eskiroq - 2016)
        string moshina1Model = "Malibu";
        int moshina1Masofa = 0;
        int moshina1Yoqilgi = 80;
        int moshina1Yili = 2016;

        // 2-Mashina: Gentra (Yo'qilg'isi kamroq - 40L, lekin yili YANGI - 2026!)
        string moshina2Model = "Gentra";
        int moshina2Masofa = 0;
        int moshina2Yoqilgi = 40;
        int moshina2Yili = 2026;

        int marra = 100; // Poyga masofasi 100 metr
        int sekund = 1;

        // while tsikli: Toki ikkala mashinadan biri marraga yetib bormaguncha aylanadi
        while (moshina1Masofa < marra && moshina2Masofa < marra)
        {
            Console.WriteLine($"\n {sekund}-sekund janggisi:");

            // Malibu har sekundda 15 metr yuradi
            moshina1Masofa += 15; 
            
            // Gentra yili yangi (2026) bo'lgani uchun motor kuchliroq va tezroq yuradi (25 metr!)
            moshina2Masofa += 25; 

            Console.WriteLine($" {moshina1Model} ({moshina1Yili}-yil, {moshina1Yoqilgi}L benzin) -> Yurgan masofasi: {moshina1Masofa} metr");
            Console.WriteLine($" {moshina2Model} ({moshina2Yili}-yil, {moshina2Yoqilgi}L benzin) -> Yurgan masofasi: {moshina2Masofa} metr");

            sekund++; // Vaqtni bittaga oshiramiz
        }

        Console.WriteLine("\n========================================");
        Console.WriteLine("POYGA TUGADI! MARRA CHIZIG'I");
        Console.WriteLine("========================================");

        // G'olibni aniqlaymiz va model nomini chiqaramiz
        if (moshina2Masofa >= marra)
        {
            Console.WriteLine($"G'OLIB: Yangi va tezyurar {moshina2Model}!");
        }
        else
        {
            Console.WriteLine($"G'OLIB: {moshina1Model} yutdi!");
        }
    }
}