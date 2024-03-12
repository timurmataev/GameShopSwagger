using Microsoft.EntityFrameworkCore;
using GameShopSwaggerUI2.Objects;

namespace GameShopSwaggerUI.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<GameForDataBase> Games { get; set; }


}
