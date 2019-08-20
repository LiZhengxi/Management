namespace ManagementForm.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ManagementDbContext : DbContext
    {

        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“ManagementDbContext”
        //连接字符串。

        public ManagementDbContext()
            : base("name=ManagementDbContext") //  Connection string name 
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Altelier> Alteliers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ManagementDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}