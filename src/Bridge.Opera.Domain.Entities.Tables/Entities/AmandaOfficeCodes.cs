namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AmandaOfficeCodes
{
    public AmandaOfficeCodes()
    {
        AmandaInfo = new HashSet<AmandaInfo>();
    }

    public string? AmadeusOfficeCode { get; set; }
    public string? PrinterId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AmandaInfo> AmandaInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AmandaOfficeCodes>(entity =>
        {
            entity.HasKey(e => e.AmadeusOfficeCode)
                .HasName("AOC_PK");

            entity.ToTable("AMANDA_OFFICE_CODES");

            entity.Property(e => e.AmadeusOfficeCode)
                .HasColumnName("AMADEUS_OFFICE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrinterId)
                .IsRequired()
                .HasColumnName("PRINTER_ID")
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(AmandaInfo)))
				entity.Ignore(e => e.AmandaInfo);
		});
	}
}
