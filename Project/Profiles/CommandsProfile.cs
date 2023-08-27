using AutoMapper;
using Project.Dtos;
using Project.Models;

namespace Project.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile() 
        {
            //source -> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }    
    }
}
