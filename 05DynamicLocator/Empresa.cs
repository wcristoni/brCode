using System;
namespace brCode.IoC_Sample.DynamicLocator
{
	public class Empresa : IObjetoEnderecoDI
	{
		private int _cod;

		public int Cod
		{
			get { return _cod; }
			set { _cod = value; }
		}

		private string _razaoSocial;

		public string RazaoSocial
		{
			get { return _razaoSocial; }
			set { _razaoSocial = value; }
		}

		// Observe que nessa implementacao a referência é para a Interface
		private IObjetoEndereco _endereco;

		public void setEndereco(IObjetoEndereco endereco)
		{
			_endereco = endereco;
		}

		public IObjetoEndereco Endereco
		{
			get { return _endereco; }
		}

	}
}
