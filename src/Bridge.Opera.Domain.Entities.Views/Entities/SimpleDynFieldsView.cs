namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SimpleDynFieldsView
{
    public string? Resort { get; set; }
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }
    public string? HideYn { get; set; }
    public string? ExecuteYn { get; set; }
    public string? DefaultValue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SimpleDynFieldsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SIMPLE_DYN_FIELDS_VIEW");

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.ExecuteYn)
                .HasColumnName("EXECUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HideYn)
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
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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
