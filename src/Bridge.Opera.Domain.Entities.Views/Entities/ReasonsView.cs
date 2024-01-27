namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReasonsView
{
    public string Resort { get; set; }
    public string ReasonCode { get; set; }
    public string Description { get; set; }
    public string StatusCode { get; set; }
    public string StatusDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReasonsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REASONS_VIEW");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.StatusDescription)
                .IsRequired()
                .HasColumnName("STATUS_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
