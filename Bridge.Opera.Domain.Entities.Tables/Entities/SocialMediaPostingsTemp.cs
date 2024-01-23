namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SocialMediaPostingsTemp
{
    public string SocialNetwork { get; set; }
    public string PostCode { get; set; }
    public string PostedToPage { get; set; }
    public string PostedToEmail { get; set; }
    public string PostedMessage { get; set; }
    public DateTime? PostedDate { get; set; }
    public decimal? PostedByUser { get; set; }
    public decimal PostSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SocialMediaPostingsTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SOCIAL_MEDIA_POSTINGS_TEMP");

            entity.Property(e => e.PostCode)
                .IsRequired()
                .HasColumnName("POST_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PostSequence)
                .HasColumnName("POST_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedByUser)
                .HasColumnName("POSTED_BY_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedDate)
                .HasColumnName("POSTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PostedMessage)
                .HasColumnName("POSTED_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.PostedToEmail)
                .HasColumnName("POSTED_TO_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PostedToPage)
                .HasColumnName("POSTED_TO_PAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SocialNetwork)
                .IsRequired()
                .HasColumnName("SOCIAL_NETWORK")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
