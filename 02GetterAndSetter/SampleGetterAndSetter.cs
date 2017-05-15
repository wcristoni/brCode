using System;
namespace brCode.IoC_Sample.GetterAndSetter
{
    public class SampleGetterAndSetter
    {
		public SampleGetterAndSetter()
        {
            // ---------------------------------------
            // Implementação Original
            // ---------------------------------------

            // Implementando Empresa, com o objeto Endereco

            Endereco objEndereco = new Endereco();

            objEndereco.Logradouro = "Rua Teste 02";
            objEndereco.Numero = 10;

            Empresa objEmpresa = new Empresa();
            objEmpresa.Endereco = objEndereco; // usando o SET


            objEndereco = (Endereco) objEmpresa.Endereco; // usando o GET

            Console.WriteLine("Retornando o Empresa.Endereco (Classe Endereco): {0},{1}",
                                                objEndereco.Logradouro, objEndereco.Numero);
            
		}
    }
}
