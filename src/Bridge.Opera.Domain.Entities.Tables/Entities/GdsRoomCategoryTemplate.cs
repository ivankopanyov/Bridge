namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRoomCategoryTemplate
{
    public string? GdsHost { get; set; }
    public string? GdsRoomCategory { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? RotationGroup { get; set; }

    public virtual GdsHosts GdsHostNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRoomCategoryTemplate>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.GdsRoomCategory })
                .HasName("GDS_ROOM_CATEGORY_TEMPLATE_PK");

            entity.ToTable("GDS_ROOM_CATEGORY_TEMPLATE");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RotationGroup)
                .HasColumnName("ROTATION_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsHosts)))
				entity.Ignore(e => e.GdsHostNavigation);
			else
	            entity.HasOne(d => d.GdsHostNavigation)
	                .WithMany(p => p.GdsRoomCategoryTemplate)
	                .HasForeignKey(d => d.GdsHost)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_ROOM_CAT_TEMP_GDS_HOSTS_FK");
        });
	}
}
