namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidChnlCnvParamNamesSys
{
    public string ParameterName { get; set; }
    public string ParameterDisplay { get; set; }
    public string Description { get; set; }
    public string ParameterScope { get; set; }
    public string ParameterType { get; set; }
    public string ParameterGroup { get; set; }
    public string DefaultValue { get; set; }
    public string LovValues { get; set; }
    public string UsedInApp { get; set; }
    public string HiddenYn { get; set; }
    public string ForbidCopyYn { get; set; }
    public string CanDeleteYn { get; set; }
    public string NullAllowedYn { get; set; }
    public string FreeTextYn { get; set; }
    public string MixedCaseYn { get; set; }
    public string ExtendedLovYn { get; set; }
    public string MultiselectYn { get; set; }
    public string LovWindowTtl { get; set; }
    public string LovDescLbl { get; set; }
    public string LovValidateFunc { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string ParamProperties { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidChnlCnvParamNamesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CHNL_CNV_PARAM_NAMES_SYS");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtendedLovYn)
                .HasColumnName("EXTENDED_LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ForbidCopyYn)
                .HasColumnName("FORBID_COPY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FreeTextYn)
                .HasColumnName("FREE_TEXT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HiddenYn)
                .HasColumnName("HIDDEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LovDescLbl)
                .HasColumnName("LOV_DESC_LBL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LovValidateFunc)
                .HasColumnName("LOV_VALIDATE_FUNC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LovValues)
                .HasColumnName("LOV_VALUES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LovWindowTtl)
                .HasColumnName("LOV_WINDOW_TTL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MixedCaseYn)
                .HasColumnName("MIXED_CASE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MultiselectYn)
                .HasColumnName("MULTISELECT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NullAllowedYn)
                .HasColumnName("NULL_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParamProperties)
                .HasColumnName("PARAM_PROPERTIES")
                .IsUnicode(false);

            entity.Property(e => e.ParameterDisplay)
                .IsRequired()
                .HasColumnName("PARAMETER_DISPLAY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterGroup)
                .HasColumnName("PARAMETER_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterScope)
                .IsRequired()
                .HasColumnName("PARAMETER_SCOPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ParameterType)
                .IsRequired()
                .HasColumnName("PARAMETER_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInApp)
                .IsRequired()
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
