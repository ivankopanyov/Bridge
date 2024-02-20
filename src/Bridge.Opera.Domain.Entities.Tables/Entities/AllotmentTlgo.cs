namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentTlgo
{
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public string? Type { get; set; }
    public string? Code { get; set; }
    public string? Value { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OtherRevenueAmount { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual TlgoConfig TlgoConfig { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentTlgo>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentHeaderId, e.Resort, e.Type, e.Code })
                .HasName("ALLOTMENT_TLGO_PK");

            entity.ToTable("ALLOTMENT_TLGO");

            entity.HasIndex(e => new { e.Type, e.Code })
                .HasName("ALLOTMENT_TLGO_CONFIG_FKI");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueAmount)
                .HasColumnName("OTHER_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentTlgo)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("ALLOTMENT_TLGO_AH_FK");

			if (!types.Contains(typeof(TlgoConfig)))
				entity.Ignore(e => e.TlgoConfig);
			else
	            entity.HasOne(d => d.TlgoConfig)
	                .WithMany(p => p.AllotmentTlgo)
	                .HasForeignKey(d => new { d.Type, d.Code })
	                .HasConstraintName("ALLOTMENT_TLGO_CONFIG_FK");
        });
	}
}
