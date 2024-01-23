namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntIfcRulesTab1
{
    public string InterfaceId { get; set; }
    public string Region { get; set; }
    public string ProfileType { get; set; }
    public string DisplayName { get; set; }
    public string OrsTable { get; set; }
    public string OrsColumn { get; set; }
    public string PmsTable { get; set; }
    public string PmsColumn { get; set; }
    public string ToOrs { get; set; }
    public string ToPms { get; set; }
    public string Broadcast { get; set; }
    public string OrsMandatory { get; set; }
    public string PmsCaseSetting { get; set; }
    public string PmsMandatory { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string OptionsToOrs { get; set; }
    public string RequiredYn { get; set; }
    public string DataElement { get; set; }
    public string UdfRule { get; set; }
    public string ModuleName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntIfcRulesTab1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_IFC_RULES_TAB");

            entity.Property(e => e.Broadcast)
                .IsRequired()
                .HasColumnName("BROADCAST")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OptionsToOrs)
                .HasColumnName("OPTIONS_TO_ORS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.OrsColumn)
                .IsRequired()
                .HasColumnName("ORS_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrsMandatory)
                .HasColumnName("ORS_MANDATORY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrsTable)
                .IsRequired()
                .HasColumnName("ORS_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PmsCaseSetting)
                .HasColumnName("PMS_CASE_SETTING")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PmsColumn)
                .HasColumnName("PMS_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PmsMandatory)
                .HasColumnName("PMS_MANDATORY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PmsTable)
                .HasColumnName("PMS_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ProfileType)
                .IsRequired()
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .IsRequired()
                .HasColumnName("REGION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToOrs)
                .IsRequired()
                .HasColumnName("TO_ORS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ToPms)
                .IsRequired()
                .HasColumnName("TO_PMS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UdfRule)
                .IsRequired()
                .HasColumnName("UDF_RULE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(38)");
        });
	}
}
