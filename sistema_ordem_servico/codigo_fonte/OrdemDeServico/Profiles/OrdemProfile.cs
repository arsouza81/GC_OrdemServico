using AutoMapper;
using OrdemDeServico.Dtos;
using OrdemDeServico.Models;

namespace OrdemDeServico.Profiles; 
public class OrdemProfile :Profile {

    public OrdemProfile() {

        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
        CreateMap<User, ReadUserDto>();

        CreateMap<CreateFormServidorDto, FormServidor>();
        CreateMap<UpdateFormServidorDto, FormServidor>();
        CreateMap<FormServidor, ReadFormServidorDto>();
    }
}
