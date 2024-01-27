namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpArAging
{
    public decimal? Balance { get; set; }
    public decimal? AgeSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpArAging>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_AR_AGING");

            entity.Property(e => e.AgeSeq)
                .HasColumnName("AGE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");
        });
	}
}
