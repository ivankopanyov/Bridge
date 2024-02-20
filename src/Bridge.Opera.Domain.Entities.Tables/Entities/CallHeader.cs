namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CallHeader
{
    public decimal? CallHeaderId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? TurnawayCode { get; set; }
    public DateTime? CallBegin { get; set; }
    public DateTime? CallEnd { get; set; }
    public string? CallerFirst { get; set; }
    public string? CallerLast { get; set; }
    public string? CallerPhone { get; set; }
    public string? Comments { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? CallerFax { get; set; }
    public string? CallerEmail { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CallHeader>(entity =>
        {
            entity.ToTable("CALL_HEADER");

            entity.HasIndex(e => e.ConfirmationNo)
                .HasName("CALL_HEADER_CONF_NO");

            entity.HasIndex(e => e.NameId)
                .HasName("CALL_HEADER_NAME_ID");

            entity.HasIndex(e => e.ResvNameId)
                .HasName("CALL_HEADER_RESV_NAME");

            entity.HasIndex(e => new { e.CallBegin, e.InsertUser })
                .HasName("CALL_HEADER_DATE_AGENT_IDX");

            entity.Property(e => e.CallHeaderId)
                .HasColumnName("CALL_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CallBegin)
                .HasColumnName("CALL_BEGIN")
                .HasColumnType("DATE");

            entity.Property(e => e.CallEnd)
                .HasColumnName("CALL_END")
                .HasColumnType("DATE");

            entity.Property(e => e.CallerEmail)
                .HasColumnName("CALLER_EMAIL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CallerFax)
                .HasColumnName("CALLER_FAX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CallerFirst)
                .HasColumnName("CALLER_FIRST")
                .HasMaxLength(280)
                .IsUnicode(false);

            entity.Property(e => e.CallerLast)
                .HasColumnName("CALLER_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CallerPhone)
                .HasColumnName("CALLER_PHONE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TurnawayCode)
                .HasColumnName("TURNAWAY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
