namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PkgForcastGroups
{
    public PkgForcastGroups()
    {
        ResortProducts = new HashSet<ResortProducts>();
    }

    public string? PkgForcastGroup { get; set; }
    public string? Description { get; set; }
    public string? Resort { get; set; }
    public decimal? SellSequence { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual ICollection<ResortProducts> ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PkgForcastGroups>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PKG_FORCAST_GROUPS");

            entity.HasIndex(e => new { e.PkgForcastGroup, e.Resort })
                .HasName("PKG_FORCAST_GROUP_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgForcastGroup)
                .IsRequired()
                .HasColumnName("PKG_FORCAST_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
		});
	}
}
