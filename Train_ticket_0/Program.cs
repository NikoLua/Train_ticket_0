using System;

namespace Train_ticket_0
{
    class Program
    {
        static bool[,] tickets = new bool[3, 4];

        //初始化二维数组
        static void InitArray()
        {
            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                for (int j = 0; j < tickets.GetLength(1); j++)
                {
                    tickets[i, j] = true;
                }
            }

            //tt[0, 0] = "1_1 有票";
        }

        //显示车票
        static void DrawTickets()
        {
            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                for (int j = 0; j < tickets.GetLength(1); j++)
                {
                    if (tickets[i, j])
                    {
                        Console.Write("{0}_{1}有票  ", i + 1, j + 1);
                    }
                    else
                    {
                        Console.Write("{0}_{1}无票  ", i + 1, j + 1);
                    }
                }
                Console.WriteLine();
            }
        }


        //输入座位号
        static int InputNum()
        {
            while (true)
            {
                string input = Console.ReadLine();
                int num;
                bool success = int.TryParse(input, out num);
                if (!success)
                {
                    Console.WriteLine("数字格式不正确，请重新输入");
                    continue;
                }

                return num;
            }
        }


        static void Main(string[] args)
        {
            InitArray();

            int row;
            int column;
            while (true)
            {
                // 画车票
                DrawTickets();

                Console.WriteLine("请输入需要购买的座位号");

                row = InputNum() - 1;
                column = InputNum() - 1;
    

                if (row < 3 && row >= 0 && column >= 0 && column < 4)
                {
                    if (tickets[row, column])
                    {
                        tickets[row, column] = false;
                        Console.WriteLine("购买成功");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("该座位已被购买。");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("输入错误。");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
