using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using System;

namespace PosInfnetCidadesInteligentes.Dados.Testes
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repositorio = new RepositorioBase\();

            var estacaoRecargaExpectativa = new EstacaoRecarga()
            {
                Id = new Guid(),
                Latitude = 10,
                Longitude = 20,
                Nome = "EstacaoSaoJose",
                TipoEstacao = "EstacaoMovel"
            };

        }
    }
}
