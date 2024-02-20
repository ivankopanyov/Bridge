namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaxBracketPerc
{
    public string? Resort { get; set; }
    public decimal? BracketPerc { get; set; }
    public string? BracketDesc { get; set; }
    public decimal? BracketThreshold { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaxBracketPerc>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TAX_BRACKET_PERC");

            entity.HasIndex(e => new { e.Resort, e.BracketPerc })
                .HasName("TAX_BRACKET_PERC_UK")
                .IsUnique();

            entity.Property(e => e.BracketDesc)
                .HasColumnName("BRACKET_DESC")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BracketPerc)
                .HasColumnName("BRACKET_PERC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BracketThreshold)
                .HasColumnName("BRACKET_THRESHOLD")
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
