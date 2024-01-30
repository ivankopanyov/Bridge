namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiResInsSrcDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? ResInsSrcType { get; set; }
    public string? ResInsSrcTypeDesc { get; set; }
    public string? ResInsSrc { get; set; }
    public string? ResInsSrcDesc { get; set; }
    public string? ResortId { get; set; }
    public string? ResInsSrcTypeKey { get; set; }
    public string? ResInsSrcKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiResInsSrcDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RES_INS_SRC_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResInsSrc)
                .HasColumnName("RES_INS_SRC")
                .IsUnicode(false);

            entity.Property(e => e.ResInsSrcDesc)
                .HasColumnName("RES_INS_SRC_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResInsSrcKey)
                .HasColumnName("RES_INS_SRC_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResInsSrcType)
                .HasColumnName("RES_INS_SRC_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.ResInsSrcTypeDesc)
                .HasColumnName("RES_INS_SRC_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResInsSrcTypeKey)
                .HasColumnName("RES_INS_SRC_TYPE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
