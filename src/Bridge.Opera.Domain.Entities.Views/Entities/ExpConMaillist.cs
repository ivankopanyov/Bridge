namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConMaillist
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public string? MaillistCode { get; set; }
    public string? MaillistDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConMaillist>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_MAILLIST");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaillistCode)
                .HasColumnName("MAILLIST_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MaillistDescription)
                .HasColumnName("MAILLIST_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
