using Car;

namespace Lampdas
{
    public class Program
    {
        static CarEngine carEngine = new CarEngine();

        public static void Main(String[] args)
        {
            carEngine.EngineStarted += OnEngineStart;
            carEngine.EngineStopped += OnEngineStop;
            carEngine.EngineSpeedChanged += OnSpeedChangeOne;
            carEngine.EngineSpeedChanged += OnSpeedChangeTwo;

            carEngine.StartEngine();
            carEngine.SetEngineSpeed(50);
            carEngine.SetEngineSpeed(90);
            carEngine.StopEngine();

            Console.ReadLine();
        }

        public static void OnEngineStart()
        {
            Console.WriteLine("The engine has started!");
        }

        public static void OnEngineStop()
        {
            Console.WriteLine("The engine has stopped!");
        }

        public static void OnSpeedChangeOne(int speed)
        {
            Console.WriteLine($"The engine speed has changed to {speed}.");
        }

        public static void OnSpeedChangeTwo(int speed)
        {
            Console.WriteLine($"The engine speed has changed to {speed}.");
            string file = "new_engine_speed.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(speed);
            }
        }
    }
}

