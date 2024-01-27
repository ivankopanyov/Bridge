namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvAccessCtlCondsVw
{
    public string Condition { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvAccessCtlCondsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_ACCESS_CTL_CONDS_VW");

            entity.Property(e => e.Condition)
                .HasColumnName("CONDITION")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
