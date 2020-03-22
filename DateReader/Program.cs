using DateReader.Viewer;
using DateReader.Controller;

namespace DateReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Engine engine = new Engine(view);
            engine.Run(args);
        }
    }
}
