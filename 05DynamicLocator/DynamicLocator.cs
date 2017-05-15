using System;
using System.Collections.Generic;

namespace brCode.IoC_Sample.DynamicLocator
{
    public class DynamicLocator : IService
    {
		public Dictionary<object, object> servicecontainer = null;
		public DynamicLocator()
		{
			servicecontainer = new Dictionary<object, object>();
            servicecontainer.Add(typeof(IObjetoEndereco), new Endereco());
            servicecontainer.Add(typeof(IObjetoEnderecoDI), new Empresa());
		}
		public T GetService<T>()
		{
			try
			{
				return (T)servicecontainer[typeof(T)];
			}
			catch (Exception ex)
			{
				throw new NotImplementedException("Service not available.");
			}
		}
	}
}
