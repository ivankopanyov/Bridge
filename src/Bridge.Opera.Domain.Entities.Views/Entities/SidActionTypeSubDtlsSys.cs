namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidActionTypeSubDtlsSys
{
    public string? ExtSystemCode { get; set; }
    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? DataElement { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidActionTypeSubDtlsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ACTION_TYPE_SUB_DTLS_SYS");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystemCode)
                .IsRequired()
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
