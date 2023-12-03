using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class CashMachine
    {
        int banknote20;
        int banknote50;
        int banknote100;

        public CashMachine(int banknote20, int banknote50, int banknote100)
        {
            this.banknote20 = banknote20;
            this.banknote50 = banknote50;
            this.banknote100 = banknote100;
        }
        //Сделала перегрузку, т.к. предполагаю, что за 1 раз могут вноситься разные номиналы : могут внести только один номнил, или сразу несколько
        public void addBanknote(int b20)
        {
            banknote20 += b20;
        }
        public void addBanknote(int b20, int b50)
        {
            banknote20 += b20;
            banknote50 += b50;

        }
        public void addBanknote(int b20, int b50, int b100)
        {
            banknote20 += b20;
            banknote50 += b50;
            banknote100 += b100;
        }
        //Сделала перегрузку, т.к. предполагаю, что за 1 раз могут сниматься разные номиналы : могут снять только один номнил, или сразу несколько

        public bool WithdrawBanknote(int b20)
        {
            if (banknote20 > 0 && (banknote20 - b20) >= 0)
            {
                banknote20 += b20;
                Console.WriteLine($"Выдано {b20} купюр номиналом 20");
                return true;
            }
            else
            {
                Console.WriteLine("Операция неуспешна");
                return false;
            }

        }
        public bool WithdrawBanknote(int b20, int b50)
        {
            if (banknote20 > 0 && (banknote20 - b20) >= 0 && banknote50 > 0 && (banknote50 - b50) >= 0)
            {
                banknote20 += b20;
                banknote50 += b50;
                Console.WriteLine($"Выдано {b20} купюр номиналом 20 и {b50} купюр номиналом 50");
                return true;
            }
            else
            {
                Console.WriteLine("Операция неуспешна");
                return false;
            }

        }

        public bool WithdrawBanknote(int b20, int b50, int b100)
        {
            if (banknote20 > 0 && (banknote20 - b20) >= 0 && banknote50 > 0 && (banknote50 - b50) >= 0 && banknote100 > 0 && (banknote100 - b100) >= 0)
            {
                banknote20 += b20;
                banknote50 += b50;
                banknote100 += b100;
                Console.WriteLine($"Выдано {b20} купюр номиналом 20 и {b50} купюр номиналом 50 и {b100} купюр номиналом 100");
                return true;
            }
            else
            {
                Console.WriteLine("Операция неуспешна");
                return false;
            }

        }
    }
}
