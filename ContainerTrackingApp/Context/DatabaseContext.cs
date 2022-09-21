using ContainerTrackingApp.Models;
using System.Data.Entity;

namespace ContainerTrackingApp.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ContainerTrackingDBEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.Configuration.LazyLoadingEnabled = false;
             Database.SetInitializer<DatabaseContext>(null);
           // Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ShipmentInfo>().MapToStoredProcedures(p => p.Insert(sp => sp.HasName("Insert_Shipment_Details")));
        }
        public DbSet<CompanyMapping> CompanyMapping { get; set; }
        public DbSet<LAShippingMaster> LAShippingMaster { get; set; }
        public DbSet<OceanInsightShippingMaster> OceanInsightShippingMaster { get; set; }
        public DbSet<RegisterUser> RegisterUser { get; set; }
        public DbSet<RegisterCompany> RegisterCompany { get; set; }
        public DbSet<TokensManager> TokensManager { get; set; }
        public DbSet<ClientKey> ClientKeys { get; set; }
        public DbSet<ContainerTracking> ContainerTracking { get; set; }
        public DbSet<RequestDetail> RequestDetails { get; set; }
        public DbSet<ContainershipmentDetails> ContainershipmentDetails { get; set; }
        public DbSet<ExceptionDetail> ExceptionDetails { get; set; }
        public DbSet<RequestDetailHist> RequestDetailsHists { get; set; }
        public DbSet<ContainershipmentDetailHist> ContainershipmentDetailHists { get; set; }
        public DbSet<DivisionMaster> DivisionMasters { get; set; }
        public DbSet<EventPushReceiver> EventPushReceiver { get; set; }
        public DbSet<ShipmentInfo> ShipmentInfo { get; set; }
        public DbSet<EventInfo> EventInfo { get; set; }
        public DbSet<DetailsInfo> DetailsInfo { get; set; }
    }
}