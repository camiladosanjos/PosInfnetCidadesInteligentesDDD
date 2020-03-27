using Microsoft.VisualStudio.TestTools.UnitTesting;
using PosInfnetCidadesInteligentesDDD.Dominio.Entidades;
using PosInfnetCidadesInteligentesDDD.Infra.Dados.Repositorio;
using System;

namespace TestesDominio
{
    [TestClass]
    public class CrudTests
    {
        [TestMethod]
        public void AdicionarEstacaoRecarga()
        {
            var estacaoRecarga = new EstacaoRecarga()
            {
                Id = new Guid(),
                Latitude = 10,
                Longitude = 20,
                Nome = "EstacaoSaoJose",
                TipoEstacao = "EstacaoMovel"
            };

            new RepositorioBase<EstacaoRecarga>()
                .Adicionar(estacaoRecarga);
        }

        [TestMethod]
        public void AtualizarEstacaoRecarga()
        {
            var estacaoRecarga = new EstacaoRecarga()
            {
                Id = new Guid(),
                Latitude = 10,
                Longitude = 20,
                Nome = "EstacaoSaoJose",
                TipoEstacao = "EstacaoMovel"
            };

            new RepositorioBase<EstacaoRecarga>()
                .Atualizar(estacaoRecarga);
        }

        [TestMethod]
        public void listarEstacaoRecarga()
        {
            new RepositorioBase<EstacaoRecarga>()
                .Listar();
        }
    }
}

