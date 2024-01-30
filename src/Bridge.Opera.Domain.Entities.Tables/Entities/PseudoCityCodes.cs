namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PseudoCityCodes
{
    public PseudoCityCodes()
    {
        PseudoCityNegRates = new HashSet<PseudoCityNegRates>();
    }

    public string? PseudoCityCode { get; set; }
    public string? PseudoCityDesc { get; set; }
    public string? City { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<PseudoCityNegRates> PseudoCityNegRates { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PseudoCityCodes>(entity =>
        {
            entity.HasKey(e => e.PseudoCityCode)
                .HasName("PSEUDO_CITY_CODES_PK");

            entity.ToTable("PSEUDO_CITY_CODES");

            entity.Property(e => e.PseudoCityCode)
                .HasColumnName("PSEUDO_CITY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoCityDesc)
                .HasColumnName("PSEUDO_CITY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(PseudoCityNegRates)))
				entity.Ignore(e => e.PseudoCityNegRates);
		});
	}
}
