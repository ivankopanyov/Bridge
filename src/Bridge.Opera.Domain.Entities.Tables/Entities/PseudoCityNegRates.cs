namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PseudoCityNegRates
{
    public string GdsHost { get; set; }
    public string ChainCode { get; set; }
    public string GdsRateCode { get; set; }
    public string PseudoCityCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string Status { get; set; }

    public virtual PseudoCityCodes PseudoCityCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PseudoCityNegRates>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.ChainCode, e.GdsRateCode, e.PseudoCityCode })
                .HasName("PSEUDO_CITY_NEG_RATES_PK");

            entity.ToTable("PSEUDO_CITY_NEG_RATES");

            entity.HasIndex(e => e.PseudoCityCode)
                .HasName("NEG_RATES_PSEUDO_CITY_CODE_FKI");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateCode)
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PseudoCityCode)
                .HasColumnName("PSEUDO_CITY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(PseudoCityCodes)))
				entity.Ignore(e => e.PseudoCityCodeNavigation);
			else
	            entity.HasOne(d => d.PseudoCityCodeNavigation)
	                .WithMany(p => p.PseudoCityNegRates)
	                .HasForeignKey(d => d.PseudoCityCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NEG_RATES_PSEUDO_CITY_CODES_FK");
        });
	}
}
