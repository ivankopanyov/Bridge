namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObpStatus
{
    public string ProcedureName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Status { get; set; }
    public string ErrorDesc { get; set; }
    public string ProcessInfo { get; set; }

    public virtual ObpProcedures ProcedureNameNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObpStatus>(entity =>
        {
            entity.HasKey(e => new { e.ProcedureName, e.StartDate })
                .HasName("OBP_STATUS_PK");

            entity.ToTable("OBP_STATUS");

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ProcessInfo)
                .HasColumnName("PROCESS_INFO")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ObpProcedures)))
				entity.Ignore(e => e.ProcedureNameNavigation);
			else
	            entity.HasOne(d => d.ProcedureNameNavigation)
	                .WithMany(p => p.ObpStatus)
	                .HasForeignKey(d => d.ProcedureName)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OBP_PROC_STATUS_FK");
        });
	}
}
