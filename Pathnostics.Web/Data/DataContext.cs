using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pathnostics.Web.Data.Entities;

namespace Pathnostics.Web.Data;

public sealed class DataContext : IdentityDbContext<ApplicationUser, IdentityRole<long>, long>
{
    public DataContext (DbContextOptions<DataContext> options)
        : base(options)
    {
        Database.Migrate();
    }

    public DbSet<Application> Applications { get; set; } = null!;
    public DbSet<Clinic> Clinics { get; set; } = null!;
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<CustomerPatient> CustomerPatients { get; set; } = null!;
    public DbSet<SampleData> SampleDatas { get; set; } = null!;
}