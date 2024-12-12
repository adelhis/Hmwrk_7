using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class BankTumak
    {
        private long idShet;
        private decimal balanceShet;
        private Bank typeShet = Bank.Сберегательный;

        public void PrintInfoShet()
        {
            Console.WriteLine($"Номер счета: {idShet}\nБаланс счета: {balanceShet}\nТип счета: {typeShet}");
        }
        public BankTumak()
        {
            this.idShet = 0;
            this.balanceShet = 2200000000000000;
            this.typeShet = Bank.Необозначенный;
        }
        public BankTumak(long idShet, decimal balanceShet, Bank typeShet)
        {
            this.idShet = idShet;
            this.balanceShet = balanceShet;
            this.typeShet = typeShet;
        }
        public void ChangeInfoShet()
        {
            Console.Write("Введите новый номер счета:");
            bool isLong = long.TryParse(Console.ReadLine(), out long newIdShet);
            if (isLong && newIdShet.ToString().Length == 16)
            {
                this.idShet = newIdShet;
            }
            else
            {
                this.idShet = idShet;
                Console.WriteLine("Номер должен состоять из 16 цифр, оставлено заданное ранее значение");
            }
            Console.Write("Введите текущий баланс счета:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal newBalanceShet);
            if (isDecimal)
            {
                this.balanceShet = newBalanceShet;
            }
            else
            {
                this.balanceShet = balanceShet;
                Console.WriteLine("Такого баланса быть не может, оставлено заданное ранее значение");
            }
            Console.Write("На какой тип необходимо поменять(Сберегательный/текущий):");
            switch (Console.ReadLine().ToLower())
            {
                case "текущий":
                    typeShet = Bank.Текущий;
                    break;
                case "сберегательный":
                    typeShet = Bank.Сберегательный;
                    break;
                default:
                    this.typeShet = typeShet;
                    Console.WriteLine("Такого типа счета не существует, оставлено заданное ранее значение");
                    break;
            }
            this.PrintInfoShet();
        }
        //к упражнению 7.3
        public void TakeBalanceShet()
        {
            Console.Write("Введите сумму которую хотите снять:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal takenBalanceShet);
            if (isDecimal)
            {
                if (takenBalanceShet < this.balanceShet)
                {
                    balanceShet = balanceShet - takenBalanceShet;
                    Console.WriteLine($"Вы успешно сняли со счета\nТекущий баланс: {balanceShet}");
                }
                else
                {
                    Console.WriteLine("У вас недостаточно средств");
                }
            }
            else
            {
                Console.WriteLine("Вы вввели не сумму");
            }
        }
        public void GiveBalanceShet()
        {
            Console.Write("Введите сумму которую хотите положить:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal givenBalanceShet);
            if (isDecimal)
            {
                balanceShet = balanceShet + givenBalanceShet;
                Console.WriteLine($"Вы успешно пополнили счет\nТекущий баланс счета:{balanceShet}");
            }
            else
            {
                Console.WriteLine("Вы вввели не сумму");
            }
        }

        public void Perevod(BankTumak toShet, decimal sum)
        {
            this.balanceShet = this.balanceShet - sum;
            toShet.balanceShet = toShet.balanceShet + sum;
        }
    }
    enum Bank
    {
        Сберегательный,
        Текущий,
        Необозначенный
    }

}
