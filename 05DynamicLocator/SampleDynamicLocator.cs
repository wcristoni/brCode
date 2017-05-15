using System;
namespace brCode.IoC_Sample.DynamicLocator
{
    public class SampleDynamicLocator
    {
        public SampleDynamicLocator()
        {
			// ---------------------------------------
			// Exemplo de implementação de DynamicLocator
			// ---------------------------------------

            DynamicLocator loc = new DynamicLocator();
			
            // Definindo o endereço

            Endereco endereco = (Endereco)loc.GetService<IObjetoEndereco>();
			endereco.Logradouro = "Rua Teste 05";
			endereco.Numero = 10;

            Empresa empresa = (Empresa)loc.GetService<IObjetoEnderecoDI>();

			empresa.setEndereco(endereco);
			empresa.RazaoSocial = "brCode ltda2";
			empresa.Cod = 2;

            empresa = (Empresa)loc.GetService<IObjetoEnderecoDI>();

            // Imprimindo os valores

            Console.WriteLine("Retornando o Empresa[{0},{1}].Endereco (Classe Endereco): {2},{3}",
                                                empresa.Cod,
                                                empresa.RazaoSocial,
                                                empresa.Endereco.Logradouro,
                                                empresa.Endereco.Numero);
        }
    }
}

