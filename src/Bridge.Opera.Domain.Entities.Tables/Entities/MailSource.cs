namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailSource
{
    public MailSource()
    {
        MailFieldList = new HashSet<MailFieldList>();
        MailHitlist = new HashSet<MailHitlist>();
        MailQuery = new HashSet<MailQuery>();
        MailSourceFields = new HashSet<MailSourceFields>();
        MailSubquery = new HashSet<MailSubquery>();
        MailTags = new HashSet<MailTags>();
        MailView = new HashSet<MailView>();
    }

    public decimal? SourceId { get; set; }
    public string? Description { get; set; }
    public decimal? SourceOrder { get; set; }
    public string? JoinCondition { get; set; }
    public string? Column1 { get; set; }
    public string? Column2 { get; set; }
    public string? Column3 { get; set; }
    public string? Description1 { get; set; }
    public string? Description2 { get; set; }
    public string? Description3 { get; set; }
    public string? CharColumn1 { get; set; }
    public string? NumberColumn1 { get; set; }
    public string? NumberColumn2 { get; set; }
    public string? CharNull1Yn { get; set; }
    public string? NumberNull1Yn { get; set; }
    public string? NumberNull2Yn { get; set; }
    public string? ActivityAccount { get; set; }
    public string? ActivityContact { get; set; }
    public string? ActivityBooking { get; set; }
    public string? RequestName { get; set; }
    public string? RequestKey { get; set; }
    public string? RequestKeyColumn { get; set; }
    public string? Column1Key { get; set; }
    public string? Column2Key { get; set; }
    public string? Column3Key { get; set; }
    public string? ReservationKey { get; set; }
    public string? Description1Translation { get; set; }
    public string? Description2Translation { get; set; }
    public string? Description3Translation { get; set; }
    public string? DistinctYn { get; set; }
    public string? UseOnceColumnsYn { get; set; }
    public string? QueryHint { get; set; }
    public string? ResortKeyColumn { get; set; }
    public string? ResortYn { get; set; }

    public virtual ICollection<MailFieldList> MailFieldList { get; set; }
    public virtual ICollection<MailHitlist> MailHitlist { get; set; }
    public virtual ICollection<MailQuery> MailQuery { get; set; }
    public virtual ICollection<MailSourceFields> MailSourceFields { get; set; }
    public virtual ICollection<MailSubquery> MailSubquery { get; set; }
    public virtual ICollection<MailTags> MailTags { get; set; }
    public virtual ICollection<MailView> MailView { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailSource>(entity =>
        {
            entity.HasKey(e => e.SourceId)
                .HasName("MAILS_PK");

            entity.ToTable("MAIL_SOURCE");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActivityAccount)
                .HasColumnName("ACTIVITY_ACCOUNT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ActivityBooking)
                .HasColumnName("ACTIVITY_BOOKING")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ActivityContact)
                .HasColumnName("ACTIVITY_CONTACT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.CharColumn1)
                .HasColumnName("CHAR_COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.CharNull1Yn)
                .HasColumnName("CHAR_NULL1_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Column1)
                .HasColumnName("COLUMN1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column1Key)
                .HasColumnName("COLUMN1_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column2)
                .HasColumnName("COLUMN2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column2Key)
                .HasColumnName("COLUMN2_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column3)
                .HasColumnName("COLUMN3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column3Key)
                .HasColumnName("COLUMN3_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description1)
                .HasColumnName("DESCRIPTION1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description1Translation)
                .HasColumnName("DESCRIPTION1_TRANSLATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description2)
                .HasColumnName("DESCRIPTION2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description2Translation)
                .HasColumnName("DESCRIPTION2_TRANSLATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description3)
                .HasColumnName("DESCRIPTION3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description3Translation)
                .HasColumnName("DESCRIPTION3_TRANSLATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DistinctYn)
                .HasColumnName("DISTINCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.JoinCondition)
                .HasColumnName("JOIN_CONDITION")
                .IsUnicode(false);

            entity.Property(e => e.NumberColumn1)
                .HasColumnName("NUMBER_COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.NumberColumn2)
                .HasColumnName("NUMBER_COLUMN2")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.NumberNull1Yn)
                .HasColumnName("NUMBER_NULL1_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.NumberNull2Yn)
                .HasColumnName("NUMBER_NULL2_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.QueryHint)
                .HasColumnName("QUERY_HINT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.RequestKey)
                .HasColumnName("REQUEST_KEY")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.RequestKeyColumn)
                .HasColumnName("REQUEST_KEY_COLUMN")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.RequestName)
                .HasColumnName("REQUEST_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ReservationKey)
                .HasColumnName("RESERVATION_KEY")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ResortKeyColumn)
                .HasColumnName("RESORT_KEY_COLUMN")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ResortYn)
                .HasColumnName("RESORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceOrder)
                .HasColumnName("SOURCE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UseOnceColumnsYn)
                .HasColumnName("USE_ONCE_COLUMNS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(MailFieldList)))
				entity.Ignore(e => e.MailFieldList);

			if (!types.Contains(typeof(MailHitlist)))
				entity.Ignore(e => e.MailHitlist);

			if (!types.Contains(typeof(MailQuery)))
				entity.Ignore(e => e.MailQuery);

			if (!types.Contains(typeof(MailSourceFields)))
				entity.Ignore(e => e.MailSourceFields);

			if (!types.Contains(typeof(MailSubquery)))
				entity.Ignore(e => e.MailSubquery);

			if (!types.Contains(typeof(MailTags)))
				entity.Ignore(e => e.MailTags);

			if (!types.Contains(typeof(MailView)))
				entity.Ignore(e => e.MailView);
		});
	}
}
