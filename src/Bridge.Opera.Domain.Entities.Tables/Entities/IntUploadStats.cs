namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntUploadStats
{
    public string? Resort { get; set; }
    public string? MessageType { get; set; }
    public DateTime? UploadDate { get; set; }
    public decimal? Stage { get; set; }
    public decimal? Success { get; set; }
    public decimal? Fail { get; set; }
    public decimal? MatchesFound { get; set; }
    public decimal? Invalid { get; set; }
    public decimal? Merged { get; set; }
    public decimal? NewProfile { get; set; }
    public decimal? Other { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntUploadStats>(entity =>
        {
            entity.HasKey(e => new { e.MessageType, e.Resort, e.UploadDate })
                .HasName("INT_UPLOAD_STATS_PK");

            entity.ToTable("INT_UPLOAD_STATS");

            entity.HasIndex(e => new { e.UploadDate, e.Resort, e.MessageType })
                .HasName("INT_UPLOAD_STATS_UK")
                .IsUnique();

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Fail)
                .HasColumnName("FAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Invalid)
                .HasColumnName("INVALID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MatchesFound)
                .HasColumnName("MATCHES_FOUND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Merged)
                .HasColumnName("MERGED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewProfile)
                .HasColumnName("NEW_PROFILE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Other)
                .HasColumnName("OTHER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Stage)
                .HasColumnName("STAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Success)
                .HasColumnName("SUCCESS")
                .HasColumnType("NUMBER");
        });
	}
}
