namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailProcessingResort
{
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailProcessingResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAIL_PROCESSING_RESORT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
