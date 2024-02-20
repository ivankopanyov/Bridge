namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SocialMediaPostings
{
    public decimal? PostSequence { get; set; }
    public decimal? SocialMediaPgId { get; set; }
    public string? SocialNetwork { get; set; }
    public string? PostCode { get; set; }
    public string? PostedToPage { get; set; }
    public string? PostedToEmail { get; set; }
    public string? PostedMessage { get; set; }
    public DateTime? PostedDate { get; set; }
    public decimal? PostedByUser { get; set; }
    public string? Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SocialMediaPostings>(entity =>
        {
            entity.HasKey(e => new { e.SocialNetwork, e.PostCode, e.PostSequence })
                .HasName("SOCMEDPOS_PK");

            entity.ToTable("SOCIAL_MEDIA_POSTINGS");

            entity.HasIndex(e => e.SocialMediaPgId)
                .HasName("SOCIAL_MEDIA_POST_IND02");

            entity.HasIndex(e => new { e.PostCode, e.Resort })
                .HasName("SOCIAL_MEDIA_POST_IND03");

            entity.HasIndex(e => new { e.Resort, e.SocialNetwork, e.PostedToPage })
                .HasName("SOCIAL_MEDIA_POST_IND01");

            entity.Property(e => e.SocialNetwork)
                .HasColumnName("SOCIAL_NETWORK")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostCode)
                .HasColumnName("POST_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostSequence)
                .HasColumnName("POST_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedByUser)
                .HasColumnName("POSTED_BY_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedDate)
                .HasColumnName("POSTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PostedMessage)
                .HasColumnName("POSTED_MESSAGE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedToEmail)
                .HasColumnName("POSTED_TO_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PostedToPage)
                .HasColumnName("POSTED_TO_PAGE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SocialMediaPgId)
                .HasColumnName("SOCIAL_MEDIA_PG_ID")
                .HasColumnType("NUMBER");

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
