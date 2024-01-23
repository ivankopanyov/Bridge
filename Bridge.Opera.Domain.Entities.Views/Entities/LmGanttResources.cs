namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmGanttResources
{
    public string GanttType { get; set; }
    public string Resort { get; set; }
    public string GanttResource { get; set; }
    public string GanttDesc { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmGanttResources>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_GANTT_RESOURCES");

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.GanttDesc)
                .HasColumnName("GANTT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GanttResource)
                .HasColumnName("GANTT_RESOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GanttType)
                .HasColumnName("GANTT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
