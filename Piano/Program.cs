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
                    Sound(octave4[0]);
                }

                if (key.Key == ConsoleKey.W)
                {
                    Sound(octave4[1]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    Sound(octave4[2]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Sound(octave4[3]);
                }

                if (key.Key == ConsoleKey.T)
                {
                    Sound(octave4[4]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Sound(octave4[5]);
                }

                if (key.Key == ConsoleKey.U)
                {
                    Sound(octave4[6]);
                }

                if (key.Key == ConsoleKey.I)
                {
                    Sound(octave4[7]);
                }

                if (key.Key == ConsoleKey.O)
                {
                    Sound(octave4[8]);
                }

                if (key.Key == ConsoleKey.P)
                {
                    Sound(octave4[9]);
                }

                if (key.Key == ConsoleKey.A)
                {
                    Sound(octave4[10]);
                }

                if (key.Key == ConsoleKey.S)
                {
                    Sound(octave4[11]);
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
                    Sound(octave5[0]);
                }

                if (key.Key == ConsoleKey.W)
                {
                    Sound(octave5[1]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    Sound(octave5[2]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Sound(octave5[3]);
                }

                if (key.Key == ConsoleKey.T)
                {
                    Sound(octave5[4]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Sound(octave5[5]);
                }

                if (key.Key == ConsoleKey.U)
                {
                    Sound(octave5[6]);
                }

                if (key.Key == ConsoleKey.I)
                {
                    Sound(octave5[7]);
                }

                if (key.Key == ConsoleKey.O)
                {
                    Sound(octave5[8]);
                }

                if (key.Key == ConsoleKey.P)
                {
                    Sound(octave5[9]);
                }

                if (key.Key == ConsoleKey.A)
                {
                    Sound(octave5[10]);
                }

                if (key.Key == ConsoleKey.S)
                {
                    Sound(octave5[11]);
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    Main();
                }
            }
        }    
        static void Sound(int ruchki)
        {
            Console.Beep(ruchki, 300);
            Console.Clear();
        }
    }
}