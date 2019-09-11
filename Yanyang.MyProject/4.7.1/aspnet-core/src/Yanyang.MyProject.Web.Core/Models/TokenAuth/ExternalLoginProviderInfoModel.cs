﻿using Abp.AutoMapper;
using Yanyang.MyProject.Authentication.External;

namespace Yanyang.MyProject.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
