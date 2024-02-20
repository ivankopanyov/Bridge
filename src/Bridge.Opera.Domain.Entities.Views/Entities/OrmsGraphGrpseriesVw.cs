namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsGraphGrpseriesVw
{
    public decimal? Code { get; set; }
    public string? Val { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsGraphGrpseriesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_GRAPH_GRPSERIES_VW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Val)
                .HasColumnName("VAL")
                .IsUnicode(false);
        });
	}
}
