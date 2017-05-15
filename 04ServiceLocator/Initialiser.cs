using System;
namespace brCode.IoC_Sample.ServiceLocator
{
	public class Initialiser
	{

		public Initialiser()
		{
			this.InitEndereco();
			this.InitEmpresa();
		}

		public void InitEndereco()
		{
			ServiceLocator.GetServiceLocator().InitialiseEndereco(new Endereco());
		}

		public void InitEmpresa()
		{
			ServiceLocator.GetServiceLocator().InitialiseEmpresa(new Empresa());
		}
	}
}
