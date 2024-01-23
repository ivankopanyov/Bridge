namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisNameLov
{
    public string Last { get; set; }
    public string First { get; set; }
    public decimal NameId { get; set; }
    public string Sname { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisNameLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_NAME_LOV");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
