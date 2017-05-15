using System;
namespace brCode.IoC_Sample.ConstructorMethodology
{
    public class Endereco : IObjetoEndereco {


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

        // Construtor
		public Endereco(string logradouro, int numero)
		{
            this.Logradouro = logradouro;
            this.Numero = numero;
		}

        public Endereco(){}

	}
}
