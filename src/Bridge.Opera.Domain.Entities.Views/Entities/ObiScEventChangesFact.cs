namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScEventChangesFact
{
    public decimal? ChangeId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public string? Action { get; set; }
    public DateTime? ChangeDate { get; set; }
    public string? ChangeTime { get; set; }
    public string? ChangeUser { get; set; }
    public string? Fieldname { get; set; }
    public string? NewValue { get; set; }
    public string? OldValue { get; set; }
    public string? ResourceName { get; set; }
    public string? ResourceType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScEventChangesFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_EVENT_CHANGES_FACT");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeTime)
                .HasColumnName("CHANGE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ChangeUser)
                .HasColumnName("CHANGE_USER")
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fieldname)
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceName)
                .HasColumnName("RESOURCE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResourceType)
                .HasColumnName("RESOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
