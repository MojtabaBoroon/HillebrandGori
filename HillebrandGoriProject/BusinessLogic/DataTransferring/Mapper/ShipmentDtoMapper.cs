using AutoMapper;
using ShipmentApp.DataTransferring.Shipments;
using ShipmentApp.DomainModels.Shipments;

namespace ShipmentApp.DataTransferring.Mapper
{
    public class ShipmentDtoMapper : Profile
    {
        public ShipmentDtoMapper()
        {
            CreateMap<ShipmentDto, Shipment>().ReverseMap();
            CreateMap<EmissionDto, Emission>().ReverseMap();
            CreateMap<EquipmentDto, Equipment>().ReverseMap();
            CreateMap<FavouriteDto, Favourite>().ReverseMap();
            CreateMap<ItemDto, Item>().ReverseMap();
            CreateMap<LastEventDto, LastEvent>().ReverseMap();
            CreateMap<LinkDto, Link>().ReverseMap();
            CreateMap<PagingInfoDto, PagingInfo>().ReverseMap();
            CreateMap<ReferencesDto, References>().ReverseMap();
            CreateMap<ResourcesDto, Resources>().ReverseMap();
            CreateMap<ShipLocationDto, ShipLocation>().ReverseMap();
            CreateMap<TemplateVariableDto, TemplateVariable>().ReverseMap();
            CreateMap<TransportReferenceDto, TransportReference>().ReverseMap();
        }
    }
}
