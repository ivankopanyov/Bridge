namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateHeaderNegotiated
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string? CommissionCode { get; set; }
    public string? IfcCreatedYn { get; set; }
    public string? CaId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? DatabaseId { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual Name Name { get; set; }
    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateHeaderNegotiated>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RATE_HEADER_NEGOTIATED");

            entity.HasIndex(e => e.CaId)
                .HasName("RATE_HEADER_NEGOTIATED_N2");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("RATE_HEADER_NEGOTIATED_AH_FKI");

            entity.HasIndex(e => new { e.NameId, e.Resort })
                .HasName("RATE_HEADER_NEGOTIATED_N1");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.NameId, e.BeginDate, e.EndDate })
                .HasName("RATE_HEADER_NEG_UK")
                .IsUnique();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CaId)
                .HasColumnName("CA_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql(@"null");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IfcCreatedYn)
                .HasColumnName("IFC_CREATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER(20)")
                .HasDefaultValueSql(@"1");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany()
	                .HasForeignKey(d => d.NameId)
	                .HasConstraintName("RATE_HEADER_NEG_SECURITY_FK2");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany()
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("NEG_RATE_HDR_AH_FK");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NEGOTIATED_RATE_HEADER_FK");
        });
	}
}
