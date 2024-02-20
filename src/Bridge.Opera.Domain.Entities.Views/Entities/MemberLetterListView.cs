namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberLetterListView
{
    public string? Letter { get; set; }
    public decimal? LetterId { get; set; }
    public string? LanguageCode { get; set; }
    public string? Destination { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberLetterListView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_LETTER_LIST_VIEW");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Letter)
                .IsRequired()
                .HasColumnName("LETTER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LetterId)
                .HasColumnName("LETTER_ID")
                .HasColumnType("NUMBER");
        });
	}
}
