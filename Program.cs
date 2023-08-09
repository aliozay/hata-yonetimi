// try

// {


// Console.WriteLine("Bir Sayı Giriniz");
// int sayi = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Girmiş olduğunuz sayı: " + sayi   );


// }

// catch (Exception ex)
// {


// Console.WriteLine("Hata: " + ex.Message.ToString());

// }

// finally
// {

// System.Console.WriteLine("İşlem tamamlandı");

// }

try
{
     //int a = int.Parse(null);
     //int a = int.Parse("test");
     int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
    System.Console.WriteLine("Boş değer girdiniz");
    System.Console.WriteLine(ex);

}
catch (FormatException ex)
{
    System.Console.WriteLine("Veri tipi uygun değil");
    System.Console.WriteLine(ex);
}

catch (OverflowException ex)
{

    System.Console.WriteLine("Çok küçük ya da çok büyük bir sayı girdiniz");
    System.Console.WriteLine(ex);
}

finally

{
    System.Console.WriteLine("işlem başarıyla tamamlandı");
}
