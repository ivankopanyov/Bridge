namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemAttributes
{
    public GemItemAttributes()
    {
        GemItemaTranslation = new HashSet<GemItemaTranslation>();
    }

    public decimal ItmaId { get; set; }
    public string Resort { get; set; }
    public decimal ItemId { get; set; }
    public string Name { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string DefaultYn { get; set; }

    public virtual GemItem GemItem { get; set; }
    public virtual ICollection<GemItemaTranslation> GemItemaTranslation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemAttributes>(entity =>
        {
            entity.HasKey(e => e.ItmaId)
                .HasName("ITMA_PK");

            entity.ToTable("GEM$ITEM_ATTRIBUTES");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("ITEMA_ITM_IDX");

            entity.Property(e => e.ItmaId)
                .HasColumnName("ITMA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.GemItemAttributes)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITMA_ITM_FK");
        
			if (!types.Contains(typeof(GemItemaTranslation)))
				entity.Ignore(e => e.GemItemaTranslation);
		});
	}
}
