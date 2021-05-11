using Xunit;
using CadastroCliente;

namespace CadastroClienteTests
{
    public class ClienteTests
    {
        [Theory]
        [InlineData(18)]
        [InlineData(19)]
        [InlineData(30)]
        public void ClienteValidacao_DeveSerMaiorDeIdade(int idade)
        {
            Assert.True(ClienteValidacao.ClienteMaiorIdade(idade));
        }

        [Theory]
        [InlineData(17)]
        [InlineData(16)]
        [InlineData(10)]
        [InlineData(61)]
        [InlineData(60)]
        public void ClienteValidacao_NaoDeveSerMaiorDeIdade(int idade)
        {
            Assert.False(ClienteValidacao.ClienteMaiorIdade(idade));
        }
    }
}
