namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepCrsRateInvCompareData
{
    public decimal OperaRequestId { get; set; }
    public string DataSource { get; set; }
    public string RecordType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string RoomType { get; set; }
    public string RateCode { get; set; }
    public string ClosedYn { get; set; }
    public decimal? Auth { get; set; }
    public decimal? Blocked { get; set; }
    public decimal? Sold { get; set; }
    public string CtaYn { get; set; }
    public decimal? MinLos { get; set; }
    public decimal? SellLimit { get; set; }
    public decimal? SellMinLos { get; set; }

    public virtual ExternalReportRequests OperaRequest { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepCrsRateInvCompareData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REP_CRS_RATE_INV_COMPARE_DATA");

            entity.HasIndex(e => e.OperaRequestId)
                .HasName("REPCRSD_ERR_FKI");

            entity.Property(e => e.Auth)
                .HasColumnName("AUTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Blocked)
                .HasColumnName("BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosedYn)
                .HasColumnName("CLOSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CtaYn)
                .HasColumnName("CTA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DataSource)
                .IsRequired()
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinLos)
                .HasColumnName("MIN_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaRequestId)
                .HasColumnName("OPERA_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellLimit)
                .HasColumnName("SELL_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellMinLos)
                .HasColumnName("SELL_MIN_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ExternalReportRequests)))
				entity.Ignore(e => e.OperaRequest);
			else
	            entity.HasOne(d => d.OperaRequest)
	                .WithMany()
	                .HasForeignKey(d => d.OperaRequestId)
	                .HasConstraintName("REPCRSD_ERR_FK");
        });
	}
}
