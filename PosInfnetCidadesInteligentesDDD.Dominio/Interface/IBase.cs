using System;
using System.Collections.Generic;

namespace PosInfnetCidadesInteligentesDDD.Dominio.Interface
{
    public interface IBase<T>
    {
        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Atualizar(T obj);
        void Excluir(T obj);
        IList<T> Listar();
    }
}