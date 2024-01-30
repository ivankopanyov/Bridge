namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRqTypeDimVw
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RequestType { get; set; }
    public string? RequestTypeDesc { get; set; }
    public string? ResortId { get; set; }
    public string? RequestTypeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRqTypeDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RQ_TYPE_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RequestType)
                .HasColumnName("REQUEST_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RequestTypeDesc)
                .HasColumnName("REQUEST_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RequestTypeKey)
                .HasColumnName("REQUEST_TYPE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
