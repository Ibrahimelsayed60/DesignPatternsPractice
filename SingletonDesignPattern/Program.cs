using SingletonDesignPattern.BehavioralDesignPatterns.StrategyDesignPattern;
using SingletonDesignPattern.BuilderDesignPattern;
using SingletonDesignPattern.FactoryDesignPattern;
using SingletonDesignPattern.PrototypeDesignPattern;
using SingletonDesignPattern.StructuralPatterns.AdapterDesignPattern;
using SingletonDesignPattern.StructuralPatterns.BridgeDesignPattern;
using SingletonDesignPattern.StructuralPatterns.CompositeDesignPattern;
using SingletonDesignPattern.StructuralPatterns.DecoratorDesignPattern;
using SingletonDesignPattern.StructuralPatterns.FacadeDesignPattern;
using SingletonDesignPattern.StructuralPatterns.ProxyDesignPattern;
using File = SingletonDesignPattern.StructuralPatterns.CompositeDesignPattern.File;

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

            #region Adapter Design pattern
            //ICardReader reader = new NfcReaderAdapter(new NfcReader());
            //reader.ReadCard(); 
            #endregion

            #region Decorator Design pattern
            //ICoffe coffee = new SimpleCoffee();
            //Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost()}");

            //coffee = new MilkDecorator(coffee);

            //coffee = new CreamDecorator(coffee); 
            #endregion

            #region Facade design pattern
            //var player = new MoviePlayerFacade();
            //player.PlayMovie(); 
            #endregion

            #region Composite Design pattern
            //var root = new Folder("Root");
            //var file1 = new File("a.txt");
            //var file2 = new File("b.txt");
            //var subFolder = new Folder("SubFolder");
            //subFolder.Add(new File("c.txt"));
            //root.Add(file1);
            //root.Add(file2);
            //root.Add(subFolder);
            //root.Display(""); 
            #endregion

            #region Proxy Design pattern
            //IImage image = new ProxyImage("cat.jpg");
            //Console.WriteLine("Before displaying");
            //image.Display();
            //image.Display();
            #endregion

            #region Bridge Design pattern

            //Message lightSms = new SmsMessage(new LightThemeRenderer());
            //lightSms.show();
            //Message darkSms = new EmailMessage(new LightThemeRenderer());
            //darkSms.show();

            #endregion

            #region Strategy design pattern
            var processor = new PaymentProcessor(new CreditCardPayment());
            processor.ProcessPayment(100);
            processor.SetPaymentStrategy(new PaypalPayment());
            processor.ProcessPayment(100);
            #endregion
        }
    }
}
