namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiStayRecTypeDim
{
    public string? AllId { get; set; }
    public string? AllDesc { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? ResortId { get; set; }
    public string? RecTypeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiStayRecTypeDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_STAY_REC_TYPE_DIM");

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllId)
                .HasColumnName("ALL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.RecTypeKey)
                .HasColumnName("REC_TYPE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
