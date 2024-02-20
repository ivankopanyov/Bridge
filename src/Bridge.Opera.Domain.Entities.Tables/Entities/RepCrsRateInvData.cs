namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepCrsRateInvData
{
    public decimal? OperaRequestId { get; set; }
    public string? RecordType { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? RoomType { get; set; }
    public string? RateCode { get; set; }
    public string? RateType { get; set; }
    public decimal? RoomsAllotted { get; set; }
    public decimal? RoomsSold { get; set; }
    public decimal? RoomsAvailable { get; set; }
    public decimal? Rate1 { get; set; }
    public decimal? Rate2 { get; set; }
    public decimal? Rate3 { get; set; }
    public decimal? Rate4 { get; set; }

    public virtual ExternalReportRequests OperaRequest { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepCrsRateInvData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REP_CRS_RATE_INV_DATA");

            entity.HasIndex(e => e.OperaRequestId)
                .HasName("REPCRS_EXTRR_FKI");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OperaRequestId)
                .HasColumnName("OPERA_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate1)
                .HasColumnName("RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate2)
                .HasColumnName("RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate3)
                .HasColumnName("RATE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate4)
                .HasColumnName("RATE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(1)
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

            entity.Property(e => e.RoomsAllotted)
                .HasColumnName("ROOMS_ALLOTTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsAvailable)
                .HasColumnName("ROOMS_AVAILABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsSold)
                .HasColumnName("ROOMS_SOLD")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ExternalReportRequests)))
				entity.Ignore(e => e.OperaRequest);
			else
	            entity.HasOne(d => d.OperaRequest)
	                .WithMany()
	                .HasForeignKey(d => d.OperaRequestId)
	                .HasConstraintName("REPCRS_EXTRR_FK");
        });
	}
}
