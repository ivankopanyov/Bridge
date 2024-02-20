namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppGrantedPermissions
{
    public string? Comments { get; set; }
    public string? Resort { get; set; }
    public string? Permission { get; set; }
    public decimal? AppUserId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual ApplicationUser AppUser { get; set; }
    public virtual AppPermissions PermissionNavigation { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppGrantedPermissions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("APP_GRANTED_PERMISSIONS");

            entity.HasIndex(e => e.Permission)
                .HasName("APG_PERM_FK_IDX");

            entity.HasIndex(e => new { e.AppUserId, e.Permission })
                .HasName("AGP_USERID_IDX");

            entity.HasIndex(e => new { e.Resort, e.AppUserId, e.Permission })
                .HasName("APP_GRANTED_PERMISSIONS_UK")
                .IsUnique();

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Permission)
                .IsRequired()
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithMany()
	                .HasForeignKey(d => d.AppUserId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APP_GRANTED_PERM_USER_FK");

			if (!types.Contains(typeof(AppPermissions)))
				entity.Ignore(e => e.PermissionNavigation);
			else
	            entity.HasOne(d => d.PermissionNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Permission)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APP_GRANTED_PERMISSION_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APP_GRANTED_PERM_RESORT_FK");
        });
	}
}
