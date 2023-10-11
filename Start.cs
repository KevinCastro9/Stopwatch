using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class Start
    {
        public void Menu()
        {
            string data = "";
            char type = '\0';
            int time = 0;
            
            try
            {
                Console.Clear();
                Console.WriteLine("Por gentileza digite o tempo que será cronometrado exemplo 10s (10 segundos), 10m (10 minutos), 1h (1 hora)");
                Console.WriteLine("S = Segundos");
                Console.WriteLine("M = Minutos");
                Console.WriteLine("H = Horas");
                Console.WriteLine("0 = Sair");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Quanto tempo deseja cronometrar ?");

                data = Console.ReadLine().ToLower();

                if (data == "0")
                    Environment.Exit(0);

                type = char.Parse(data.Substring(data.Length - 1, 1));
                time = int.Parse(data[0..^1]);

                if (time == 0)
                    Environment.Exit(0);

                PreStartStopWatch(type, time);

                Console.WriteLine("Cronometro finalizado! Clique em qualquer tecla para voltar ao Menu!");
                Console.ReadKey();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Por gentileza preencha apenas valores conforme a descrição!. Clique em qualquer tecla para voltar ao Menu!");
                Console.ReadKey();
            }
        }

        public void PreStartStopWatch(char type, int timer)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            StartStopWatch(type, timer);
        }
        public void StartStopWatch(char type, int timer)
        {
            int currentTime = 0;
            int multiplier = 1;

            switch (type)
            {
                case 's':
                    multiplier = 1; break;
                case 'm':
                    multiplier = 60; break;
                case 'h':
                    multiplier = 3600; break;
                default: 
                    break;
            }

            while (currentTime != timer * multiplier)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime.ToString());

                //Thread é a execução atual do programa e Sleep serve para pausar o programa passando o tempo em milesegundos
                Thread.Sleep(1000);
            }
        }     
    }
}
