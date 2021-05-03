using System;
using Xunit;
using CadastroCliente;

namespace CadastroClienteTests
{
    public class ClienteTests
    {
        [Fact]
        public void ClienteValidacao_DeveSerMaiorDeIdade()
        {
            Assert.True(ClienteValidacao.DeveSerMaiorDeIdade(10));
        }
    }
}
