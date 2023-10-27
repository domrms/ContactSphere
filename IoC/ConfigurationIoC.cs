using Adapter.Interfaces;
using Adapter.Map;
using Adapter.Utils;
using Application.Interface;
using Application.Service;
using Application.Validator;
using Autofac;
using Core.Interface;
using Core.Interface.Repository;
using Core.Interface.Services;
using Repository.Repositories;
using Services.Services;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
            builder.RegisterType<ServiceContato>().As<IServiceContato>();
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            builder.RegisterType<RepositoryContato>().As<IRepositoryContato>();
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();
            builder.RegisterType<MapperContato>().As<IMapperContato>();
            builder.RegisterType<ApplicationUsuario>().As<IApplicationUsuario>();
            builder.RegisterType<ApplicationContato>().As<IApplicationContato>();
            builder.RegisterType<ValidacaoUsuario>().As<IValidacaoUsuario>();
            builder.RegisterType<ValidacaoContato>().As<IValidacaoContato>();
            builder.RegisterType<AuthenticateService>().As<IAuthenticateService>();
        }
    }
}