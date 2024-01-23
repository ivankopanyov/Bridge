namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateCodeTemplate
{
    public string RateCode { get; set; }
    public string Description { get; set; }
    public decimal? Lvl { get; set; }
    public string GroupCode { get; set; }
    public DateTime BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public decimal? DisplaySeq { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ExternalValue { get; set; }
    public string ChainCode { get; set; }
    public string NegotiatedYn { get; set; }
    public string MfnUploadYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateCodeTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RateCode });

            entity.ToTable("RATE_CODE_TEMPLATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalValue)
                .HasColumnName("EXTERNAL_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Lvl)
                .HasColumnName("LVL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MfnUploadYn)
                .HasColumnName("MFN_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedYn)
                .HasColumnName("NEGOTIATED_YN")
                .HasMaxLength(1)
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
