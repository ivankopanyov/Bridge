namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcWakeJrnl
{
    public decimal? ActionInstanceId { get; set; }
    public string? RoomNo { get; set; }
    public string? ActionType { get; set; }
    public string? GuestName { get; set; }
    public string? GroupName { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? InsertTime { get; set; }
    public string? InsertUser { get; set; }
    public string? ActionDescription { get; set; }
    public string? ExtnNum { get; set; }
    public string? ExtnType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcWakeJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_WAKE_JRNL");

            entity.HasIndex(e => e.ActionInstanceId)
                .HasName("IFC_WAKE_JRNL_ACTION_IDX");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExtnNum)
                .HasColumnName("EXTN_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtnType)
                .HasColumnName("EXTN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertTime)
                .HasColumnName("INSERT_TIME")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
