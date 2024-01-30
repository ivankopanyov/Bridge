namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempCcIfcParam
{
    public decimal? Seq { get; set; }
    public string? ParamName { get; set; }
    public string? ParamValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempCcIfcParam>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_CC_IFC_PARAM");

            entity.Property(e => e.ParamName)
                .HasColumnName("PARAM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ParamValue)
                .HasColumnName("PARAM_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
