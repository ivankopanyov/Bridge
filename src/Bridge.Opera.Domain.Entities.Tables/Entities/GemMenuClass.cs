namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuClass
{
    public GemMenuClass()
    {
        GemMenu = new HashSet<GemMenu>();
        MencEvtype = new HashSet<MencEvtype>();
    }

    public decimal? MencId { get; set; }
    public string? Resort { get; set; }
    public string? Name { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? InactiveYn { get; set; }
    public string? WebBookingYn { get; set; }

    public virtual ICollection<GemMenu> GemMenu { get; set; }
    public virtual ICollection<MencEvtype> MencEvtype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuClass>(entity =>
        {
            entity.HasKey(e => e.MencId)
                .HasName("MENC_PK");

            entity.ToTable("GEM$MENU_CLASS");

            entity.Property(e => e.MencId)
                .HasColumnName("MENC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(GemMenu)))
				entity.Ignore(e => e.GemMenu);

			if (!types.Contains(typeof(MencEvtype)))
				entity.Ignore(e => e.MencEvtype);
		});
	}
}
