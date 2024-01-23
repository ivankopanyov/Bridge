namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GuestTracesView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal TraceId { get; set; }
    public string DeptId { get; set; }
    public DateTime TraceDate { get; set; }
    public DateTime TraceOn { get; set; }
    public string StatusFlag { get; set; }
    public string EnteredBy { get; set; }
    public string TraceText { get; set; }
    public string ResolvedOn { get; set; }
    public string ResolvedBy { get; set; }
    public DateTime? ResolvedOnDate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string Room { get; set; }
    public string ResvStatus { get; set; }
    public string GuestFullName { get; set; }
    public string TraceTime { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public string GuaranteeCode { get; set; }
    public string TraceType { get; set; }
    public string InternalYn { get; set; }
    public string ResvStatusDisplay { get; set; }
    public decimal GuestNameId { get; set; }
    public decimal? ResvTraceId { get; set; }
    public string ExternalTraceId { get; set; }
    public string ConfirmationNo { get; set; }
    public DateTime? TruncArrival { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestTracesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GUEST_TRACES_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EnteredBy)
                .IsRequired()
                .HasColumnName("ENTERED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExternalTraceId)
                .HasColumnName("EXTERNAL_TRACE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestFullName)
                .HasColumnName("GUEST_FULL_NAME")
                .HasMaxLength(163)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedBy)
                .HasColumnName("RESOLVED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedOn)
                .HasColumnName("RESOLVED_ON")
                .HasMaxLength(151)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedOnDate)
                .HasColumnName("RESOLVED_ON_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatusDisplay)
                .HasColumnName("RESV_STATUS_DISPLAY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvTraceId)
                .HasColumnName("RESV_TRACE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusFlag)
                .IsRequired()
                .HasColumnName("STATUS_FLAG")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TraceDate)
                .HasColumnName("TRACE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TraceId)
                .HasColumnName("TRACE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TraceOn)
                .HasColumnName("TRACE_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.TraceText)
                .IsRequired()
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TraceTime)
                .HasColumnName("TRACE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.TraceType)
                .HasColumnName("TRACE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
