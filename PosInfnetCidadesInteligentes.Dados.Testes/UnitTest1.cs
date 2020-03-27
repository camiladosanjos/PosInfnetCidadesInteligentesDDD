using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PosInfnetCidadesInteligentesDDD.Dominio.Entidades;
using PosInfnetCidadesInteligentesDDD.Infra.Dados.Repositorio;
using System;

namespace PosInfnetCidadesInteligentes.Dados.Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repositorio = new Mock <RepositorioBase<EstacaoRecarga>>();

            var estacaoRecargaExpectativa = new EstacaoRecarga()
            {
                Id = new Guid(),
                Latitude = 10,
                Longitude = 20,
                Nome = "EstacaoSaoJose",
                TipoEstacao = "EstacaoMovel"
            };

            var resultado = repositorio.Setup(c => c.Adicionar(estacaoRecargaExpectativa));

            var estacaoRecargaEncontrada = estacaoRecargaExpectativa.Nome;
            resultado.Should().NotBeNull();
            resultado.Should().Be(estacaoRecargaEncontrada);
            

        }
    }
}
