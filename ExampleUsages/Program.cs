using System.Linq;
using MultiMonitorHelper;

namespace ExampleUsages
{
	internal class Program
    {
        private static void Main(string[] args)
        {
            var displayModel = DisplayFactory.GetDisplayModel();
            var displayList = displayModel.GetActiveDisplays().ToList();

        }
    }
}