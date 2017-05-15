using System;
namespace brCode.IoC_Sample.GetterAndSetter
{
    public interface IObjetoEndereco
    {
        #region Declarar Propriedades e Métodos

        string Logradouro{
            get;
            set;
        }

        int Numero{
			get;
			set;
        }

		#endregion
	}
}
