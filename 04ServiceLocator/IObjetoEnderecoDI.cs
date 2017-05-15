using System;
namespace brCode.IoC_Sample.ServiceLocator
{
    public interface IObjetoEnderecoDI
    {

		void setEndereco(IObjetoEndereco obj);

		string RazaoSocial
		{
			get;
			set;
		}

		int Cod
		{
			get;
			set;
		}

		IObjetoEndereco Endereco
		{
			get;
		}
	}
}
