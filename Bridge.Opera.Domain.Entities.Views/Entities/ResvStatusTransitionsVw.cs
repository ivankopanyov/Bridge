namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvStatusTransitionsVw
{
    public string ResvStatusBegin { get; set; }
    public string ResvStatusEnd { get; set; }
    public string ResvStatusPath { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvStatusTransitionsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_STATUS_TRANSITIONS_VW");

            entity.Property(e => e.ResvStatusBegin)
                .HasColumnName("RESV_STATUS_BEGIN")
                .IsUnicode(false);

            entity.Property(e => e.ResvStatusEnd)
                .HasColumnName("RESV_STATUS_END")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatusPath)
                .HasColumnName("RESV_STATUS_PATH")
                .IsUnicode(false);
        });
	}
}
