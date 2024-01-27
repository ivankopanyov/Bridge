namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AppExternalFormsView
{
    public decimal ModuleId { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDesc { get; set; }
    public string ModuleType { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string InsertUser { get; set; }
    public string InsertDate { get; set; }
    public string RelModName { get; set; }
    public string AnyParameters { get; set; }
    public string CanBeRunSeparately { get; set; }
    public string LanguageCode { get; set; }
    public string FormToRun { get; set; }
    public string ProtectedYn { get; set; }
    public string UsedInApp { get; set; }
    public string UserDefinedYn { get; set; }
    public string GroupInApp { get; set; }
    public decimal GroupModuleId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppExternalFormsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APP_EXTERNAL_FORMS_VIEW");

            entity.Property(e => e.AnyParameters)
                .HasColumnName("ANY_PARAMETERS")
                .IsUnicode(false);

            entity.Property(e => e.CanBeRunSeparately)
                .HasColumnName("CAN_BE_RUN_SEPARATELY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FormToRun)
                .HasColumnName("FORM_TO_RUN")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GroupInApp)
                .HasColumnName("GROUP_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupModuleId)
                .HasColumnName("GROUP_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProtectedYn)
                .HasColumnName("PROTECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelModName)
                .IsRequired()
                .HasColumnName("REL_MOD_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserDefinedYn)
                .HasColumnName("USER_DEFINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
