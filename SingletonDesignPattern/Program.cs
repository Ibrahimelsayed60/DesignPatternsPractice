using SingletonDesignPattern.BuilderDesignPattern;
using SingletonDesignPattern.FactoryDesignPattern;
using SingletonDesignPattern.PrototypeDesignPattern;
using SingletonDesignPattern.StructuralPatterns.AdapterDesignPattern;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logger.Instance.Log("Application started");
            //Logger.Instance.Log("Something happened");

            //IReport report1 = ReportFactory.CreateReport("pdf");
            //report1.Generate();

            //IReport report2 = ReportFactory.CreateReport("excel");
            //report2.Generate();

            //var builder = new ModernHouseBuilder();
            //var director = new HouseDirector(builder);
            //House luxuryHouse = director.BuildLuxuryHouse();
            //luxuryHouse.ShowDetails();


            //var original = new Person { Name = "Ali", Age = 30 };
            //var copy = original.Clone();
            //copy.Name = "Mohamed";
            //Console.WriteLine(original.Name);
            //Console.WriteLine(copy.Name);

            ICardReader reader = new NfcReaderAdapter(new NfcReader());
            reader.ReadCard();

        }
    }
}
