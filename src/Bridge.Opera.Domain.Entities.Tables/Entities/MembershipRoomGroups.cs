namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipRoomGroups
{
    public MembershipRoomGroups()
    {
        MembershipRoomLabelGroups = new HashSet<MembershipRoomLabelGroups>();
    }

    public string? ChainCode { get; set; }
    public string? MemRoomGroup { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<MembershipRoomLabelGroups> MembershipRoomLabelGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipRoomGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemRoomGroup })
                .HasName("MEM_ROOM_GROUPS_PK");

            entity.ToTable("MEMBERSHIP_ROOM_GROUPS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemRoomGroup)
                .HasColumnName("MEM_ROOM_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(MembershipRoomLabelGroups)))
				entity.Ignore(e => e.MembershipRoomLabelGroups);
		});
	}
}
