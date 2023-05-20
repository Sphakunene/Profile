using System;
using AutoMapper;
using Persons.dtos;
using Persons.Model;

namespace Persons.mapper
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Person, PersonResponse>();
            CreateMap<PersonRequest, Person>();
        }
    }
}