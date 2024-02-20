namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiResvStatusDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? ResvStatus { get; set; }
    public string? ResvStatusDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiResvStatusDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RESV_STATUS_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ResvStatusDesc)
                .HasColumnName("RESV_STATUS_DESC")
                .IsUnicode(false);
        });
	}
}
