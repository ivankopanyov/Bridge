namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidQbRelationSys
{
    public string EntiryName { get; set; }
    public string FieldName { get; set; }
    public string REntiryName { get; set; }
    public string RFieldName { get; set; }
    public decimal? Position { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidQbRelationSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_QB_RELATION_SYS");

            entity.Property(e => e.EntiryName)
                .IsRequired()
                .HasColumnName("ENTIRY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.REntiryName)
                .IsRequired()
                .HasColumnName("R_ENTIRY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RFieldName)
                .IsRequired()
                .HasColumnName("R_FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
