using Adapter.Interfaces;
using Adapter.Map;
using Application.Interface;
using Application.Service;
using Application.Validator;
using Autofac;
using Core.Interface;
using Core.Interface.Services;
using Repository.Repositories;
using Services.Services;
using Utils;
using Utils._4._1_Interface;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();
            builder.RegisterType<ApplicationUsuario>().As<IApplicationUsuario>();
            builder.RegisterType<ValidacaoUsuario>().As<IValidacaoUsuario>();
            builder.RegisterType<AuthenticateService>().As<IAuthenticateService>();

        }
    }
}
