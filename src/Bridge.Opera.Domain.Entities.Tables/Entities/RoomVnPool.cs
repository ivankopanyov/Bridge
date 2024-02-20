namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomVnPool
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? Pool { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

    public virtual Room R { get; set; }
    public virtual VnPool VnPool { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomVnPool>(entity =>
        {
            entity.HasKey(e => new { e.Room, e.Pool, e.Resort })
                .HasName("RMVN_PK");

            entity.ToTable("ROOM_VN_POOL");

            entity.HasIndex(e => new { e.Pool, e.Resort })
                .HasName("RMVN_VP_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room })
                .HasName("RMVN_ROOM_FK_IDX");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Pool)
                .HasColumnName("POOL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(VnPool)))
				entity.Ignore(e => e.VnPool);
			else
	            entity.HasOne(d => d.VnPool)
	                .WithMany(p => p.RoomVnPool)
	                .HasForeignKey(d => new { d.Pool, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RMVN_VP_FK");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RoomVnPool)
	                .HasForeignKey(d => new { d.Resort, d.Room })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RMVN_ROOM_FK");
        });
	}
}
