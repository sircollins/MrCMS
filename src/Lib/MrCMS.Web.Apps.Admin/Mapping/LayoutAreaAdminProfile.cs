﻿using AutoMapper;
using MrCMS.Entities.Documents.Layout;
using MrCMS.Web.Apps.Admin.Models;

namespace MrCMS.Web.Apps.Admin.Mapping
{
    public class LayoutAreaAdminProfile : Profile
    {
        public LayoutAreaAdminProfile()
        {
            //CreateMap<LayoutArea, UpdateLayoutModel>().ReverseMap();
            CreateMap<LayoutArea, AddLayoutAreaModel>().ReverseMap();
                //.ForMember(x => x.Layout, expression => expression.ResolveUsing<LayoutAreaLayoutResolver>())
                ;
            CreateMap<LayoutArea, UpdateLayoutAreaModel>().ReverseMap();
        }
    }
}