using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PosInfnetCidadesInteligentesDDD.Dominio.Entidades;
using PosInfnetCidadesInteligentesDDD.Infra.Dados.Repositorio;
using System;
using Xunit;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
            public void TestMethod1()
            {
                var repositorio = new Mock<RepositorioBase<EstacaoRecarga>>();

                var estacaoRecargaExpectativa = new EstacaoRecarga()
                {
                    Id = new Guid(),
                    Latitude = 10,
                    Longitude = 20,
                    Nome = "EstacaoSaoJose",
                    TipoEstacao = "EstacaoMovel"
                };

            repositorio.Setup(c => c.Adicionar(estacaoRecargaExpectativa)).Should().NotBeNull();
            }
        }
    }


