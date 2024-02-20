namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObpProcedures
{
    public ObpProcedures()
    {
        ObpStatus = new HashSet<ObpStatus>();
    }

    public string? ProcedureName { get; set; }
    public string? Frequency { get; set; }
    public string? WhenToExecute { get; set; }
    public DateTime? NextDate { get; set; }
    public string? ActiveYn { get; set; }
    public decimal? Sequence { get; set; }
    public string? MandatoryYn { get; set; }
    public string? PropertySpecificYn { get; set; }

    public virtual ICollection<ObpStatus> ObpStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObpProcedures>(entity =>
        {
            entity.HasKey(e => e.ProcedureName)
                .HasName("OBP_PROCEDURES_PK");

            entity.ToTable("OBP_PROCEDURES");

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Frequency)
                .IsRequired()
                .HasColumnName("FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'D'");

            entity.Property(e => e.MandatoryYn)
                .IsRequired()
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.NextDate)
                .HasColumnName("NEXT_DATE")
                .HasColumnType("DATE");

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
        
			if (!types.Contains(typeof(ObpStatus)))
				entity.Ignore(e => e.ObpStatus);
		});
	}
}
