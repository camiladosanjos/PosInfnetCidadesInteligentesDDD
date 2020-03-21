using PosInfnetCidadesInteligentesDDD.Aplicacao.Interfaces;
using PosInfnetCidadesInteligentesDDD.Dominio.Entidades;
using PosInfnetCidadesInteligentesDDD.Dominio.Interface;
using System;
using System.Collections.Generic;

namespace PosInfnetCidadesInteligentesDDD.Aplicacao.Aplicacoes
{
    public class EstacaoRecargaApp : IEstacaoRecargaApp
    {
        IEstacaoRecarga _estacaoRecargaInterface;

        public EstacaoRecargaApp(IEstacaoRecarga estacaoRecargaInterface)
        {
            _estacaoRecargaInterface = estacaoRecargaInterface;
        }

        public void Adicionar(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Adicionar(obj);
        }

        public void Atualizar(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Atualizar(obj);
        }

        public void Excluir(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Excluir(obj);
        }

        public IList<EstacaoRecarga> Listar()
        {
            return _estacaoRecargaInterface.Listar();
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _estacaoRecargaInterface.RecuperarPorId(id);
        }
    }
}
