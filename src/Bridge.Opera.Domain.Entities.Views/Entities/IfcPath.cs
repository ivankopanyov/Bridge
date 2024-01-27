namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcPath
{
    public string Resort { get; set; }
    public decimal? PathId { get; set; }
    public string Path { get; set; }
    public string AccessCode { get; set; }
    public string Flags { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcPath>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_PATH");

            entity.Property(e => e.AccessCode)
                .HasColumnName("ACCESS_CODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Flags)
                .HasColumnName("FLAGS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Path)
                .HasColumnName("PATH")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PathId)
                .HasColumnName("PATH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
