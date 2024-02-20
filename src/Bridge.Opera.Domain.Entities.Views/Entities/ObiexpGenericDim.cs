namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpGenericDim
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? TableName { get; set; }
    public string? Resort { get; set; }
    public string? ChainCode { get; set; }
    public string? AllKey { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? Key1 { get; set; }
    public string? Code1 { get; set; }
    public string? Desc1 { get; set; }
    public string? Attribute11 { get; set; }
    public string? Attribute12 { get; set; }
    public string? Attribute13 { get; set; }
    public string? Attribute14 { get; set; }
    public string? Attribute15 { get; set; }
    public string? Key2 { get; set; }
    public string? Code2 { get; set; }
    public string? Desc2 { get; set; }
    public string? Attribute21 { get; set; }
    public string? Attribute22 { get; set; }
    public string? Attribute23 { get; set; }
    public string? Attribute24 { get; set; }
    public string? Attribute25 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpGenericDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_GENERIC_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Attribute11)
                .HasColumnName("ATTRIBUTE1_1")
                .IsUnicode(false);

            entity.Property(e => e.Attribute12)
                .HasColumnName("ATTRIBUTE1_2")
                .IsUnicode(false);

            entity.Property(e => e.Attribute13)
                .HasColumnName("ATTRIBUTE1_3")
                .IsUnicode(false);

            entity.Property(e => e.Attribute14)
                .HasColumnName("ATTRIBUTE1_4")
                .IsUnicode(false);

            entity.Property(e => e.Attribute15)
                .HasColumnName("ATTRIBUTE1_5")
                .IsUnicode(false);

            entity.Property(e => e.Attribute21)
                .HasColumnName("ATTRIBUTE2_1")
                .IsUnicode(false);

            entity.Property(e => e.Attribute22)
                .HasColumnName("ATTRIBUTE2_2")
                .IsUnicode(false);

            entity.Property(e => e.Attribute23)
                .HasColumnName("ATTRIBUTE2_3")
                .IsUnicode(false);

            entity.Property(e => e.Attribute24)
                .HasColumnName("ATTRIBUTE2_4")
                .IsUnicode(false);

            entity.Property(e => e.Attribute25)
                .HasColumnName("ATTRIBUTE2_5")
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code1)
                .IsRequired()
                .HasColumnName("CODE1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Code2)
                .HasColumnName("CODE2")
                .IsUnicode(false);

            entity.Property(e => e.Desc1)
                .HasColumnName("DESC1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Desc2)
                .HasColumnName("DESC2")
                .IsUnicode(false);

            entity.Property(e => e.Key1)
                .HasColumnName("KEY1")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.Key2)
                .HasColumnName("KEY2")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasColumnType("CHAR(7)");

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
