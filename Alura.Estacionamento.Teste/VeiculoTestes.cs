using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Teste
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]

        public void TestaVeiculoFrear()
        {
            //Arrange
            var veiculo = new Veiculo();
            //act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void VeiculoTeste()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
          
            //Assert
            Assert.Equal(TipoVeiculo.Automovel,veiculo.Tipo);
        }
    }
}
