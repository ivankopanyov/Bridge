namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidObpProceduresSys
{
    public string ProcedureName { get; set; }
    public string Frequency { get; set; }
    public string WhenToExecute { get; set; }
    public DateTime? NextDate { get; set; }
    public string ActiveYn { get; set; }
    public decimal? Sequence { get; set; }
    public string MandatoryYn { get; set; }
    public string PropertySpecificYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidObpProceduresSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OBP_PROCEDURES_SYS");

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .IsRequired()
                .HasColumnName("FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryYn)
                .IsRequired()
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NextDate)
                .HasColumnName("NEXT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcedureName)
                .IsRequired()
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertySpecificYn)
                .HasColumnName("PROPERTY_SPECIFIC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WhenToExecute)
                .IsRequired()
                .HasColumnName("WHEN_TO_EXECUTE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
