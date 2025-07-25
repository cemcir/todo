using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Business.Constants.Abstract;
using Business.Constants.Concrete;
using Castle.DynamicProxy;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Context
            builder.RegisterType<ProjectContext>()
                   .As<DbContext>()
                   .InstancePerLifetimeScope();

            // Sabit DI kayıtları (servisler ve Dallar)

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<TodoManager>().As<ITodoService>();
            builder.RegisterType<EfTodoDal>().As<ITodoDal>();

            builder.RegisterType<TurkishMessage>().As<IMessage>();

            // Generic repository DI (EfEntityRepositoryBase)
            builder.RegisterGeneric(typeof(EfEntityRepositoryBase<,>))
                   .As(typeof(IEntityRepository<>))
                   .InstancePerLifetimeScope();

            // Interceptor ayarları
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
