namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsGraphOversellVw
{
    public decimal Code { get; set; }
    public string Val { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsGraphOversellVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_GRAPH_OVERSELL_VW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Val)
                .HasColumnName("VAL")
                .IsUnicode(false);
        });
	}
}
