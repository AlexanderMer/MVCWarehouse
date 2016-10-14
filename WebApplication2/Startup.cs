using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication2.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication2.Startup))]
namespace WebApplication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesAndAdmin();
        }

        // Creates default user roles and Admin user for login
        private void createRolesAndAdmin()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Create Admin role and Admin User "Alexander"
            if (roleManager.RoleExists("Admin") == false)
            {
                // Create "Admin" Role
                var role = new IdentityRole() { Name = "Admin"};
                roleManager.Create(role);

                // Create "Admin" Alexander who will have ability to add and remove users of Roles "Manager" and "Distributor"
                var user = new ApplicationUser() { UserName="Alexander", Email = "alexandermerabov@gmail.com" };
                string userPWD = "Alexander1994";

                var tempUser = userManager.Create(user, userPWD);

                // Add default user to Role "Admin"
                if (tempUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                    context.SaveChanges();
                }
            }

            // Creating "Manager" Role
            if (roleManager.RoleExists("Manager") == false)
            {
                var role = new IdentityRole() { Name = "Manager" };
                roleManager.Create(role);
            }

            // Creating "Distributor" Role
            if (roleManager.RoleExists("Distributor") == false)
            {
                var role = new IdentityRole() { Name = "Distributor"};
                roleManager.Create(role);
            }
        }
    }
}
