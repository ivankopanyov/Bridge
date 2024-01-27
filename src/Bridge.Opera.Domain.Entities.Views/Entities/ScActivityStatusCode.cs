namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScActivityStatusCode
{
    public string Description { get; set; }
    public string LanguageCode { get; set; }
    public decimal? PpStatusCode { get; set; }
    public string Resort { get; set; }
    public string StatusCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScActivityStatusCode>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_ACTIVITY_STATUS_CODE");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PpStatusCode)
                .HasColumnName("PP_STATUS_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .IsRequired()
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
