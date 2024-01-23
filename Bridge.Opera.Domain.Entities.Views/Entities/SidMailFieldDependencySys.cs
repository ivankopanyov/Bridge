namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailFieldDependencySys
{
    public decimal FieldId { get; set; }
    public decimal DependentFieldId { get; set; }
    public string Param1 { get; set; }
    public string Param2 { get; set; }
    public string Param3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailFieldDependencySys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAIL_FIELD_DEPENDENCY_SYS");

            entity.Property(e => e.DependentFieldId)
                .HasColumnName("DEPENDENT_FIELD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FieldId)
                .HasColumnName("FIELD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Param1)
                .HasColumnName("PARAM1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Param2)
                .HasColumnName("PARAM2")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Param3)
                .HasColumnName("PARAM3")
                .HasMaxLength(500)
                .IsUnicode(false);
        });
	}
}
