namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailViewSys
{
    public decimal? SourceId { get; set; }
    public string? SourceType { get; set; }
    public decimal? ViewOrder { get; set; }
    public string? Description { get; set; }
    public string? CharColumn1 { get; set; }
    public string? NumberColumn1 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailViewSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAIL_VIEW_SYS");

            entity.Property(e => e.CharColumn1)
                .HasColumnName("CHAR_COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NumberColumn1)
                .HasColumnName("NUMBER_COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceType)
                .IsRequired()
                .HasColumnName("SOURCE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ViewOrder)
                .HasColumnName("VIEW_ORDER")
                .HasColumnType("NUMBER");
        });
	}
}
