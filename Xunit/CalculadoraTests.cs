using Xunit;
using MiLibreria;

namespace Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Sumar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Sumar(3, 2);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Restar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Restar(5, 3);

            // Assert
            Assert.Equal(2, resultado);
        }
    }
}
