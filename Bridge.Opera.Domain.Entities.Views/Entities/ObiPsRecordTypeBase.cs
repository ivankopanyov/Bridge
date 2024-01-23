namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPsRecordTypeBase
{
    public string PosRecType { get; set; }
    public string PosRecTypeDesc { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPsRecordTypeBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PS_RECORD_TYPE_BASE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PosRecType)
                .HasColumnName("POS_REC_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.PosRecTypeDesc)
                .HasColumnName("POS_REC_TYPE_DESC")
                .IsUnicode(false);
        });
	}
}
