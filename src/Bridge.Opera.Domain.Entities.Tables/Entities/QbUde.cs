namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QbUde
{
    public QbUde()
    {
        QbUdeParam = new HashSet<QbUdeParam>();
    }

    public string UdeCode { get; set; }
    public string UdeGroup { get; set; }
    public string UdeDesc { get; set; }
    public string UdeName { get; set; }
    public string EntityName { get; set; }
    public string DataType { get; set; }
    public string UdeType { get; set; }
    public string UdeLov { get; set; }
    public string UdeText { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string SidYn { get; set; }
    public string Resort { get; set; }

    public virtual ICollection<QbUdeParam> QbUdeParam { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbUde>(entity =>
        {
            entity.HasKey(e => e.UdeCode)
                .HasName("QB_UDE_PK");

            entity.ToTable("QB_UDE");

            entity.Property(e => e.UdeCode)
                .HasColumnName("UDE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EntityName)
                .HasColumnName("ENTITY_NAME")
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

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SidYn)
                .HasColumnName("SID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdeDesc)
                .HasColumnName("UDE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.UdeGroup)
                .HasColumnName("UDE_GROUP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UdeLov)
                .HasColumnName("UDE_LOV")
                .IsUnicode(false);

            entity.Property(e => e.UdeName)
                .HasColumnName("UDE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UdeText)
                .HasColumnName("UDE_TEXT")
                .HasColumnType("CLOB");

            entity.Property(e => e.UdeType)
                .HasColumnName("UDE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(QbUdeParam)))
				entity.Ignore(e => e.QbUdeParam);
		});
	}
}
