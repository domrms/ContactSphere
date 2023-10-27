using Adapter.Interfaces;
using Adapter.Interfaces.Contato;
using Adapter.Interfaces.Usuario;
using Adapter.Map.Contato;
using Adapter.Map.Usuario;
using Adapter.Utils;
using Application.Interface.Contato;
using Application.Interface.Usuario;
using Application.Service.Contato;
using Application.Service.Usuario;
using Application.Validator.Contato;
using Application.Validator.Usuario;
using Autofac;
using Core.Interface.Repository.Contato;
using Core.Interface.Repository.Usuario;
using Core.Interface.Services.Contato;
using Core.Interface.Services.Usuario;
using Repository.Repositories.Contato;
using Repository.Repositories.Usuario;
using Services.Services.Contato;
using Services.Services.Usuario;

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