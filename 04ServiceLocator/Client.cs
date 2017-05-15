using System;
namespace brCode.IoC_Sample.ServiceLocator
{
	public class Client
	{
		public void UseEndereco()
		{
			ServiceLocator.GetServiceLocator().GetEndereco();
		}

		public void UseEmpresa()
		{
			ServiceLocator.GetServiceLocator().GetEmpresa();
		}
	}
}
