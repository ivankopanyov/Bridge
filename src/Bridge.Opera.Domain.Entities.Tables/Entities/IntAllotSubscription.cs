namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntAllotSubscription
{
    public decimal? AllotmentId { get; set; }
    public string? Resort { get; set; }
    public string? InterfaceId { get; set; }
    public string? ExternalReference { get; set; }
    public string? Udfc01 { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ExtAllotmentId { get; set; }
    public string? ExchangeYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntAllotSubscription>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentId, e.Resort, e.InterfaceId })
                .HasName("INT_ALLOT_SUBSCRIBE_PK");

            entity.ToTable("INT_ALLOT_SUBSCRIPTION");

            entity.HasIndex(e => new { e.Resort, e.InterfaceId, e.ExtAllotmentId })
                .HasName("INT_ALLOT_SUBSCRIBE_IDX1");

            entity.Property(e => e.AllotmentId)
                .HasColumnName("ALLOTMENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangeYn)
                .HasColumnName("EXCHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtAllotmentId)
                .HasColumnName("EXT_ALLOTMENT_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(120)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(500)
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
