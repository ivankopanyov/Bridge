namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpArAgingViewOpen
{
    public decimal? Bal { get; set; }
    public decimal? Paybal { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal? RemSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpArAgingViewOpen>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_AR_AGING_VIEW_OPEN");

            entity.Property(e => e.Bal)
                .HasColumnName("BAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paybal)
                .HasColumnName("PAYBAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RemSeqNo)
                .HasColumnName("REM_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");
        });
	}
}
