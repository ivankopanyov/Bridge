namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchDynamicCodes
{
    public string? DynCodeId { get; set; }
    public string? ProcedureName { get; set; }
    public string? ProcedureDesc { get; set; }
    public string? ProcedureType { get; set; }
    public string? CodeText { get; set; }
    public string? XmlText { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ListCode { get; set; }
    public string? CanDeleteYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchDynamicCodes>(entity =>
        {
            entity.HasKey(e => e.DynCodeId)
                .HasName("DPT_PK");

            entity.ToTable("JOB_SCH_DYNAMIC_CODES");

            entity.Property(e => e.DynCodeId)
                .HasColumnName("DYN_CODE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CodeText)
                .HasColumnName("CODE_TEXT")
                .HasColumnType("CLOB");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ListCode)
                .HasColumnName("LIST_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProcedureDesc)
                .HasColumnName("PROCEDURE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcedureType)
                .HasColumnName("PROCEDURE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XmlText)
                .HasColumnName("XML_TEXT")
                .HasColumnType("CLOB");
        });
	}
}
