namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MassRateRef
{
    public decimal? MassRateRefId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Nights { get; set; }
    public string? RoomType { get; set; }
    public decimal? Rooms { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? RateCode { get; set; }
    public string? DepositRule { get; set; }
    public decimal? DepositPaid { get; set; }
    public decimal? DepositReq { get; set; }
    public decimal? RefreshedNights { get; set; }
    public decimal? PreviousTotal { get; set; }
    public decimal? NewTotal { get; set; }
    public string? TaggedYn { get; set; }
    public string? ProcessedYn { get; set; }
    public string? CorrespType { get; set; }
    public string? CorrespAddress { get; set; }
    public string? CorrespStatus { get; set; }
    public string? ErrCondition { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MassRateRef>(entity =>
        {
            entity.HasKey(e => new { e.MassRateRefId, e.Resort, e.ResvNameId })
                .HasName("MASS_RATE_REF_PK");

            entity.ToTable("MASS_RATE_REF");

            entity.Property(e => e.MassRateRefId)
                .HasColumnName("MASS_RATE_REF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CorrespAddress)
                .HasColumnName("CORRESP_ADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CorrespStatus)
                .HasColumnName("CORRESP_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CorrespType)
                .HasColumnName("CORRESP_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DepositPaid)
                .HasColumnName("DEPOSIT_PAID")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.DepositReq)
                .HasColumnName("DEPOSIT_REQ")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.DepositRule)
                .HasColumnName("DEPOSIT_RULE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ErrCondition)
                .HasColumnName("ERR_CONDITION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewTotal)
                .HasColumnName("NEW_TOTAL")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.PreviousTotal)
                .HasColumnName("PREVIOUS_TOTAL")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.ProcessedYn)
                .IsRequired()
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RefreshedNights)
                .HasColumnName("REFRESHED_NIGHTS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.TaggedYn)
                .IsRequired()
                .HasColumnName("TAGGED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");
        });
	}
}
