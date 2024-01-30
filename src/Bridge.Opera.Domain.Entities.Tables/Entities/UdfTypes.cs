namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UdfTypes
{
    public UdfTypes()
    {
        UdfAttributes = new HashSet<UdfAttributes>();
    }

    public string? TableName { get; set; }
    public string? UdfType { get; set; }
    public string? Description { get; set; }
    public string? AttributeType { get; set; }
    public string? AttributeVerified { get; set; }
    public string? MultipleYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UdfCategory { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual ICollection<UdfAttributes> UdfAttributes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UdfTypes>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.UdfCategory, e.UdfType })
                .HasName("UDF_TYPES_PK");

            entity.ToTable("UDF_TYPES");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UdfCategory)
                .HasColumnName("UDF_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfType)
                .HasColumnName("UDF_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttributeType)
                .HasColumnName("ATTRIBUTE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttributeVerified)
                .HasColumnName("ATTRIBUTE_VERIFIED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleYn)
                .HasColumnName("MULTIPLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(UdfAttributes)))
				entity.Ignore(e => e.UdfAttributes);
		});
	}
}
