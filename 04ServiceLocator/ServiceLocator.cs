using System;
namespace brCode.IoC_Sample.ServiceLocator
{
	public class ServiceLocator
	{
		private static ServiceLocator _serviceLocator;
		private static object _lockThis = new object();

		private IObjetoEndereco _endereco;
		private IObjetoEnderecoDI _empresa;

		public ServiceLocator()
		{
		}

		public static ServiceLocator GetServiceLocator()
		{
			lock (_lockThis)
			{
				if (_serviceLocator == null)
					_serviceLocator = new ServiceLocator();
			}
			return _serviceLocator;
		}

		public IObjetoEndereco GetEndereco()
		{
			return _endereco;
		}

		public IObjetoEnderecoDI GetEmpresa()
		{
			return _empresa;
		}

		public void InitialiseEndereco(IObjetoEndereco srv)
		{
			_endereco = srv;
		}

		public void InitialiseEmpresa(IObjetoEnderecoDI srv)
		{
			_empresa = srv;
		}

	}
}
