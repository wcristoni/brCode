using System;


namespace brCode.IoC_Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exemplo 1: Constructor Methodology\n");
            ConstructorMethodology.SampleConstructorMethodology ex01 = new ConstructorMethodology.SampleConstructorMethodology();

            Console.WriteLine("\n\nExemplo 2: Getter And Setter\n");
            GetterAndSetter.SampleGetterAndSetter ex02 = new GetterAndSetter.SampleGetterAndSetter();

			Console.WriteLine("\n\nExemplo 3: Interface Implemantation\n");
			InterfaceImplemantation.SampleInterfaceImplemantation ex03 = new InterfaceImplemantation.SampleInterfaceImplemantation();

			Console.WriteLine("\n\nExemplo 4: Service Locator\n");
            ServiceLocator.SampleServiceLocator ex04 = new ServiceLocator.SampleServiceLocator();

			Console.WriteLine("\n\nExemplo 5: Dynamic Service Locator\n");
			DynamicLocator.SampleDynamicLocator ex05 = new DynamicLocator.SampleDynamicLocator();

			int s = Console.Read(); 
        }
    }
}
