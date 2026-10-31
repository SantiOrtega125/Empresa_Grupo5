using Microsoft.EntityFrameworkCore;

public class EmpresaContext(DbContextOptions<EmpresaContext> options) : DbContext(options)
{
    public DbSet<Empresa.Models.Empleado> Empleado { get; set; } = default!;
}
