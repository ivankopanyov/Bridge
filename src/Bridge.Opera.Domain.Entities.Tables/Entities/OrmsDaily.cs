namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsDaily
{
    public string? Resort { get; set; }
    public DateTime? RecordDate { get; set; }
    public string? SeasonCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? CeilingOooYn { get; set; }

    public virtual OrmsSeasons OrmsSeasons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsDaily>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RecordDate })
                .HasName("ORMS_DAILY_SEASONS_PK");

            entity.ToTable("ORMS_DAILY");

            entity.HasIndex(e => new { e.Resort, e.SeasonCode })
                .HasName("ORMS_DAILY_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CeilingOooYn)
                .HasColumnName("CEILING_OOO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsSeasons)))
				entity.Ignore(e => e.OrmsSeasons);
			else
	            entity.HasOne(d => d.OrmsSeasons)
	                .WithMany(p => p.OrmsDaily)
	                .HasForeignKey(d => new { d.Resort, d.SeasonCode })
	                .HasConstraintName("ORMS_DAILY_SEASONS_ORMS_S_FK1");
        });
	}
}
