namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcKeys
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Track1 { get; set; }
    public string Track2 { get; set; }
    public decimal? KeyCount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string Track3 { get; set; }
    public decimal? KeyIfcId { get; set; }
    public decimal? SvIfcId { get; set; }
    public decimal? NameId { get; set; }
    public string CardLastname { get; set; }
    public string CardFirstname { get; set; }
    public string NopostYn { get; set; }
    public string KeyOptions { get; set; }
    public string KeyType { get; set; }
    public string InactiveYn { get; set; }
    public string SvYn { get; set; }
    public string DisplayYn { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public decimal? KeyNumber { get; set; }
    public string AdultChild { get; set; }
    public decimal? OrigCardLimit { get; set; }
    public decimal? CardBalance { get; set; }
    public string MobileRefid { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcKeys>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_KEYS");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("IFC_KEYS_RESV_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.Track2 })
                .HasName("IFC_KEYS_TRACK2_IDX");

            entity.Property(e => e.AdultChild)
                .HasColumnName("ADULT_CHILD")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CardBalance)
                .HasColumnName("CARD_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CardFirstname)
                .HasColumnName("CARD_FIRSTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CardLastname)
                .HasColumnName("CARD_LASTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyCount)
                .HasColumnName("KEY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyIfcId)
                .HasColumnName("KEY_IFC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyNumber)
                .HasColumnName("KEY_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyOptions)
                .HasColumnName("KEY_OPTIONS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.KeyType)
                .HasColumnName("KEY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MobileNumber)
                .HasColumnName("MOBILE_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MobileRefid)
                .HasColumnName("MOBILE_REFID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NopostYn)
                .HasColumnName("NOPOST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrigCardLimit)
                .HasColumnName("ORIG_CARD_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SvIfcId)
                .HasColumnName("SV_IFC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SvYn)
                .HasColumnName("SV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Track1)
                .HasColumnName("TRACK1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Track2)
                .HasColumnName("TRACK2")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Track3)
                .HasColumnName("TRACK3")
                .HasMaxLength(2000)
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
