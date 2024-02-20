namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidActionTypeMandWhereSys
{
    public string? ExtSystemCode { get; set; }
    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? MandatoryWhereClause { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidActionTypeMandWhereSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ACTION_TYPE_MAND_WHERE_SYS");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystemCode)
                .IsRequired()
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryWhereClause)
                .HasColumnName("MANDATORY_WHERE_CLAUSE")
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
