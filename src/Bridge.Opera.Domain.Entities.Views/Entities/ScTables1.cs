namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScTables1
{
    public string? Tablename { get; set; }
    public string? Language { get; set; }
    public string? DisplayName { get; set; }
    public string? SystemYn { get; set; }
    public string? ObjType { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScTables1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_TABLES");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .IsRequired()
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjType)
                .HasColumnName("OBJ_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SystemYn)
                .HasColumnName("SYSTEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Tablename)
                .IsRequired()
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
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
