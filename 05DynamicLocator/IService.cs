using System;
namespace brCode.IoC_Sample.DynamicLocator
{
    public interface IService
    {
		T GetService<T>();
	}
}
