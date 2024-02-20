namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrsUdfVw
{
    public decimal? NameId { get; set; }
    public string? Colname { get; set; }
    public string? Col1 { get; set; }
    public decimal? Col2 { get; set; }
    public DateTime? Col3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsUdfVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORS_UDF_VW");

            entity.Property(e => e.Col1)
                .HasColumnName("COL1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Col2)
                .HasColumnName("COL2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Col3)
                .HasColumnName("COL3")
                .HasColumnType("DATE");

            entity.Property(e => e.Colname)
                .HasColumnName("COLNAME")
                .HasColumnType("CHAR(6)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
