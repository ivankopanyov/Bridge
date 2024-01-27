namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsSeasons
{
    public OrmsSeasons()
    {
        OrmsDaily = new HashSet<OrmsDaily>();
    }

    public string Resort { get; set; }
    public string SeasonCode { get; set; }
    public string SeasonDesc { get; set; }
    public string DisplayColor { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ICollection<OrmsDaily> OrmsDaily { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsSeasons>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SeasonCode })
                .HasName("ORMS_SEASONS_PK");

            entity.ToTable("ORMS_SEASONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeasonDesc)
                .IsRequired()
                .HasColumnName("SEASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(OrmsDaily)))
				entity.Ignore(e => e.OrmsDaily);
		});
	}
}
