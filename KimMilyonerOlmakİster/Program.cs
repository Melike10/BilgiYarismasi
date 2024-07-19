// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bilgi yarışmasına hoş geldiniz! \n 3 sorudan ikisini doğru cevapladığınız takdirde ödül kazanmış olacaksınız.");
// değişkenlerim
int countTrue = 0;
char selectedValue;
bool selected ;

Console.WriteLine("Soru 1 : C# yazılım dilinde char için hangi tırnak kullanılır? \n A)Tek Tırnak(') B)Çift Tırnak ");
selected = char.TryParse(Console.ReadLine(),out selectedValue); 
if (selected)
{
    switch (selectedValue.ToString().ToLower())//char olunca tolower kullanamadığım için stringe dönüştürdüm.
    {
        case "a":
            Console.WriteLine("Doğru cevapladınız!");
            countTrue++;
            break;
        case "b":
            Console.WriteLine("Yanlış cevapladınız!");
            break;
        default:
            Console.WriteLine("a ve b seçeneği dışında seçenek yazdığınız için bu sorudan puan alamadınız!");
            break;
    }
}
else
{
    Console.WriteLine("Yanlış giriş yaptığınız için bu sorudan puan alamadınız!");
    
}


Console.WriteLine("Soru 2 : Hangi çöl Asya'dadır ? \n A)Sahra B)Arabistan ");
selected = char.TryParse(Console.ReadLine(), out selectedValue);
if (selected)
{
    switch (selectedValue.ToString().ToLower())
    {
        case "b":
            Console.WriteLine("Doğru cevapladınız!");
            countTrue++;
            break;
        case "a":
            Console.WriteLine("Yanlış cevapladınız!");
            break;
        default:
            Console.WriteLine("a ve b seçeneği dışında seçenek yazdığınız için bu sorudan puan alamadınız!");
            break;
    }
}
else
{
    Console.WriteLine("Yanlış giriş yaptığınız için bu sorudan puan alamadınız!");

}

if (countTrue<1) {
    Console.WriteLine("Yeterli puanı alamadığınız için son soruyu görme hakkını kaybettiniz. ");
    return;
}

if (countTrue==2) {
    Console.WriteLine("Yarışmayı kazandınız.Tebrikler. ");
    return;
}
Console.WriteLine("Soru 3 : Türkiye Cumhuriyet Bayramı ilk ne zaman kutlandı? \n A)29 Ekim 1925 B)29 Ekim 1933 ");
selected = char.TryParse(Console.ReadLine(), out selectedValue);
if (selected)
{
    switch (selectedValue.ToString().ToLower())
    {
        case "a":
            Console.WriteLine("Doğru cevapladınız!");
            countTrue++;
            break;
        case "b":
            Console.WriteLine("Yanlış cevapladınız!");
            break;
        default:
            Console.WriteLine("a ve b seçeneği dışında seçenek yazdığınız için bu sorudan puan alamadınız!");
            break;
    }
}
else
{
    Console.WriteLine("Yanlış giriş yaptığınız için bu sorudan puan alamadınız!");

}
if(countTrue >= 2)
{
    Console.WriteLine("Yarışmayı kazandınız. Tebrik ederim!");
}
else
{
    Console.WriteLine("Maalesef kazanamadınız!");
}


