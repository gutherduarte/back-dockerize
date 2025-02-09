﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioMovimiento<TEntidad, TEntidadID>
           : IAgregar<TEntidad>, IListar<TEntidad, TEntidadID>, ITransaccion
    {

        void Anular(TEntidadID entidadId);

    }
}
