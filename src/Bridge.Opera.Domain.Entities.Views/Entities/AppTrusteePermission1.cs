namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AppTrusteePermission1
{
    public decimal? AppTrusteeId { get; set; }
    public string? Permission { get; set; }
    public string? Resort { get; set; }
    public string? ActiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? PermissionGroup { get; set; }
    public string? PermissionDisplay { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppTrusteePermission1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APP_TRUSTEE_PERMISSION");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AppTrusteeId)
                .HasColumnName("APP_TRUSTEE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Permission)
                .IsRequired()
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PermissionDisplay)
                .IsRequired()
                .HasColumnName("PERMISSION_DISPLAY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PermissionGroup)
                .HasColumnName("PERMISSION_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
