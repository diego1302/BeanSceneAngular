using Microsoft.EntityFrameworkCore;

namespace BeanSceneAngular.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {
            
        }
    }
}
