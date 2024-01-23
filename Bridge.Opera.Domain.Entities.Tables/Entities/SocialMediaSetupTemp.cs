namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SocialMediaSetupTemp
{
    public string SocialNetwork { get; set; }
    public string PostToPage { get; set; }
    public string PostToEmail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SocialMediaSetupTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SOCIAL_MEDIA_SETUP_TEMP");

            entity.Property(e => e.PostToEmail)
                .HasColumnName("POST_TO_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PostToPage)
                .IsRequired()
                .HasColumnName("POST_TO_PAGE")
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
