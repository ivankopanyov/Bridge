namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TraceCodes1
{
    public string? Tracecode { get; set; }
    public string? Tracegroup { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TraceCodes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRACE_CODES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Tracecode)
                .IsRequired()
                .HasColumnName("TRACECODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Tracegroup)
                .IsRequired()
                .HasColumnName("TRACEGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
