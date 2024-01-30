namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsGraphTypesVw
{
    public decimal? GraphSeq { get; set; }
    public string? GraphType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsGraphTypesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_GRAPH_TYPES_VW");

            entity.Property(e => e.GraphSeq)
                .HasColumnName("GRAPH_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GraphType)
                .HasColumnName("GRAPH_TYPE")
                .IsUnicode(false);
        });
	}
}
