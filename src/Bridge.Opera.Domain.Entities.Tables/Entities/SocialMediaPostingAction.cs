namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SocialMediaPostingAction
{
    public decimal? ActionInstanceId { get; set; }
    public string? Resort { get; set; }
    public decimal? PostSequence { get; set; }
    public string? ActionType { get; set; }
    public string? Machine { get; set; }
    public string? Terminal { get; set; }
    public string? ActionDescription { get; set; }
    public string? Module { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SocialMediaPostingAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("SMN_PK");

            entity.ToTable("SOCIAL_MEDIA_POSTING_ACTION");

            entity.HasIndex(e => e.InsertDate)
                .HasName("SMPA_IDX3");

            entity.HasIndex(e => new { e.PostSequence, e.ActionType })
                .HasName("SMPA_IDX2");

            entity.HasIndex(e => new { e.Resort, e.PostSequence, e.ActionType })
                .HasName("SMPA_IDX1");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PostSequence)
                .HasColumnName("POST_SEQUENCE")
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
