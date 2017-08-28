using Microsoft.Practices.Unity;
using SomethingToDo.Repositories.Event;
using SomethingToDo.Repositories.User;
using SomethingToDo.Services.Event;
using SomethingToDo.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.App_Start
{
    public class DependencyInjectionConfiguration
    {
        internal static UnityContainer Register()
        {
            var container = new UnityContainer();

            RegisterRepos(container);
            RegisterServices(container);

            return container;
        }

        private static void RegisterServices(UnityContainer container)
        {
            RegisterUserService(container);
            RegisterEventService(container);
        }

        private static void RegisterUserService(UnityContainer container)
        {
            container.RegisterType<IUserService, UserService>();
        }

        private static void RegisterEventService(UnityContainer container)
        {
            container.RegisterType<IEventService, EventService>();
        }

        private static void RegisterRepos(UnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IEventRepository, EventRepository>();
        }
    }
}