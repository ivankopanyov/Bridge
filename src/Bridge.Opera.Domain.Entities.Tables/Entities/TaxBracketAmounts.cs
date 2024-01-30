namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaxBracketAmounts
{
    public string? Resort { get; set; }
    public decimal? BracketPerc { get; set; }
    public decimal? BracketStart { get; set; }
    public decimal? BracketEnd { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual TaxBracketPerc TaxBracketPerc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaxBracketAmounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TAX_BRACKET_AMOUNTS");

            entity.HasIndex(e => new { e.Resort, e.BracketPerc })
                .HasName("TAX_BRACKET_AMOUNT_PERC_IDX");

            entity.Property(e => e.BracketEnd)
                .HasColumnName("BRACKET_END")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BracketPerc)
                .HasColumnName("BRACKET_PERC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BracketStart)
                .HasColumnName("BRACKET_START")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(TaxBracketPerc)))
				entity.Ignore(e => e.TaxBracketPerc);
			else
	            entity.HasOne(d => d.TaxBracketPerc)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.Resort, p.BracketPerc })
	                .HasForeignKey(d => new { d.Resort, d.BracketPerc })
	                .HasConstraintName("TBA_TBP_FK");
        });
	}
}
