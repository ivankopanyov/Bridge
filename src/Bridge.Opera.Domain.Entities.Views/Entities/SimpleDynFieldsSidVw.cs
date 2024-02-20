namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SimpleDynFieldsSidVw
{
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }
    public string? ChildObjectType1 { get; set; }
    public string? ChildObjectName1 { get; set; }
    public string? ChildObjectType2 { get; set; }
    public string? ChildObjectName2 { get; set; }
    public string? ObjectDatatype { get; set; }
    public string? HideYn { get; set; }
    public string? DefaultYn { get; set; }
    public string? Resort { get; set; }
    public string? Hide { get; set; }
    public string? ExecuteYn { get; set; }
    public string? DefaultValue { get; set; }
    public string? ScreenLabel { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? DefaultValueDisp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SimpleDynFieldsSidVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SIMPLE_DYN_FIELDS_SID_VW");

            entity.Property(e => e.ChildObjectName1)
                .HasColumnName("CHILD_OBJECT_NAME1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildObjectName2)
                .HasColumnName("CHILD_OBJECT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildObjectType1)
                .HasColumnName("CHILD_OBJECT_TYPE1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildObjectType2)
                .HasColumnName("CHILD_OBJECT_TYPE2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.DefaultValueDisp)
                .HasColumnName("DEFAULT_VALUE_DISP")
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .IsRequired()
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExecuteYn)
                .HasColumnName("EXECUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Hide)
                .HasColumnName("HIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HideYn)
                .IsRequired()
                .HasColumnName("HIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

            entity.Property(e => e.ObjectDatatype)
                .IsRequired()
                .HasColumnName("OBJECT_DATATYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .IsRequired()
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScreenLabel)
                .HasColumnName("SCREEN_LABEL")
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
