namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCmSourceDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? SourceCode { get; set; }
    public string? SourceDesc { get; set; }
    public string? SourceGroup { get; set; }
    public string? SourceGroupDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCmSourceDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CM_SOURCE_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SourceDesc)
                .HasColumnName("SOURCE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceGroup)
                .HasColumnName("SOURCE_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.SourceGroupDesc)
                .HasColumnName("SOURCE_GROUP_DESC")
                .IsUnicode(false);
        });
	}
}
