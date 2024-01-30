namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxAirRejects
{
    public decimal? RejectRecId { get; set; }
    public decimal? BatchId { get; set; }
    public DateTime? ImportDate { get; set; }
    public string? ImportStatus { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public string? MembershipCardNo { get; set; }
    public DateTime? ImportTrxDate { get; set; }
    public DateTime? AirlinePostDate { get; set; }
    public string? AirlineErrCode { get; set; }
    public string? AirlineErrDesc { get; set; }
    public decimal? MilesPoints { get; set; }
    public string? AirlineResortCode { get; set; }
    public string? OperaResortCode { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? ReviewStatus { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc04 { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }
    public string? Udfc10 { get; set; }
    public string? Udfc11 { get; set; }
    public string? Udfc12 { get; set; }
    public string? Udfc13 { get; set; }
    public string? Udfc14 { get; set; }
    public string? Udfc15 { get; set; }
    public string? Udfc16 { get; set; }
    public string? Udfc17 { get; set; }
    public string? Udfc18 { get; set; }
    public string? Udfc19 { get; set; }
    public string? Udfc20 { get; set; }
    public string? Udfc21 { get; set; }
    public string? Udfc22 { get; set; }
    public string? Udfc23 { get; set; }
    public string? Udfc24 { get; set; }
    public string? Udfc25 { get; set; }
    public string? Udfc26 { get; set; }
    public string? Udfc27 { get; set; }
    public string? Udfc28 { get; set; }
    public string? Udfc29 { get; set; }
    public string? Udfc30 { get; set; }
    public string? Udfc31 { get; set; }
    public string? Udfc32 { get; set; }
    public string? Udfc33 { get; set; }
    public string? Udfc34 { get; set; }
    public string? Udfc35 { get; set; }
    public string? Udfc36 { get; set; }
    public string? Udfc37 { get; set; }
    public string? Udfc38 { get; set; }
    public string? Udfc39 { get; set; }
    public string? Udfc40 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public decimal? Udfn06 { get; set; }
    public decimal? Udfn07 { get; set; }
    public decimal? Udfn08 { get; set; }
    public decimal? Udfn09 { get; set; }
    public decimal? Udfn10 { get; set; }
    public decimal? Udfn11 { get; set; }
    public decimal? Udfn12 { get; set; }
    public decimal? Udfn13 { get; set; }
    public decimal? Udfn14 { get; set; }
    public decimal? Udfn15 { get; set; }
    public decimal? Udfn16 { get; set; }
    public decimal? Udfn17 { get; set; }
    public decimal? Udfn18 { get; set; }
    public decimal? Udfn19 { get; set; }
    public decimal? Udfn20 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public DateTime? Udfd06 { get; set; }
    public DateTime? Udfd07 { get; set; }
    public DateTime? Udfd08 { get; set; }
    public DateTime? Udfd09 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public string? ImportErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxAirRejects>(entity =>
        {
            entity.HasKey(e => e.RejectRecId)
                .HasName("MTT_PK");

            entity.ToTable("MEMBERSHIP_TRX_AIR_REJECTS");

            entity.HasIndex(e => e.AirlineErrCode)
                .HasName("MEM_TRX_AIR_REJ_IDX3");

            entity.HasIndex(e => e.MembershipTrxId)
                .HasName("MEM_TRX_AIR_REJ_IDX2");

            entity.HasIndex(e => e.ReviewStatus)
                .HasName("MEM_TRX_AIR_REJ_IDX4");

            entity.HasIndex(e => new { e.BatchId, e.ImportStatus })
                .HasName("MEM_TRX_AIR_REJ_IDX1");

            entity.Property(e => e.RejectRecId)
                .HasColumnName("REJECT_REC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AirlineErrCode)
                .HasColumnName("AIRLINE_ERR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AirlineErrDesc)
                .HasColumnName("AIRLINE_ERR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AirlinePostDate)
                .HasColumnName("AIRLINE_POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AirlineResortCode)
                .HasColumnName("AIRLINE_RESORT_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportErrorDesc)
                .HasColumnName("IMPORT_ERROR_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ImportStatus)
                .IsRequired()
                .HasColumnName("IMPORT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImportTrxDate)
                .HasColumnName("IMPORT_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MilesPoints)
                .HasColumnName("MILES_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaResortCode)
                .HasColumnName("OPERA_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReviewStatus)
                .HasColumnName("REVIEW_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .IsUnicode(false);

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .IsUnicode(false);

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .IsUnicode(false);

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .IsUnicode(false);

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .IsUnicode(false);

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER");
        });
	}
}
