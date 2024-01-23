namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRentalContracts
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal OwnerRevShare { get; set; }
    public string RevShareFormula { get; set; }
    public decimal CommByOwner { get; set; }
    public DateTime? AutoRenewalDate { get; set; }
    public decimal? AutoRenewalMonths { get; set; }
    public decimal? ResMaxNights { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string LongTermYn { get; set; }
    public decimal? GraceMonths { get; set; }
    public string RevenuePool { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRentalContracts>(entity =>
        {
            entity.ToTable("OVOS_RENTAL_CONTRACTS");

            entity.HasIndex(e => new { e.Resort, e.AutoRenewalDate })
                .HasName("ORC_IDX1");

            entity.HasIndex(e => new { e.Resort, e.ContractId, e.BeginDate, e.EndDate })
                .HasName("ORC_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.RevenuePool, e.EndDate, e.BeginDate })
                .HasName("ORC_IDX2");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoRenewalDate)
                .HasColumnName("AUTO_RENEWAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AutoRenewalMonths)
                .HasColumnName("AUTO_RENEWAL_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommByOwner)
                .HasColumnName("COMM_BY_OWNER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GraceMonths)
                .HasColumnName("GRACE_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LongTermYn)
                .HasColumnName("LONG_TERM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OwnerRevShare)
                .HasColumnName("OWNER_REV_SHARE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResMaxNights)
                .HasColumnName("RES_MAX_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevShareFormula)
                .IsRequired()
                .HasColumnName("REV_SHARE_FORMULA")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RevenuePool)
                .HasColumnName("REVENUE_POOL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
