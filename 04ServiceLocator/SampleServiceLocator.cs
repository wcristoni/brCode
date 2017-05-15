using System;
namespace brCode.IoC_Sample.ServiceLocator
{
	public class SampleServiceLocator
	{
		public SampleServiceLocator()
		{
			// ---------------------------------------
			// Implementação Original
			// ---------------------------------------

			// Inicializando o Service Locator

			Initialiser i = new Initialiser();

			// Definindo o endereço
			ServiceLocator.GetServiceLocator().GetEndereco().Logradouro = "Rua Teste 04";
			ServiceLocator.GetServiceLocator().GetEndereco().Numero = 10;

			// Definindo a empresa

			ServiceLocator.GetServiceLocator().GetEmpresa().setEndereco(ServiceLocator.GetServiceLocator().GetEndereco());
			ServiceLocator.GetServiceLocator().GetEmpresa().RazaoSocial = "brCode ltda";
			ServiceLocator.GetServiceLocator().GetEmpresa().Cod = 1;

			// Imprimindo os valores

			Console.WriteLine("Retornando o Empresa[{0},{1}].Endereco (Classe Endereco): {2},{3}",
												ServiceLocator.GetServiceLocator().GetEmpresa().Cod,
												ServiceLocator.GetServiceLocator().GetEmpresa().RazaoSocial,
												ServiceLocator.GetServiceLocator().GetEmpresa().Endereco.Logradouro,
												ServiceLocator.GetServiceLocator().GetEmpresa().Endereco.Numero);
		}
	}
}
