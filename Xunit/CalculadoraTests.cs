using Xunit;
using MiLibreria;

namespace Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Sumar_NumerosNegativos_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Sumar(-3, -2);

            // Assert
            Assert.Equal(-5, resultado);
        }

        [Fact]
        public void Restar_NumerosNegativos_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Restar(-5, -3);

            // Assert
            Assert.Equal(-2, resultado);
        }

        [Fact]
        public void Sumar_NumeroPositivoYNegativo_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Sumar(5, -3);

            // Assert
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Restar_NumeroPositivoYNegativo_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Restar(5, -3);

            // Assert
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Sumar_ConCero_RetornaElOtroNumero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Sumar(0, 7);

            // Assert
            Assert.Equal(7, resultado);
        }

        [Fact]
        public void Restar_ConCero_RetornaElOtroNumero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Restar(0, 7);

            // Assert
            Assert.Equal(-7, resultado);
        }

        [Fact]
        public void Restar_DosNumerosIguales_RetornaCero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Restar(5, 5);

            // Assert
            Assert.Equal(0, resultado);
        }




    }
}
