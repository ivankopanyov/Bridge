namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPdAccountTypeDimVw
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string AccountType { get; set; }
    public string AccountTypeDesc { get; set; }
    public string ResortId { get; set; }
    public string AccountTypeKey { get; set; }
    public string AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPdAccountTypeDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PD_ACCOUNT_TYPE_DIM_VW");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeDesc)
                .HasColumnName("ACCOUNT_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeKey)
                .HasColumnName("ACCOUNT_TYPE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
