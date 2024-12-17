using System;

namespace ManavKazım
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manav Kazım'a Hoşgeldiniz!\nElma: 2TL\nArmut: 3TL \nÇilek: 2TL \nMuz: 3TL \nDiğer Meyveler: 4TL\n\n");
            Console.Write("Hangi meyveyi almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");

            string? userInput = Console.ReadLine();

            userInput = userInput ?? "";
            string result = char.ToUpper(userInput[0]) + userInput.Substring(1).ToLower();

            //if (Enum.TryParse(result, out Fruits fruits))
            //{
            //    if (fruits == Fruits.Elma)
            //    {
            //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL");
            //    }

            //    if (fruits == Fruits.Armut)
            //    {
            //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL");
            //    }

            //    if (fruits == Fruits.Çilek)
            //    {
            //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL");
            //    }

            //    if (fruits == Fruits.Muz)
            //    {
            //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL");
            //    }

            //    if (fruits == Fruits.Diğer)
            //    {
            //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4TL");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Geçerli bir meyve giriniz");
            //}

            if (Enum.TryParse(result, out Fruits fruits))
            {
                switch (fruits)
                {
                    case Fruits.Elma:
                        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL");
                        break;
                    case Fruits.Armut:
                        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL");
                        break;
                    case Fruits.Çilek:
                        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL");
                        break;
                    case Fruits.Muz:
                        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL");
                        break;
                    case Fruits.Diğer:
                        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4TL");
                        break;
                    default:
                        Console.WriteLine("Meyve Seçmediniz!!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Geçersiz meyve seçtiniz");
            }
            // switch/case kullandım çünkü kodun okunabilirliğini arttırıyor ve bunun gibi çok koşullu senaryolarda daha kullanışlı oluyor

        }
    }

    enum Fruits
    {
        Elma,
        Armut,
        Çilek,
        Muz,
        Diğer
    }
}