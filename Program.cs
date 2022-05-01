using System;

namespace AI
{
    class Program
    {
        private delegate void Delegate();
        public static int answer;
        public static string sAnswer;

        private static void Lang()
        {
            Console.WriteLine("Какой ваш язык?");
            sAnswer = Console.ReadLine();
            Delegate f;
            if(sAnswer == "RU")
            {
                f = Spec;
                f();
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void Spec()
        {
            Console.WriteLine("Какая ваша специализация?");
            sAnswer = Console.ReadLine();
            Delegate a;
            if(sAnswer == "Лекарь" )
            {
                a = HeallIlvl;
                a();
            }
            else if(sAnswer == "Танк")
            {
                a = TankIlvl;
                a();
            }
            else if(sAnswer == "Боец")
            {
                a = DDIlvl;
                a();
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void TankIlvl()
        {
            Console.WriteLine("Кой у вас уровень предметов?");
            answer = Convert.ToInt32(Console.ReadLine());
            Delegate f;
            if (answer >= 270)
            {
                Console.WriteLine("Берем");
            }
            else if (answer >= 255 && answer < 270)
            {
                f = TankRating;
                f();
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void DDIlvl()
        {
            Console.WriteLine("Кой у вас уровень предметов?");
            answer = Convert.ToInt32(Console.ReadLine());
            Delegate f;
            if (answer >= 280)
            {
                Console.WriteLine("Берем");
            }
            else if (answer >= 260 && answer < 280)
            {
                f = DDRating;
                f();
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void HeallIlvl()
        {
            Console.WriteLine("Кой у вас уровень предметов?");
            answer = Convert.ToInt32(Console.ReadLine());
            Delegate f;
            if (answer >= 275)
            {
                Console.WriteLine("Берем");
            }
            else if(answer >= 255 && answer < 275)
            {
                f = HealRating;
                f();
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void TankRating()
        {
            Console.WriteLine("Каой у вас рейтинг?");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer >= 1400)
            {
                Console.WriteLine("Берем");
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void DDRating()
        {
            Console.WriteLine("Каой у вас рейтинг?");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer >= 2000)
            {
                Console.WriteLine("Берем");
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        private static void HealRating()
        {
            Console.WriteLine("Каой у вас рейтинг?");
            answer = Convert.ToInt32(Console.ReadLine());
            if(answer >= 1500)
            {
                Console.WriteLine("Берем");
            }
            else
            {
                Console.WriteLine("Не берем");
            }
        }

        static void Main(string[] args)
        {
            Lang();
        }
    }
}
