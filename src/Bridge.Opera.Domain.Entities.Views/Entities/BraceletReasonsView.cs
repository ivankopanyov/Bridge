namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BraceletReasonsView
{
    public string ReasonCode { get; set; }
    public string ReasonDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BraceletReasonsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BRACELET_REASONS_VIEW");

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReasonDesc)
                .HasColumnName("REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
