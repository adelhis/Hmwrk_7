
namespace Domashka
{
    class Dz_Tumak
    {
        static void Main()
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();
            Zadanie5();
            Zadanie6();

        }
        static void Zadanie1()
        {
            /*Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
            метод, который переводит деньги с одного счета на другой. У метода два параметра: ссылка
            на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.*/
            Console.WriteLine("Упражнение 8.1. Добавить в класс из упр 7.1-7.3 метод перевода");//строка 108 в Bank.cs
            BankTumak bankTumak1 = new BankTumak(1122334455667788, 1000000, Bank.Сберегательный);
            BankTumak bankTumak2 = new BankTumak(1122334455667788, 1000000, Bank.Сберегательный);
            bankTumak1.Perevod(bankTumak2, (decimal)2000);
            bankTumak1.PrintInfoShet();
            bankTumak2.PrintInfoShet();

        }
        static void Zadanie2()
        {
            /*Упражнение 8.2 Реализовать метод, который в качестве входного параметра принимает
            строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.
            Протестировать метод.*/
            Console.WriteLine("\nУпражнение 8.2. Метод, для переворачивания строки\n");
            Console.Write("Введите строку: ");
            Console.WriteLine("Перевернутая строка:\n{0}", ReverseString(Console.ReadLine()));
        }
        static void Zadanie3()
        {
            /*Упражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. Если
            такого файла не существует, то программа выдает пользователю сообщение и заканчивает
            работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными
            буквами.*/
            Console.WriteLine("\nУпражнение 8.3. Из одного файла в другой, если первый существует\n");
            Console.Write("Введите имя файла(inputDz8_1: ");
            string inputFilename = Path.GetFullPath(Console.ReadLine()).Replace("bin\\Debug\\net8.0\\", "files\\");

            if (!File.Exists(inputFilename))
            {
                Console.WriteLine("Файл не существует.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            string outputFilename = Path.GetFullPath("outputFile.txt").Replace("bin\\Debug\\net8.0\\", "files\\");

            try
            {
                string content = File.ReadAllText(inputFilename);
                File.WriteAllText(outputFilename, content.ToUpper());
                Console.WriteLine($"Содержимое файла '{inputFilename}' было записано в '{outputFilename}' в заглавных буквах.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
        static void Zadanie4()
        {
            /*Упражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр
            метода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс
            IFormattable обеспечивает функциональные возможности форматирования значения объекта
            в строковое представление.)*/
            Console.WriteLine("Упражнение 8.4. проверка на реализацию IFormattable");
            int int1 = 123;
            string str1 = "Hello";

            Console.WriteLine($"obj1 реализует IFormattable: {IsIFormattable(int1)}");
            Console.WriteLine($"obj3 реализует IFormattable: {IsIFormattable(str1)}");
        }
        static void Zadanie5()
        {
            /*Домашнее задание 8.1 Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail
            адрес. Разделителем между ФИО и адресом электронной почты является символ #:
            Иванов Иван Иванович # iviviv@mail.ru
            Петров Петр Петрович # petr@mail.ru
            Сформировать новый файл, содержащий список адресов электронной почты.
            Предусмотреть метод, выделяющий из строки адрес почты. Методу в
            качестве параметра передается символьная строка s, e-mail возвращается в той же строке s:
            public void SearchMail (ref string s). На C#*/
            Console.WriteLine("\nДомашнее задание 8.1. Запись в файл email-ы\n");
            string inputFilename = Path.GetFullPath("inputDz8_1.txt").Replace("bin\\Debug\\net8.0\\", "files\\");
            string[] linesFile = File.ReadAllLines(inputFilename);
            string outputFilename = Path.GetFullPath("emailsDz8_1.txt").Replace("bin\\Debug\\net8.0\\", "files\\");
            StreamWriter sw = new StreamWriter(outputFilename);
            foreach (string line in linesFile)
            {
                string email = line;
                SearchMail(ref email);
                sw.WriteLine(email);
            }
            sw.Close();
        }
        static void Zadanie6()
        {
            /*Домашнее задание 8.2 Список песен. В методе Main создать список из четырех песен. В
            цикле вывести информацию о каждой песне. Сравнить между собой первую и вторую
            песню в списке. Песня представляет собой класс с методами для заполнения каждого из
            полей, методом вывода данных о песне на печать, методом, который сравнивает между
            собой два объекта:
            class Song{
            string name; //название песни
            string author; //автор песни
            Song prev; //связь с предыдущей песней в списке
            //метод для заполнения поля name

            //метод для заполнения поля author
            //метод для заполнения поля prev
            //метод для печати названия песни и ее исполнителя
            public string Title(){... возвращ название+исполнитель
                        ...}
            //метод, который сравнивает между собой два объекта-песни:
            public bool override Equals(object d) { ...}*/
            Console.WriteLine("Домашнее задание 8.2. Класс Song");
            List<Song> songs = new List<Song>
            {
                new Song { },
                new Song { },
                new Song { },
                new Song { }
            };
            songs[0].SetName("METAMORPHOSIS");
            songs[0].SetAuthor("Interworld");

            songs[1].SetName("Мой мармеладный");
            songs[1].SetAuthor("Катя Лель");

            songs[2].SetName("Мой мармеладный");
            songs[2].SetAuthor("Катя Лель");

            songs[3].SetName("Селфхарм");
            songs[3].SetAuthor("Монеточка");

            for (int i = 1; i < songs.Count; i++)
            {
                songs[i].SetPrev(songs[i - 1]);
            }
            Console.WriteLine("Вывод информаций о песнях через Title");
            foreach (Song song in songs)
            {
                Console.WriteLine("Информация о песне:\n{0}\n", song.Title());
            }
            Console.WriteLine("Вывод инфораций о песнях через метод SongInfo");
            foreach (Song song in songs)
            {
                song.SongInfo();
            }
            Console.WriteLine("Проверка на сходство 1 и 2 песни: {0}\n Проверка на сходство 2 и 3 песни: {1}", songs[1].Equals(songs[1].prev), songs[2].Equals(songs[2].prev));
        }
        //к упр 8.2
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        //к упр 8.4.
        static bool IsIFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //к дз 8.1.
        static void SearchMail(ref string s)
        {
            string[] nameEmail = s.Split('#');
            s = nameEmail[1];
        }
        
    }
}