namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcActTable
{
    public string? Resort { get; set; }
    public string? EventId { get; set; }
    public string? Command { get; set; }
    public string? RoomNum { get; set; }
    public string? LineNum { get; set; }
    public string? Register { get; set; }
    public string? Register2 { get; set; }
    public string? Result { get; set; }
    public string? GuestNum { get; set; }
    public string? Param1 { get; set; }
    public string? Param2 { get; set; }
    public string? Param3 { get; set; }
    public string? Param4 { get; set; }
    public string? Param5 { get; set; }
    public string? Param6 { get; set; }
    public string? Param7 { get; set; }
    public string? PStation { get; set; }
    public string? LoginName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcActTable>(entity =>
        {
            entity.HasKey(e => new { e.EventId, e.Resort })
                .HasName("IFC_ACT_TABLE_PK");

            entity.ToTable("IFC_ACT_TABLE");

            entity.HasIndex(e => e.Command)
                .HasName("IFC_ACT_COMMAND_IDX");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Command)
                .IsRequired()
                .HasColumnName("COMMAND")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.GuestNum)
                .HasColumnName("GUEST_NUM")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.LineNum)
                .HasColumnName("LINE_NUM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.LoginName)
                .HasColumnName("LOGIN_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PStation)
                .HasColumnName("P_STATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param1)
                .HasColumnName("PARAM1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param2)
                .HasColumnName("PARAM2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param3)
                .HasColumnName("PARAM3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param4)
                .HasColumnName("PARAM4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param5)
                .HasColumnName("PARAM5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param6)
                .HasColumnName("PARAM6")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Param7)
                .HasColumnName("PARAM7")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.Register)
                .HasColumnName("REGISTER")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Register2)
                .HasColumnName("REGISTER2")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Result)
                .HasColumnName("RESULT")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.RoomNum)
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(8)
                .IsUnicode(false);
        });
	}
}
