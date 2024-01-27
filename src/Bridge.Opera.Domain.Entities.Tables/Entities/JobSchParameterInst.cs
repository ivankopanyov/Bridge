namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchParameterInst
{
    public decimal ParamId { get; set; }
    public decimal ParamListId { get; set; }
    public string ListCode { get; set; }
    public string ParamCode { get; set; }
    public decimal SeqId { get; set; }
    public decimal? ParentParamId { get; set; }
    public string ParamValue { get; set; }
    public string Datatype { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string ParentParamCode { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchParameterInst>(entity =>
        {
            entity.HasKey(e => e.ParamId)
                .HasName("JOB_SCH_PARAM_INST_PK");

            entity.ToTable("JOB_SCH_PARAMETER_INST");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("JOB_SCH_PARAM_INST_IND01");

            entity.HasIndex(e => new { e.ParamListId, e.ListCode, e.ParamCode, e.SeqId, e.ParentParamId })
                .HasName("JOB_SCH_PARAM_INST_UK01")
                .IsUnique();

            entity.Property(e => e.ParamId)
                .HasColumnName("PARAM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ListCode)
                .IsRequired()
                .HasColumnName("LIST_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParamCode)
                .IsRequired()
                .HasColumnName("PARAM_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParamListId)
                .HasColumnName("PARAM_LIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParamValue)
                .HasColumnName("PARAM_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.ParentParamCode)
                .HasColumnName("PARENT_PARAM_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParentParamId)
                .HasColumnName("PARENT_PARAM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqId)
                .HasColumnName("SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
