using Alura.Adopet.Console.Servicos;
using System;
using Xunit;

namespace Alura.Adopet.Tests
{
    public class HttpClientPetTest
    {
        [Fact]
        public void ListaPetsDeveRetornarUmaListaNaoVazia()
        {
            // Arange
            var clientPet = new HttpClientPet();

            // Act
            var petList = clientPet.ListPetsAsync();

            // Assert
            Assert.NotNull(petList);
            // Assert.NotEmpty(petList);
        }

        [Fact]
        public async void QuandoApiForaDeveRetornarUmaExcecao()
        {
            // Arange
            var clientPet = new HttpClientPet(uri: "http://localhost:1111");

            // Act and Assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientPet.ListPetsAsync());
        }
    }
}
