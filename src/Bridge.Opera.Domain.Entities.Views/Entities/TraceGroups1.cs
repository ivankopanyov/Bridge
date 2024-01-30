namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TraceGroups1
{
    public string? Groupcode { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TraceGroups1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRACE_GROUPS");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Groupcode)
                .IsRequired()
                .HasColumnName("GROUPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
