namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppPermissions
{
    public AppPermissions()
    {
        AppPermissionDependenciesChildPermissionNavigation = new HashSet<AppPermissionDependencies>();
        AppPermissionDependenciesParentPermissionNavigation = new HashSet<AppPermissionDependencies>();
        AppTrusteePermission = new HashSet<AppTrusteePermission>();
    }

    public string? Permission { get; set; }
    public string? PermissionGroup { get; set; }
    public string? UsedInApp { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? PermissionDisplay { get; set; }
    public decimal? OrderBy { get; set; }
    public string? TrusteePermissionYn { get; set; }

    public virtual ICollection<AppPermissionDependencies> AppPermissionDependenciesChildPermissionNavigation { get; set; }
    public virtual ICollection<AppPermissionDependencies> AppPermissionDependenciesParentPermissionNavigation { get; set; }
    public virtual ICollection<AppTrusteePermission> AppTrusteePermission { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppPermissions>(entity =>
        {
            entity.HasKey(e => e.Permission)
                .HasName("PERMISSION_PK");

            entity.ToTable("APP_PERMISSIONS");

            entity.HasIndex(e => e.PermissionDisplay)
                .HasName("PERMISSION_UK")
                .IsUnique();

            entity.Property(e => e.Permission)
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermissionDisplay)
                .IsRequired()
                .HasColumnName("PERMISSION_DISPLAY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PermissionGroup)
                .HasColumnName("PERMISSION_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrusteePermissionYn)
                .HasColumnName("TRUSTEE_PERMISSION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(AppPermissionDependencies)))
				entity.Ignore(e => e.AppPermissionDependenciesChildPermissionNavigation);

			if (!types.Contains(typeof(AppPermissionDependencies)))
				entity.Ignore(e => e.AppPermissionDependenciesParentPermissionNavigation);

			if (!types.Contains(typeof(AppTrusteePermission)))
				entity.Ignore(e => e.AppTrusteePermission);
		});
	}
}
