using System;

namespace work2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float dollorToRub = 83.43f;
            float rubToDollor = 83.43f;
            float yuanToRub = 13.11f;
            float rubToYuan = 13.11f;
            float yuanToDollor = 6.36f;
            float dollorToYuan = 6.36f;

            float dollor, rub, yuan;
            float correncyCount;

            string userAction;
            string message;

            Console.WriteLine($"Добрый день! На сегоднешний день в вашем кошельке находится: ");
            Console.Write($"Введите кол-во доллоров в вашем кошельке: ");
            dollor = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во рублей в вашем кошельке: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во юаней в вашем кошельке: ");
            yuan = Convert.ToSingle(Console.ReadLine());

            while (true)
            {
                Console.WriteLine($"Вы можете обменять валюты, варианты будут описаны ниже.");
                Console.WriteLine($"1 - Обменять рубли на доллары");
                Console.WriteLine($"2 - Обменять доллары на рубли");
                Console.WriteLine($"3 - Обменять рубли на юани");
                Console.WriteLine($"4 - Обменять юани на рубли");
                Console.WriteLine($"5 - Обменять юани на доллары");
                Console.WriteLine($"6 - Обменять доллары на юани");
                userAction = Console.ReadLine();

                switch (userAction)
                {
                    case "1":
                        Console.WriteLine($"Обмен рублей на доллары");
                        Console.Write("Cколько вы хотите обменять: ");
                        correncyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= correncyCount)
                        {
                            rub -= correncyCount;
                            dollor += correncyCount / rubToDollor;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во валюты!");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Обмен долларов на рубли");
                        Console.Write("Cколько вы хотите обменять: ");
                        correncyCount = Convert.ToSingle(Console.ReadLine());
                        if (dollor >= correncyCount)
                        {
                            dollor -= correncyCount;
                            rub += correncyCount * dollorToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во валюты!");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Обмен рублей на юани");
                        Console.Write("Cколько вы хотите обменять: ");
                        correncyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= correncyCount)
                        {
                            rub -= correncyCount;
                            yuan += correncyCount / rubToYuan;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во валюты!");
                        }
                        break;

                    case "4":
                        Console.WriteLine($"Обмен юаней на рубли");
                        Console.Write("Cколько вы хотите обменять: ");
                        correncyCount = Convert.ToSingle(Console.ReadLine());
                        if (yuan >= correncyCount)
                        {
                            yuan -= correncyCount;
                            rub += correncyCount * yuanToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во валюты!");
                        }
                        break;

                    case "5":
                        Console.WriteLine($"Обмен юаней на доллары");
                        Console.Write("Cколько вы хотите обменять: ");
                        correncyCount = Convert.ToSingle(Console.ReadLine());
                        if (yuan >= correncyCount)
                        {
                            yuan -= correncyCount;
                            dollor += correncyCount / yuanToDollor;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во валюты!");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Обмен долларов на юани");
                        Console.Write("Cколько вы хотите обменять: ");
                        correncyCount = Convert.ToSingle(Console.ReadLine());
                        if (dollor >= correncyCount)
                        {
                            dollor -= correncyCount;
                            yuan += correncyCount * dollorToYuan;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во валюты!");
                        }
                        break;
                }
                Console.WriteLine($"Ваш баланс в кошельке: {rub} рублей, {dollor} долларов и {yuan} юаней.");
                Console.WriteLine($"Для продолжения обмена валют, нажмине на клавишу 'Enter'.\nДля окончания работы введите 'exit'");
                message = Console.ReadLine();

                if (message == "exit")
                {
                    break;
                }
            }
        }
    }
}
