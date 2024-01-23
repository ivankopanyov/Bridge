namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RecptHistoryTypes
{
    public string RecptType { get; set; }
    public string RecptDescription { get; set; }
    public string PaymentType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RecptHistoryTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RECPT_HISTORY_TYPES");

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RecptDescription)
                .HasColumnName("RECPT_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.RecptType)
                .HasColumnName("RECPT_TYPE")
                .HasColumnType("CHAR(3)");
        });
	}
}
