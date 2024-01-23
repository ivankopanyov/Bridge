namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipRoomLabelGroups
{
    public string ChainCode { get; set; }
    public string MemRoomGroup { get; set; }
    public string Label { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual MembershipRoomGroups MembershipRoomGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipRoomLabelGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemRoomGroup, e.Label })
                .HasName("MEM_ROOM_LABEL_GROUPS_PK");

            entity.ToTable("MEMBERSHIP_ROOM_LABEL_GROUPS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemRoomGroup)
                .HasColumnName("MEM_ROOM_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(MembershipRoomGroups)))
				entity.Ignore(e => e.MembershipRoomGroups);
			else
	            entity.HasOne(d => d.MembershipRoomGroups)
	                .WithMany(p => p.MembershipRoomLabelGroups)
	                .HasForeignKey(d => new { d.ChainCode, d.MemRoomGroup })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEM_ROOM_GROUP_FK");
        });
	}
}
