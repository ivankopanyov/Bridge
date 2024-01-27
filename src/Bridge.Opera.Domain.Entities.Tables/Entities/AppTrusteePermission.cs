namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppTrusteePermission
{
    public decimal AppTrusteeId { get; set; }
    public string Permission { get; set; }
    public string Resort { get; set; }
    public string ActiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string PermissionGroup { get; set; }

    public virtual AppTrustee AppTrustee { get; set; }
    public virtual AppPermissions PermissionNavigation { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppTrusteePermission>(entity =>
        {
            entity.HasKey(e => new { e.AppTrusteeId, e.Permission, e.Resort })
                .HasName("APPTRP_PK");

            entity.ToTable("APP$_TRUSTEE_PERMISSION");

            entity.HasIndex(e => e.Permission)
                .HasName("APPTRP_APPPERM_FK_IDX");

            entity.HasIndex(e => e.Resort)
                .HasName("APPTRP_RESORT_FK_IDX");

            entity.Property(e => e.AppTrusteeId)
                .HasColumnName("APP_TRUSTEE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Permission)
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermissionGroup)
                .HasColumnName("PERMISSION_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AppTrustee)))
				entity.Ignore(e => e.AppTrustee);
			else
	            entity.HasOne(d => d.AppTrustee)
	                .WithMany(p => p.AppTrusteePermission)
	                .HasForeignKey(d => d.AppTrusteeId)
	                .HasConstraintName("APPTRP_APPTRU_FK");

			if (!types.Contains(typeof(AppPermissions)))
				entity.Ignore(e => e.PermissionNavigation);
			else
	            entity.HasOne(d => d.PermissionNavigation)
	                .WithMany(p => p.AppTrusteePermission)
	                .HasForeignKey(d => d.Permission)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APPTRP_APPPERM_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.AppTrusteePermission)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APPTRP_RESORT_FK");
        });
	}
}
