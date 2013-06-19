using System;
using System.ComponentModel.Composition.Hosting;
using System.Text;

namespace MEFDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dataTransformer = new EmployeeDataTransformer();

            var assemblyCatalog = new AssemblyCatalog(typeof (Program).Assembly);
            var directoryCatalog = new DirectoryCatalog("./Plugins");
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            var dataTransformer = container.GetExportedValue<EmployeeDataTransformer>();
            dataTransformer.Transform();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
