using System;
namespace brCode.IoC_Sample.ConstructorMethodology
{
    public class SampleConstructorMethodology
    {
        public SampleConstructorMethodology()
        {
			// ---------------------------------------
			// Implementação Original
			// ---------------------------------------
			
            // Implementando Empresa, com o objeto Endereco
			
			Empresa objEmpresa = new Empresa(new Endereco("Rua Teste", 10));
            Endereco objEndereco = objEndereco = (Endereco) objEmpresa.Endereco;

            Console.WriteLine("Retornando o Empresa.Endereco (Classe Endereco): {0},{1}",
                                                objEndereco.Logradouro, objEndereco.Numero);


			// ---------------------------------------
            // Alteração Solicitada: Sdicionar o TipoLogradouro
			// ---------------------------------------

			// Implementando Empresa, com o objeto EnderecoPlus
			Empresa objEmpresaPlus = new Empresa(new EnderecoPlus("Avenida", "Paulista", 1000));
            EnderecoPlus objEnderecoPlus = (EnderecoPlus) objEmpresaPlus.Endereco;

            Console.WriteLine("Retornando o Empresa.Endereco (Classe EnderecoPlus): {0},{1},{2}",
								   objEnderecoPlus.TipoLogradouro, objEnderecoPlus.Logradouro, objEnderecoPlus.Numero);


		}
    }
}
