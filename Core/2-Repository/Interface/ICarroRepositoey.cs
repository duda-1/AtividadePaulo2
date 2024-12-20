﻿using Core._3_Entidade.DTOs;
using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._2_Repository.Interface
{
    public interface ICarroRepositoey
    {
        long AdicionarCarro(CreateCarroDTO carro);
        List<Carro> ListarCarro();
        void EditarCarro(Carro carro);
        void DeletarCarro(int id);
        Carro BuscarPorId(int id);
    }
}
