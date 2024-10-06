using Microsoft.EntityFrameworkCore;
using OrdemDeServico.Models;

namespace OrdemDeServico.Data; 
public class OrdemContext : DbContext {

    public OrdemContext(DbContextOptions<OrdemContext> opts) : base(opts) {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<FormServidor> FormsServidores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FormServidor>().HasIndex(f => f.Protocolo).IsUnique();
    }
}
