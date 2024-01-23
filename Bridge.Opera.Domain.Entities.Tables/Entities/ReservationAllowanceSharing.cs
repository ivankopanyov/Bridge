namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationAllowanceSharing
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal ToResvNameId { get; set; }
    public string ConsumeSharedAllowancesYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationAllowanceSharing>(entity =>
        {
            entity.HasKey(e => new { e.ResvNameId, e.Resort, e.ToResvNameId })
                .HasName("RAS_PK");

            entity.ToTable("RESERVATION_ALLOWANCE_SHARING");

            entity.HasIndex(e => new { e.ToResvNameId, e.Resort })
                .HasName("RAS_TORESV_RESORT_IDX");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToResvNameId)
                .HasColumnName("TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumeSharedAllowancesYn)
                .IsRequired()
                .HasColumnName("CONSUME_SHARED_ALLOWANCES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
