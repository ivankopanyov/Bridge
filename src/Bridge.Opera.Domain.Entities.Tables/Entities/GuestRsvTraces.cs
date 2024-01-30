namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestRsvTraces
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? TraceId { get; set; }
    public string? DeptId { get; set; }
    public DateTime? TraceOn { get; set; }
    public string? StatusFlag { get; set; }
    public DateTime? ResolvedOn { get; set; }
    public string? ResolvedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? ResvTraceId { get; set; }
    public string? NoteCode { get; set; }
    public string? NoteResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestRsvTraces>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.TraceId, e.DeptId, e.TraceOn })
                .HasName("GST_RSV_TRC_PK");

            entity.ToTable("GUEST_RSV_TRACES");

            entity.HasIndex(e => e.ResvTraceId)
                .HasName("GUEST_RSV_TRACEID_UK")
                .IsUnique();

            entity.HasIndex(e => e.TraceOn)
                .HasName("GUEST_RSV_TRACES_IND");

            entity.HasIndex(e => new { e.TraceId, e.Resort })
                .HasName("GST_RSV_TRC_IND2");

            entity.HasIndex(e => new { e.Resort, e.DeptId, e.StatusFlag, e.TraceOn })
                .HasName("GST_RSV_TRC_IND3");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TraceId)
                .HasColumnName("TRACE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TraceOn)
                .HasColumnName("TRACE_ON")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteResort)
                .HasColumnName("NOTE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedBy)
                .HasColumnName("RESOLVED_BY")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResolvedOn)
                .HasColumnName("RESOLVED_ON")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvTraceId)
                .HasColumnName("RESV_TRACE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatusFlag)
                .IsRequired()
                .HasColumnName("STATUS_FLAG")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
