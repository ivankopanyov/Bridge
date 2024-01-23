namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoundingRuleVw
{
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoundingRuleVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROUNDING_RULE_VW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(900)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
