namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomPreferences
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal PreferenceSeqId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual Preferences PreferenceSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomPreferences>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.PreferenceSeqId })
                .HasName("RMPREF_PK");

            entity.ToTable("ROOM_PREFERENCES");

            entity.HasIndex(e => e.PreferenceSeqId)
                .HasName("RMPREF_SEQ_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceSeqId)
                .HasColumnName("PREFERENCE_SEQ_ID")
                .HasColumnType("NUMBER");

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

			if (!types.Contains(typeof(Preferences)))
				entity.Ignore(e => e.PreferenceSeq);
			else
	            entity.HasOne(d => d.PreferenceSeq)
	                .WithMany(p => p.RoomPreferences)
	                .HasPrincipalKey(p => p.PreferenceSeqId)
	                .HasForeignKey(d => d.PreferenceSeqId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RMPREF_PREF_FK");
        });
	}
}
