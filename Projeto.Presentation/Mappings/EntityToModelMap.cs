﻿using AutoMapper;
using Projeto.Data.Entities;
using Projeto.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mappings
{
    public class EntityToModelMap : Profile
    {
        //ctor
        public EntityToModelMap()
        {
            CreateMap<Funcionario, FuncionarioConsultaModel>();
        }
    }
}
