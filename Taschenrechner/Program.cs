using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            AnwendungsController controller = new AnwendungsController(view, model);

            controller.Ausfuehren();
        }
    }
}
            // Test4
            // Test2
            // Test3
            // Test5
            // Test6
            // Test7
            // Test8
            