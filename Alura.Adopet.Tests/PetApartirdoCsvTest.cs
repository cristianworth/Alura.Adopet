using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Tests
{
    public class PetApartirdoCsvTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornarUmPet() 
        {
            // Arrange
            var linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

            // Act
            var pet = linha.ConverteDoTexto();

            // Assert
            Assert.NotNull(pet);
        }
    }
}
