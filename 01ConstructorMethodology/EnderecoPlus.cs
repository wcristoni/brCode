using System;
namespace brCode.IoC_Sample.ConstructorMethodology
{
    public class EnderecoPlus: Endereco, IObjetoEndereco
    {
        private string _tipoLogradouro;

		public string TipoLogradouro
		{
			get { return _tipoLogradouro; }
			set { _tipoLogradouro = value; }
		}



        // Construtor
        public EnderecoPlus(){}

        public EnderecoPlus(string tipoLogradouro, string logradouro, int numero) {
			this.TipoLogradouro = tipoLogradouro;
			this.Logradouro = logradouro;
			this.Numero = numero;
		}

    }
}
