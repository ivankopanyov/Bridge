namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkSections
{
    public ResortHkSections()
    {
        Room = new HashSet<Room>();
    }

    public string SectionCode { get; set; }
    public string Description { get; set; }
    public string Resort { get; set; }
    public string ActiveYn { get; set; }

    public virtual ICollection<Room> Room { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkSections>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_HK_SECTIONS");

            entity.HasIndex(e => new { e.SectionCode, e.Resort })
                .HasName("HK_SECTIONS_UK")
                .IsUnique();

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SectionCode)
                .IsRequired()
                .HasColumnName("SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.Room);
		});
	}
}
