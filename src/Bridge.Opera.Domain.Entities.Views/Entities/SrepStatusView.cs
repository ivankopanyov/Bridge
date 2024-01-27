namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SrepStatusView
{
    public string SrepCode { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SrepStatusView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SREP_STATUS_VIEW");

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
