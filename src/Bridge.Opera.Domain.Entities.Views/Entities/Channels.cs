namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Channels
{
    public string? SourceCode { get; set; }
    public string? ParentSourceCode { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? SellSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Channels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CHANNELS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ParentSourceCode)
                .HasColumnName("PARENT_SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .IsRequired()
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
