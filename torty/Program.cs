using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    class Order
    {
        private int choose = 0;
        private string[] row = new string[5] { "->", "", "", "", "" };
        private double summ = 0.00;
        private string order_text;

        private void first()
        {
            choose = 0;
            drow_menu(0, "");
            while (true)
            {
                Console.Clear();
                Console.WriteLine(drow_menu(0, "1. Круг - 100р"));
                Console.WriteLine(drow_menu(1, "2. Квадрат - 200р"));
                Console.WriteLine(drow_menu(2, "3. Овал - 500р"));
                ConsoleKey k = getkey();
                if (k == ConsoleKey.Enter)
                {
                    switch (choose)
                    {
                        case 0:
                            { order("Круг -", 100); }
                            break;
                        case 1:
                            { order("Квадрат -", 200); }
                            break;
                        case 2:
                            { order("Овал -", 500); }
                            break;
                        default:
                            choose = 0;
                            break;
                    }
                    //break;
                }
                else if (k == ConsoleKey.Escape || k == ConsoleKey.Backspace)
                {
                    //choose = 0;
                    break;
                }
            }
        }
        private void second()
        {
            choose = 0;
            drow_menu(0, "");
            while (true)
            {
                Console.Clear();
                Console.WriteLine(drow_menu(0, "1. 10см(радиус) - 100р"));
                Console.WriteLine(drow_menu(1, "2. 20см(радиус) - 200р"));
                Console.WriteLine(drow_menu(2, "3. 30см(радиус) - 500р"));
                ConsoleKey k = getkey();
                if (k == ConsoleKey.Enter)
                {
                    switch (choose)
                    {
                        case 0:
                            { order("10см(радиус) -", 100); }
                            break;
                        case 1:
                            { order("20см(радиус) -", 200); }
                            break;
                        case 2:
                            { order("30см(радиус) -", 500); }
                            break;
                        default:
                            choose = 0;
                            break;
                    }
                    //break;
                }
                else if (k == ConsoleKey.Escape || k == ConsoleKey.Backspace)
                {
                    //choose = 0;
                    break;
                }
            }
        }
        private void therd()
        {
            choose = 0;
            drow_menu(0, "");
            while (true)
            {
                Console.Clear();
                Console.WriteLine(drow_menu(0, "1. Клубника - 100р"));
                Console.WriteLine(drow_menu(1, "2. Вишня - 200р"));
                Console.WriteLine(drow_menu(2, "3. Барбарис - 500р"));
                ConsoleKey k = getkey();
                if (k == ConsoleKey.Enter)
                {
                    switch (choose)
                    {
                        case 0:
                            { order("Клубника -", 100); }
                            break;
                        case 1:
                            { order("Вишня -", 200); }
                            break;
                        case 2:
                            { order("Барбарис -", 500); }
                            break;
                        default:
                            choose = 0;
                            break;
                    }
                    //break;
                }
                else if (k == ConsoleKey.Escape || k == ConsoleKey.Backspace)
                {
                    //choose = 0;
                    break;
                }
            }
        }
        private void fourth()
        {
            choose = 0;
            drow_menu(0, "");
            while (true)
            {
                Console.Clear();
                Console.WriteLine(drow_menu(0, "1. Сгущенка - 100р"));
                Console.WriteLine(drow_menu(1, "2. Ванильная - 200р"));
                Console.WriteLine(drow_menu(2, "3. Лимонная - 500р"));
                ConsoleKey k = getkey();
                if (k == ConsoleKey.Enter)
                {
                    switch (choose)
                    {
                        case 0:
                            { order("Сгущенка -", 100); }
                            break;
                        case 1:
                            { order("Ванильная -", 200); }
                            break;
                        case 2:
                            { order("Лимонная -", 500); }
                            break;
                        default:
                            choose = 0;
                            break;
                    }
                    //break;
                }
                else if (k == ConsoleKey.Escape || k == ConsoleKey.Backspace)
                {
                    //choose = 0;
                    break;
                }
            }
        }
        private void fiveth()
        {
            choose = 0;
            drow_menu(0, "");
            while (true)
            {
                Console.Clear();
                Console.WriteLine(drow_menu(0, "1. Стразы - 100р"));
                Console.WriteLine(drow_menu(1, "2. Алмазы - 200р"));
                Console.WriteLine(drow_menu(2, "3. Звездочки - 500р"));
                ConsoleKey k = getkey();
                if (k == ConsoleKey.Enter)
                {
                    switch (choose)
                    {
                        case 0:
                            { order("Стразы -", 100); }
                            break;
                        case 1:
                            { order("Алмазы -", 200); }
                            break;
                        case 2:
                            { order("Звездочки -", 500); }
                            break;
                        default:
                            choose = 0;
                            break;
                    }

                }
                else if (k == ConsoleKey.Escape || k == ConsoleKey.Backspace)
                {
                    //choose = 0;
                    break;
                }
            }
        }

        private ConsoleKey getkey()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                if (choose - 1 >= 0)
                {
                    for (int i = 0; i < row.Length; i++)
                    {
                        row[i] = "";
                    }
                    choose--;
                    row[choose] = "->";
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (choose + 1 < row.Length)
                {
                    for (int i = 0; i < row.Length; i++)
                    {
                        row[i] = "";
                    }
                    choose++;
                    row[choose] = "->";
                }
            }

            return key.Key;
        }

        private string drow_menu(int pos, string text)
        {
            string line = row[pos] + text;
            return line;
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine(drow_menu(0, "1. Форма"));
                Console.WriteLine(drow_menu(1, "2. Размер"));
                Console.WriteLine(drow_menu(2, "3. Вкус"));
                Console.WriteLine(drow_menu(3, "4. Глазурь"));
                Console.WriteLine(drow_menu(4, "5. Декор"));
                Console.WriteLine("\n" + order("", 0));

                //ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey k = getkey();
                if (k == ConsoleKey.Enter)
                {
                    while (true)
                    {
                        switch (choose)
                        {
                            case 0:
                                { choose = 0; first(); }
                                break;
                            case 1:
                                { choose = 0; second(); }
                                break;
                            case 2:
                                { choose = 0; therd(); }
                                break;
                            case 3:
                                { choose = 0; fourth(); }
                                break;
                            case 4:
                                { choose = 0; fiveth(); }
                                break;
                            default:
                                break;
                        }
                        if (getkey() == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }
                if (k == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        string order(string order, double cost)
        {
            if (order != "" && cost != 0)
            {
                summ += cost;
                order_text += " " + order + " " + cost + " ";
                StreamWriter sw = new StreamWriter("Заказ.txt");
                sw.WriteLine("Заказ от " + System.DateTime.Now + "\nЗаказ: " + order_text + " \nЦена: " + summ.ToString("0.00") + "р");
                sw.Close();
            }
            return order_text + " \nСумма: " + summ;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Menu();
        }
    }
}