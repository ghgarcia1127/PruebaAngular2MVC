

namespace Gallery.Core
{
    using Model.Repositories;
    using Microsoft.Practices.Unity;
    using Data.Repositories;
    using Data;
    using IServices;
    using Services;

    public class ContainerBootstrapper
    {
        private static IUnityContainer container;

        private ContainerBootstrapper()
        {

        }

        public static void TypesRegister(IUnityContainer unityContainer, LifetimeManager lifeTimeManager)
        {
            container = unityContainer;

            var manager = lifeTimeManager == null ? new PerResolveLifetimeManager() : lifeTimeManager;

            container.RegisterType(typeof(GalleryContext), manager);

            RepositoriesRegister();

            ServicesRegister();

            MappingsRegister();
        }

        private static void MappingsRegister()
        {

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Dtos.Collection, Model.Collection>();
                cfg.CreateMap<Model.Collection, Dtos.Collection>();
                cfg.CreateMap<Dtos.Painting, Model.Painting>();
                cfg.CreateMap<Model.Painting, Dtos.Painting>();
            });
        }

        private static void RepositoriesRegister()
        {
            container.RegisterType<ICollectionRepository, CollectionRepository>(
                new InjectionFactory((c, t, s) => new CollectionRepository(container.Resolve<GalleryContext>())));

            container.RegisterType<IPaintingRepository, PaintingRepository>(
                new InjectionFactory((c, t, s) => new PaintingRepository(container.Resolve<GalleryContext>())));

        }


        private static void ServicesRegister()
        {

            container.RegisterType<ICollectionService, CollectionService>(
                new InjectionFactory((c, t, s) => new CollectionService(container.Resolve<ICollectionRepository>())));

            container.RegisterType<IPaintingService, PaintingService>(
               new InjectionFactory((c, t, s) => new PaintingService(container.Resolve<IPaintingRepository>())));

        }

        public static T GetType<T>()
        {
            return container.Resolve<T>();
        }
    }
}
