using AutoMapper;
using PDex.Application.Pokemon;
using PDex.Domain.Entities;

namespace PDex.Application.Mappings
{
    public class PokemonMappingProfile : Profile
    {
        public PokemonMappingProfile()
        {
            CreateMap<PokemonDto, Domain.Entities.Pokemon>()
                .ForMember(e => e.Name, opt => opt.MapFrom(src => new PokemonName()
                {
                    English = src.NameEnglish,
                    Japanese = src.NameJapanese,
                    Chinese = src.NameChinese,
                    French = src.NameFrench,
                }))
                .ForMember(e => e.Stats, opt => opt.MapFrom(src => new PokemonStats()
                {
                    HP = src.HP,
                    Attack = src.Attack,
                    Defense = src.Defense,
                    SpAttack = src.SpAttack,
                    SpDefense = src.SpDefense,
                    Speed = src.Speed,
                }));

            CreateMap<Domain.Entities.Pokemon, PokemonDto>()
                .ForMember(dto => dto.NameEnglish, opt => opt.MapFrom(src => src.Name.English))
                .ForMember(dto => dto.NameJapanese, opt => opt.MapFrom(src => src.Name.Japanese))
                .ForMember(dto => dto.NameChinese, opt => opt.MapFrom(src => src.Name.Chinese))
                .ForMember(dto => dto.NameFrench, opt => opt.MapFrom(src => src.Name.French))
                .ForMember(dto => dto.HP, opt => opt.MapFrom(src => src.Stats.HP))
                .ForMember(dto => dto.Attack, opt => opt.MapFrom(src => src.Stats.Attack))
                .ForMember(dto => dto.Defense, opt => opt.MapFrom(src => src.Stats.Defense))
                .ForMember(dto => dto.SpAttack, opt => opt.MapFrom(src => src.Stats.SpAttack))
                .ForMember(dto => dto.SpDefense, opt => opt.MapFrom(src => src.Stats.SpDefense))
                .ForMember(dto => dto.Speed, opt => opt.MapFrom(src => src.Stats.Speed));
        }
    }
}
