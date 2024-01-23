namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QbEntity
{
    public QbEntity()
    {
        QbField = new HashSet<QbField>();
    }

    public string EntityName { get; set; }
    public string EntityLabel { get; set; }
    public string BaseTable { get; set; }
    public string EntityAlias { get; set; }
    public string EntityDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual ICollection<QbField> QbField { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbEntity>(entity =>
        {
            entity.HasKey(e => e.EntityName)
                .HasName("QB_ENTITY_PK");

            entity.ToTable("QB_ENTITY");

            entity.Property(e => e.EntityName)
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BaseTable)
                .HasColumnName("BASE_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityAlias)
                .HasColumnName("ENTITY_ALIAS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityDesc)
                .HasColumnName("ENTITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EntityLabel)
                .HasColumnName("ENTITY_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(QbField)))
				entity.Ignore(e => e.QbField);
		});
	}
}
