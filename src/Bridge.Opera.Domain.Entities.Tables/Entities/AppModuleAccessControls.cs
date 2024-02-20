namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppModuleAccessControls
{
    public decimal? AppUserId { get; set; }
    public decimal? ModuleId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppModuleAccessControls>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AppUserId, e.ModuleId })
                .HasName("AMAC_PK");

            entity.ToTable("APP_MODULE_ACCESS_CONTROLS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
