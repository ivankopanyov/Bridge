namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppPermissionDependencies
{
    public string? ParentPermission { get; set; }
    public string? ChildPermission { get; set; }
    public string? GrantYn { get; set; }
    public string? RevokeYn { get; set; }

    public virtual AppPermissions ChildPermissionNavigation { get; set; }
    public virtual AppPermissions ParentPermissionNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppPermissionDependencies>(entity =>
        {
            entity.HasKey(e => new { e.ParentPermission, e.ChildPermission })
                .HasName("PERMISSION_DEP_PK");

            entity.ToTable("APP_PERMISSION_DEPENDENCIES");

            entity.HasIndex(e => e.ChildPermission)
                .HasName("PERMSSION_DEP_CHILD_IDX");

            entity.Property(e => e.ParentPermission)
                .HasColumnName("PARENT_PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildPermission)
                .HasColumnName("CHILD_PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GrantYn)
                .HasColumnName("GRANT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RevokeYn)
                .HasColumnName("REVOKE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(AppPermissions)))
				entity.Ignore(e => e.ChildPermissionNavigation);
			else
	            entity.HasOne(d => d.ChildPermissionNavigation)
	                .WithMany(p => p.AppPermissionDependenciesChildPermissionNavigation)
	                .HasForeignKey(d => d.ChildPermission)
	                .HasConstraintName("APE_APN_CHILD_FK");

			if (!types.Contains(typeof(AppPermissions)))
				entity.Ignore(e => e.ParentPermissionNavigation);
			else
	            entity.HasOne(d => d.ParentPermissionNavigation)
	                .WithMany(p => p.AppPermissionDependenciesParentPermissionNavigation)
	                .HasForeignKey(d => d.ParentPermission)
	                .HasConstraintName("APE_APN_FK");
        });
	}
}
