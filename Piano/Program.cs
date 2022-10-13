namespace Piano
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Доступные октавы: 4, 5");
            Console.WriteLine("Каждая октава привязана к Fn, где n это номер октавы");
            Console.Write("Введите номер октавы:");
            ConsoleKeyInfo NumberOctave = Console.ReadKey();
            
            if (NumberOctave.Key == ConsoleKey.F4)
            {
                Octave4();
            }
            if (NumberOctave.Key == ConsoleKey.F5)
            {
                Octave5();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Введена не существующая октава. Введите октаву еще раз");
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }

        }
        static void Octave4()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Вы выбрали 4 октаву");
            Console.WriteLine("Чтобы вернуться в меню октав нажмите (Esc)");

            while (true)
            {
                int[] octave4 = new int[] {261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493};
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(octave4[0], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(octave4[1], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(octave4[2], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(octave4[3], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(octave4[4], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(octave4[5], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(octave4[6], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep(octave4[7], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.O)
                {
                    Console.Beep(octave4[8], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.P)
                {
                    Console.Beep(octave4[9], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(octave4[10], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(octave4[11], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    Main();
                }
            }
        }
        static void Octave5()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Вы выбрали 5 октаву");
            Console.WriteLine("Чтобы вернуться в меню октав нажмите (Esc)");

            while (true)
            {
                int[] octave5 = new int[] {523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987};
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(octave5[0], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(octave5[1], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(octave5[2], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(octave5[3], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(octave5[4], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(octave5[5], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(octave5[6], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep(octave5[7], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.O)
                {
                    Console.Beep(octave5[8], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.P)
                {
                    Console.Beep(octave5[9], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(octave5[10], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(octave5[11], 500);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    Main();
                }
            }
        }      
    }
}