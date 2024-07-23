Console.WriteLine("Kim milyoner olmak ister'e hoşgeldin!");
int dogrucevapsayisi = 0;  // Doğru cevap sayısını tutmak için değişken

Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("a) Lama b) Deve ");
string cevap1 = Console.ReadLine().ToLower(); // Kullanıcıdan cevap al ve küçük harfe dönüştür

if (cevap1 == "a")
{

    Console.WriteLine("Dorğu bildiniz.Cevap A");
    dogrucevapsayisi++; // Doğru cevap sayısını artır
}
else
{
    Console.WriteLine("Yanlış Cevap.Doğru cevap A olacaktı.");
}
if (dogrucevapsayisi < 2)
{

    Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ? ");
    Console.WriteLine("a) Venüs b) Mars ");
    string cevap2 = Console.ReadLine().ToLower();



    if (cevap2 == "a")

    {

        Console.WriteLine("Dorğu bildiniz.Cevap A");
        dogrucevapsayisi++;
    }
    else
    {
        Console.WriteLine("Yanlış Cevap.Doğru cevap A olacaktı.");
       
    }
}

if (dogrucevapsayisi < 2)
{

    Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? "); // eğer kullanıcı 2 doğru cevaba ulaşmamışsa sorulacak
    Console.WriteLine("a) 7 b) 12 ");
    string cevap3 = Console.ReadLine().ToLower();

    if (cevap3 == "b")
    {
        Console.WriteLine("Doğru bildiniz.Cevap B");
        dogrucevapsayisi++;
    }
    else
    {
        Console.WriteLine("Yanlış Cevap.Doğru cevap B olacaktı.");
    }
}

// Sonuç kısmı, doğru cevap sayısına göre kullanıcıya sonucu bildirir
if (dogrucevapsayisi >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else
{
    Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
}