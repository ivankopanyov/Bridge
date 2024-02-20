namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LeadFind
{
    public decimal? Leadid { get; set; }
    public string? Resort { get; set; }
    public decimal? Booklink { get; set; }
    public string? LeadNewYn { get; set; }
    public string? LeadOrigin { get; set; }
    public string? LeadDestination { get; set; }
    public string? Leadstatus { get; set; }
    public string? Replstatus { get; set; }
    public string? RepliedYn { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? SentDate { get; set; }
    public string? SentYn { get; set; }
    public string? OwnerCode { get; set; }
    public string? HideAccinfoYn { get; set; }
    public string? PendingSendYn { get; set; }
    public string? AllotmentType { get; set; }
    public int? SuperBlockId { get; set; }
    public string? SuperBlockResort { get; set; }
    public string? TdlReason { get; set; }
    public DateTime? Arrival { get; set; }
    public string? Tourcode { get; set; }
    public string? AttachmentUrl { get; set; }
    public string? AttachmentUrlModified { get; set; }
    public DateTime? DueDateOrd { get; set; }
    public DateTime? EndDate { get; set; }
    public string? RemoteAttachmentUrl { get; set; }
    public string? Udescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LeadFind>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LEAD_FIND");

            entity.Property(e => e.AllotmentType)
                .IsRequired()
                .HasColumnName("ALLOTMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.AttachmentUrl)
                .HasColumnName("ATTACHMENT_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AttachmentUrlModified)
                .HasColumnName("ATTACHMENT_URL_MODIFIED")
                .HasMaxLength(2007)
                .IsUnicode(false);

            entity.Property(e => e.Booklink)
                .HasColumnName("BOOKLINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DueDateOrd)
                .HasColumnName("DUE_DATE_ORD")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HideAccinfoYn)
                .HasColumnName("HIDE_ACCINFO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LeadDestination)
                .IsRequired()
                .HasColumnName("LEAD_DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LeadNewYn)
                .HasColumnName("LEAD_NEW_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LeadOrigin)
                .HasColumnName("LEAD_ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Leadid)
                .HasColumnName("LEADID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Leadstatus)
                .HasColumnName("LEADSTATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PendingSendYn)
                .HasColumnName("PENDING_SEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RemoteAttachmentUrl)
                .HasColumnName("REMOTE_ATTACHMENT_URL")
                .IsUnicode(false);

            entity.Property(e => e.RepliedYn)
                .HasColumnName("REPLIED_YN")
                .IsUnicode(false);

            entity.Property(e => e.Replstatus)
                .HasColumnName("REPLSTATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SentDate)
                .HasColumnName("SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SentYn)
                .HasColumnName("SENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SuperBlockId).HasColumnName("SUPER_BLOCK_ID");

            entity.Property(e => e.SuperBlockResort)
                .HasColumnName("SUPER_BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TdlReason)
                .HasColumnName("TDL_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tourcode)
                .HasColumnName("TOURCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udescription)
                .HasColumnName("UDESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
