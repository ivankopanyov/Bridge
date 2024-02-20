namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcMessages
{
    public string? Resort { get; set; }
    public string? Machine { get; set; }
    public decimal? RowId { get; set; }
    public string? DbfLogo { get; set; }
    public string? Message { get; set; }
    public decimal? SeqNum { get; set; }
    public decimal? Priority { get; set; }
    public string? Operation { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? RequestId { get; set; }
    public string? IfcFktLogo { get; set; }
    public string? ControlYn { get; set; }
    public DateTime? ExpiryTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcMessages>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_MESSAGES");

            entity.HasIndex(e => new { e.Machine, e.ControlYn })
                .HasName("IFC_MSGMACCONTROL_IDX");

            entity.HasIndex(e => new { e.Machine, e.RowId, e.Priority })
                .HasName("IFC_MSGROWPRIO_IDX");

            entity.Property(e => e.ControlYn)
                .HasColumnName("CONTROL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryTime)
                .HasColumnName("EXPIRY_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.IfcFktLogo)
                .HasColumnName("IFC_FKT_LOGO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Message)
                .HasColumnName("MESSAGE")
                .HasColumnType("CLOB");

            entity.Property(e => e.Operation)
                .HasColumnName("OPERATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNum)
                .HasColumnName("SEQ_NUM")
                .HasColumnType("NUMBER");
        });
	}
}
