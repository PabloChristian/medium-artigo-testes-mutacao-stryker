using System;

namespace CadastroCliente
{
    public static class ClienteValidacao
    {
        public static bool ClienteMaiorIdade(int idade)
        {
            return idade >= 18 && idade < 60;
        }
    }
}
