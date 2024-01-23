namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtPosRevenueCenter
{
    public string RevCenter { get; set; }
    public string Resort { get; set; }
    public string RevCenterDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? NumOfTables { get; set; }
    public decimal? AutoSvcCharge { get; set; }
    public string MasterRevCenter { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtPosRevenueCenter>(entity =>
        {
            entity.HasKey(e => new { e.RevCenter, e.Resort })
                .HasName("EXT_POS_REVCENT_PK");

            entity.ToTable("EXT_POS_REVENUE_CENTER");

            entity.Property(e => e.RevCenter)
                .HasColumnName("REV_CENTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AutoSvcCharge)
                .HasColumnName("AUTO_SVC_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MasterRevCenter)
                .HasColumnName("MASTER_REV_CENTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumOfTables)
                .HasColumnName("NUM_OF_TABLES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevCenterDesc)
                .IsRequired()
                .HasColumnName("REV_CENTER_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
