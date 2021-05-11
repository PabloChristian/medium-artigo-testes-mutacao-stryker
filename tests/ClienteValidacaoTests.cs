using Xunit;
using CadastroCliente;
using FluentAssertions;

namespace CadastroClienteTests
{
    public class ClienteValidacaoTests
    {
        [Theory]
        [InlineData(18)]
        [InlineData(19)]
        [InlineData(30)]
        public void DeveSerMaiorIdade(int idade)
        {
            ClienteValidacao.ClienteMaiorIdade(idade).Should().BeTrue();
        }

        [Theory]
        [InlineData(17)]
        [InlineData(16)]
        [InlineData(10)]
        [InlineData(61)]
        public void NaoDeveSerMaiorIdade(int idade)
        {
            ClienteValidacao.ClienteMaiorIdade(idade).Should().BeFalse();
        }
    }
}
