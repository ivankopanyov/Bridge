namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvConfLetterExternalView
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string ResvStatus { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public decimal? NameId { get; set; }
    public string DestinationRole { get; set; }
    public string DestinationType { get; set; }
    public string PrimaryYn { get; set; }
    public decimal? DestinationId { get; set; }
    public string DestinationValue { get; set; }
    public string SelectedYn { get; set; }
    public string EmailLanguage { get; set; }
    public decimal? DisplaySeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvConfLetterExternalView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_CONF_LETTER_EXTERNAL_VIEW");

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DestinationRole)
                .HasColumnName("DESTINATION_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DestinationType)
                .HasColumnName("DESTINATION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DestinationValue)
                .HasColumnName("DESTINATION_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailLanguage)
                .HasColumnName("EMAIL_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SelectedYn)
                .HasColumnName("SELECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");
        });
	}
}
