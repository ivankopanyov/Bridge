namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcCrossRef
{
    public decimal IfcCtrlId { get; set; }
    public string PmsVal { get; set; }
    public string IfcVal { get; set; }
    public string ValType { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCrossRef>(entity =>
        {
            entity.HasKey(e => new { e.IfcCtrlId, e.ValType, e.IfcVal })
                .HasName("IFC_CROSS_REF_PK");

            entity.ToTable("IFC_CROSS_REF");

            entity.HasIndex(e => new { e.IfcCtrlId, e.ValType, e.PmsVal })
                .HasName("IFC_CROSS_ID_TYP_PMS_IND");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValType)
                .HasColumnName("VAL_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IfcVal)
                .HasColumnName("IFC_VAL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PmsVal)
                .HasColumnName("PMS_VAL")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
