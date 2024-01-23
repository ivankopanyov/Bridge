namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MeetingRoomDetails
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public string Code { get; set; }
    public string CodeValue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Room R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.Code })
                .HasName("MRD_PK");

            entity.ToTable("MEETING_ROOM$DETAILS");

            entity.HasIndex(e => e.Code)
                .HasName("MRD_MC_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeValue)
                .HasColumnName("CODE_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.MeetingRoomDetails)
	                .HasForeignKey(d => new { d.Resort, d.Room })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MRD_ROOM_FK");
        });
	}
}
