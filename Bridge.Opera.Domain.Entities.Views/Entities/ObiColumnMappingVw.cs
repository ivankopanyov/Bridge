namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiColumnMappingVw
{
    public string BiTableName { get; set; }
    public string BiCode { get; set; }
    public string BiLabel { get; set; }
    public string OperaCode { get; set; }
    public string OperaResort { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string OperaCodeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiColumnMappingVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_COLUMN_MAPPING_VW");

            entity.Property(e => e.BiCode)
                .IsRequired()
                .HasColumnName("BI_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BiLabel)
                .HasColumnName("BI_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BiTableName)
                .IsRequired()
                .HasColumnName("BI_TABLE_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaCode)
                .IsRequired()
                .HasColumnName("OPERA_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OperaCodeDesc)
                .HasColumnName("OPERA_CODE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OperaResort)
                .HasColumnName("OPERA_RESORT")
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
