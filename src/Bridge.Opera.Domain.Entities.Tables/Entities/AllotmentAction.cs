namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentAction
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? ActionId { get; set; }
    public string? ActionType { get; set; }
    public string? ActionDesc { get; set; }
    public string? Machine { get; set; }
    public string? Terminal { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? ParentActionId { get; set; }
    public string? Module { get; set; }
    public string? ChildPrimaryId { get; set; }
    public string? ChainCode { get; set; }
    public DateTime? ChangeDate { get; set; }
    public string? ExtProcessedSystem { get; set; }
    public string? ExtMessageFailureReason { get; set; }
    public string? ExtMessageStatus { get; set; }
    public string? CallStack { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentAction>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("ALLOTMENT_ACTION_PK");

            entity.ToTable("ALLOTMENT_ACTION");

            entity.HasIndex(e => new { e.ActionType, e.Resort })
                .HasName("ALLOT_ACTION_TYPE_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("ALLOT_ACTION_HDR_ID_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.ActionType, e.Resort })
                .HasName("ALLOT_HDRID_ACTION_TYPE");

            entity.HasIndex(e => new { e.ChangeDate, e.ActionType, e.Resort, e.ChainCode })
                .HasName("ALLOT_CHANGE_DATE_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.ActionType, e.Resort, e.ChainCode })
                .HasName("ALOT_INSERT_DATE_IDX");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDesc)
                .HasColumnName("ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CallStack)
                .HasColumnName("CALL_STACK")
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChildPrimaryId)
                .HasColumnName("CHILD_PRIMARY_ID")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ExtMessageFailureReason)
                .HasColumnName("EXT_MESSAGE_FAILURE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtMessageStatus)
                .HasColumnName("EXT_MESSAGE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtProcessedSystem)
                .HasColumnName("EXT_PROCESSED_SYSTEM")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ParentActionId)
                .HasColumnName("PARENT_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
