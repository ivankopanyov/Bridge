namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RecentModules
{
    public string ModuleName { get; set; }
    public DateTime AccessDate { get; set; }
    public string ModuleOpenInfo { get; set; }
    public string ModuleViewInfo { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RecentModules>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RECENT_MODULES");

            entity.HasIndex(e => new { e.ModuleName, e.AccessDate })
                .HasName("RECENT_MODULES_IDX1");

            entity.HasIndex(e => new { e.ModuleName, e.InsertUser })
                .HasName("RECENT_MODULES_IDX2");

            entity.Property(e => e.AccessDate)
                .HasColumnName("ACCESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ModuleOpenInfo)
                .HasColumnName("MODULE_OPEN_INFO")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleViewInfo)
                .HasColumnName("MODULE_VIEW_INFO")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
