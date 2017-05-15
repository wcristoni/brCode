using System;
namespace brCode.IoC_Sample.InterfaceImplemantation
{
    public class SampleInterfaceImplemantation
    {
        public SampleInterfaceImplemantation()
        {

			// ---------------------------------------
			// Implementação Original
			// ---------------------------------------

			// Implementando Empresa, com o objeto Endereco

			Endereco objEndereco = new Endereco();
			objEndereco.Logradouro = "Rua Teste 03";
			objEndereco.Numero = 10;

			Empresa objEmpresa = new Empresa();

            objEmpresa.setEndereco(objEndereco); //Utilizando o Método SET
            objEndereco = (Endereco) objEmpresa.getEndereco(); //Utilizando o Método GET

			Console.WriteLine("Retornando o Empresa.Endereco (Classe Endereco): {0},{1}",
												objEndereco.Logradouro, objEndereco.Numero);

		}
    }
}
