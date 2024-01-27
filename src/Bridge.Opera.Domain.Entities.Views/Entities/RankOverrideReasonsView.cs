namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RankOverrideReasonsView
{
    public string Resort { get; set; }
    public string AttributeCode { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RankOverrideReasonsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RANK_OVERRIDE_REASONS_VIEW");

            entity.Property(e => e.AttributeCode)
                .IsRequired()
                .HasColumnName("ATTRIBUTE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
