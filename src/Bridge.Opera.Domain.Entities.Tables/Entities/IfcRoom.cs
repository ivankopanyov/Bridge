namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcRoom
{
    public string? Resort { get; set; }
    public decimal? PathId { get; set; }
    public string? RoomNum { get; set; }
    public string? LineNum { get; set; }
    public string? Type { get; set; }
    public string? BaseLine { get; set; }
    public string? XlatId { get; set; }
    public string? Mask { get; set; }
    public string? Stat { get; set; }
    public string? Vip { get; set; }
    public string? Name { get; set; }
    public string? Language { get; set; }
    public string? Data1 { get; set; }
    public string? Data2 { get; set; }
    public string? Data3 { get; set; }
    public string? Data4 { get; set; }
    public string? Data5 { get; set; }
    public string? Data6 { get; set; }
    public string? Data7 { get; set; }
    public string? Data8 { get; set; }
    public string? Data9 { get; set; }
    public string? VnSetup { get; set; }
    public decimal? Sequence { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? InactiveYn { get; set; }
    public string? ExtnYn { get; set; }
    public string? MandatoryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcRoom>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_ROOM");

            entity.HasIndex(e => new { e.Resort, e.XlatId, e.LineNum })
                .HasName("IFC_ROOL");

            entity.HasIndex(e => new { e.Resort, e.XlatId, e.RoomNum })
                .HasName("IFC_ROOR");

            entity.HasIndex(e => new { e.XlatId, e.PathId, e.RoomNum, e.LineNum })
                .HasName("IFC_ROOM_XPRL_IDX");

            entity.Property(e => e.BaseLine)
                .HasColumnName("BASE_LINE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data1)
                .HasColumnName("DATA_1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data2)
                .HasColumnName("DATA_2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data3)
                .HasColumnName("DATA_3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data4)
                .HasColumnName("DATA_4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data5)
                .HasColumnName("DATA_5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data6)
                .HasColumnName("DATA_6")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data7)
                .HasColumnName("DATA_7")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data8)
                .HasColumnName("DATA_8")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data9)
                .HasColumnName("DATA_9")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtnYn)
                .HasColumnName("EXTN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LineNum)
                .HasColumnName("LINE_NUM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MandatoryYn)
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Mask)
                .HasColumnName("MASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PathId)
                .HasColumnName("PATH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNum)
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Stat)
                .HasColumnName("STAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VnSetup)
                .HasColumnName("VN_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XlatId)
                .HasColumnName("XLAT_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
