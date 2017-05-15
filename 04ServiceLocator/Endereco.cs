using System;
namespace brCode.IoC_Sample.ServiceLocator
{
    public class Endereco: IObjetoEndereco
	{
 
        public Endereco() {}
            
        private string _logradouro;

		public string Logradouro
		{
			get { return _logradouro; }
			set { _logradouro = value; }
		}

		private int _numero;

		public int Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}
    }
}
