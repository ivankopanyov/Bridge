namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DepositTypes
{
    public string DepositTypeDesc { get; set; }
    public string DepositType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DepositTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DEPOSIT_TYPES");

            entity.Property(e => e.DepositType)
                .HasColumnName("DEPOSIT_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.DepositTypeDesc)
                .HasColumnName("DEPOSIT_TYPE_DESC")
                .IsUnicode(false);
        });
	}
}
