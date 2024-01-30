namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidDynamicProceduresSys
{
    public string? ProcedureGroup { get; set; }
    public string? ProcedureType { get; set; }
    public decimal? ProcedureBlockSeq { get; set; }
    public string? ProcedureBlock { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidDynamicProceduresSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_DYNAMIC_PROCEDURES_SYS");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcedureBlock)
                .IsRequired()
                .HasColumnName("PROCEDURE_BLOCK")
                .IsUnicode(false);

            entity.Property(e => e.ProcedureBlockSeq)
                .HasColumnName("PROCEDURE_BLOCK_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcedureGroup)
                .IsRequired()
                .HasColumnName("PROCEDURE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcedureType)
                .IsRequired()
                .HasColumnName("PROCEDURE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
