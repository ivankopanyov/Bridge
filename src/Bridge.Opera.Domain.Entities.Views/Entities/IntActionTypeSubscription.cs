namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntActionTypeSubscription
{
    public string? Code { get; set; }
    public string? Resort { get; set; }
    public string? Module { get; set; }
    public string? ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntActionTypeSubscription>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_ACTION_TYPE_SUBSCRIPTION");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
