namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchParameterDef
{
    public string ListCode { get; set; }
    public string ParamCode { get; set; }
    public string ParentParamCode { get; set; }
    public string DisplayName { get; set; }
    public string Datatype { get; set; }
    public string DefaultValue { get; set; }
    public string DeleteYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchParameterDef>(entity =>
        {
            entity.HasKey(e => new { e.ListCode, e.ParamCode })
                .HasName("JOB_SCH_PARAM_DEF_PK");

            entity.ToTable("JOB_SCH_PARAMETER_DEF");

            entity.HasIndex(e => new { e.ListCode, e.ParamCode, e.ParentParamCode })
                .HasName("JOB_SCH_PARAMETER_DEF_UK01")
                .IsUnique();

            entity.Property(e => e.ListCode)
                .HasColumnName("LIST_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParamCode)
                .HasColumnName("PARAM_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.DeleteYn)
                .HasColumnName("DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentParamCode)
                .HasColumnName("PARENT_PARAM_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
