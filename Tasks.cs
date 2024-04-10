namespace ConsoleApp4
{
    internal class Tasks
    {
        public void Task0()
        {
            Console.Write("Введите размерность массива : ");
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            string textN = " ";
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = new Random().Next(0, 99);

                    Console.Write(arr[i, j]);
                    Console.WriteLine();

                    for (int k = 0; k <= p; k++)
                    {
                        Console.Write(textN);
                    }
                    p++;
                }
            }
        }
        public void Task1()
        {
            //Телефонный справочник 
            string[,] arr = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Введите имя контакта: ");
                        arr[i, j] = Console.ReadLine();

                    }
                    else if (j == 1)
                    {
                        Console.Write("Введите номер телефона или  email: ");
                        arr[i, j] = Console.ReadLine();
                    }

                }
            }

            Console.WriteLine();
            Console.WriteLine("Список:");
            Console.WriteLine("Имя:\tКонтакт:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public void Task2() 
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();
            Console.WriteLine(Reverse(text));
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

