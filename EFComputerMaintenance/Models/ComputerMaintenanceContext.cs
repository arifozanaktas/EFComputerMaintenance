using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComputerMaintenance.Models;
public class ComputerMaintenanceContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DLOP8P5\SQLEXPRESS;Initial Catalog=EFComputerMaintenance;Integrated Security=True;Trust Server Certificate=True;");
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Staff> Staffs { get; set;}
    public DbSet<ServiceStatus> ServiceStatuses { get; set; }
    public DbSet<SparePart> SpareParts { get; set; }
    public DbSet<ServiceRecord> ServiceRecords { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
}
