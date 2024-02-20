namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FloorplanDetails
{
    public decimal? FloorId { get; set; }
    public decimal? LayerId { get; set; }
    public string? Room { get; set; }
    public string? ShapeType { get; set; }
    public string? Shape { get; set; }

    public virtual FloorplanHeader Floor { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FloorplanDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FLOORPLAN_DETAILS");

            entity.HasIndex(e => e.FloorId)
                .HasName("FPDET_FLOORID_FKI");

            entity.HasIndex(e => e.Room)
                .HasName("FPDET_ROOM_IDX");

            entity.Property(e => e.FloorId)
                .HasColumnName("FLOOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LayerId)
                .HasColumnName("LAYER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Shape)
                .IsRequired()
                .HasColumnName("SHAPE")
                .IsUnicode(false);

            entity.Property(e => e.ShapeType)
                .IsRequired()
                .HasColumnName("SHAPE_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(FloorplanHeader)))
				entity.Ignore(e => e.Floor);
			else
	            entity.HasOne(d => d.Floor)
	                .WithMany()
	                .HasForeignKey(d => d.FloorId)
	                .HasConstraintName("FPDET_FPHDR_FK");
        });
	}
}
