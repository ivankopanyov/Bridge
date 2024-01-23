namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbTags
{
    public string Tag { get; set; }
    public string UsedForDataType { get; set; }
    public string ReplaceExpr { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbTags>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_TAGS");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReplaceExpr)
                .HasColumnName("REPLACE_EXPR")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Tag)
                .HasColumnName("TAG")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.UsedForDataType)
                .HasColumnName("USED_FOR_DATA_TYPE")
                .HasMaxLength(9)
                .IsUnicode(false);
        });
	}
}
