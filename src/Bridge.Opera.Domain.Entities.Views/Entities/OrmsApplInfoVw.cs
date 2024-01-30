namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsApplInfoVw
{
    public string? Titlebusinessdate { get; set; }
    public string? Operaversion { get; set; }
    public string? Operauser { get; set; }
    public string? JavaDateFormat { get; set; }
    public string? JavaTimeFormat { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsApplInfoVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_APPL_INFO_VW");

            entity.Property(e => e.JavaDateFormat)
                .HasColumnName("JAVA_DATE_FORMAT")
                .IsUnicode(false);

            entity.Property(e => e.JavaTimeFormat)
                .HasColumnName("JAVA_TIME_FORMAT")
                .IsUnicode(false);

            entity.Property(e => e.Operauser)
                .HasColumnName("OPERAUSER")
                .IsUnicode(false);

            entity.Property(e => e.Operaversion)
                .HasColumnName("OPERAVERSION")
                .IsUnicode(false);

            entity.Property(e => e.Titlebusinessdate)
                .HasColumnName("TITLEBUSINESSDATE")
                .HasMaxLength(65)
                .IsUnicode(false);
        });
	}
}
