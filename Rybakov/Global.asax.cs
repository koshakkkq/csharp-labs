using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using Rybakov.Models;
using Rybakov.Logic;
namespace Rybakov
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new ProductDatabaseInitializer());
            // Создайте пользовательскую роль и пользователя.
            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();

        }
    }
}