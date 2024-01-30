namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BuildadminSidList
{
    public string? ViewName { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BuildadminSidList>(entity =>
        {
            entity.HasKey(e => e.ViewName)
                .HasName("BASID_PK");

            entity.ToTable("BUILDADMIN_SID_LIST");

            entity.Property(e => e.ViewName)
                .HasColumnName("VIEW_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
