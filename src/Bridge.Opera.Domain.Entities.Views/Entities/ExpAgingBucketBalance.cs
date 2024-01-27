namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpAgingBucketBalance
{
    public decimal? Balance { get; set; }
    public decimal? AgingBucketNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpAgingBucketBalance>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_AGING_BUCKET_BALANCE");

            entity.Property(e => e.AgingBucketNo)
                .HasColumnName("AGING_BUCKET_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");
        });
	}
}
