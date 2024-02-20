namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAppPermissionsSys
{
    public string? Permission { get; set; }
    public string? PermissionDisplay { get; set; }
    public string? PermissionGroup { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string? UsedInApp { get; set; }
    public string? TrusteePermissionYn { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAppPermissionsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_APP_PERMISSIONS_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Permission)
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PermissionDisplay)
                .HasColumnName("PERMISSION_DISPLAY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PermissionGroup)
                .HasColumnName("PERMISSION_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrusteePermissionYn)
                .HasColumnName("TRUSTEE_PERMISSION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
