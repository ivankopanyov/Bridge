namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateCodeNegSecurity
{
    public string GdsHost { get; set; }
    public string NegRateCode { get; set; }
    public string GdsRateCode { get; set; }
    public decimal NameId { get; set; }
    public string Resort { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ActivateYn { get; set; }
    public string Corporateid { get; set; }
    public decimal? GdsRateCodeOrder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateCodeNegSecurity>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_RATE_CODE_NEG_SECURITY");

            entity.HasIndex(e => e.NameId)
                .HasName("GDS_RATE_CODE_NEG_SECUR_IND4");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.Corporateid })
                .HasName("GDS_RATE_CODE_NEG_SECUR_IND3");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.GdsRateCode })
                .HasName("GDS_RATE_CODE_NEG_SECUR_IND1");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.NegRateCode })
                .HasName("GDS_RATE_CODE_NEG_SECUR_IND2");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.GdsRateCode, e.NegRateCode })
                .HasName("GDS_RATE_CODE_NEG_SECUR_IND5");

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Corporateid)
                .IsRequired()
                .HasColumnName("CORPORATEID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateCode)
                .IsRequired()
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateCodeOrder)
                .HasColumnName("GDS_RATE_CODE_ORDER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.NegRateCode)
                .IsRequired()
                .HasColumnName("NEG_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
        });
	}
}
