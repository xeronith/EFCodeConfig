using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServerCompact;

namespace EFCodeConfig.Models
{
    [DbConfigurationType(typeof(ModelConfiguration))]
    class Model : DbContext
    {
        public Model() : base("Database") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        class ModelConfiguration : DbConfiguration
        {
            public ModelConfiguration()
            {
                SetProviderServices(SqlCeProviderServices.ProviderInvariantName, SqlCeProviderServices.Instance);
                SetDefaultConnectionFactory(new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0"));
            }
        }
    }
}
