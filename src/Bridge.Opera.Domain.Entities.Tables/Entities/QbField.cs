namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QbField
{
    public QbField()
    {
        QbRelationQbField = new HashSet<QbRelation>();
        QbRelationR = new HashSet<QbRelation>();
    }

    public string? EntityName { get; set; }
    public string? FieldName { get; set; }
    public string? FieldLabel { get; set; }
    public string? FieldDesc { get; set; }
    public string? BaseColumn { get; set; }
    public string? DataType { get; set; }
    public string? FieldLov { get; set; }
    public string? IdxLeadYn { get; set; }
    public string? IdxPartYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual QbEntity EntityNameNavigation { get; set; }
    public virtual ICollection<QbRelation> QbRelationQbField { get; set; }
    public virtual ICollection<QbRelation> QbRelationR { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbField>(entity =>
        {
            entity.HasKey(e => new { e.EntityName, e.FieldName })
                .HasName("QB_FIELD_PK");

            entity.ToTable("QB_FIELD");

            entity.Property(e => e.EntityName)
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BaseColumn)
                .HasColumnName("BASE_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FieldDesc)
                .HasColumnName("FIELD_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FieldLabel)
                .HasColumnName("FIELD_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldLov)
                .HasColumnName("FIELD_LOV")
                .IsUnicode(false);

            entity.Property(e => e.IdxLeadYn)
                .HasColumnName("IDX_LEAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IdxPartYn)
                .HasColumnName("IDX_PART_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(QbEntity)))
				entity.Ignore(e => e.EntityNameNavigation);
			else
	            entity.HasOne(d => d.EntityNameNavigation)
	                .WithMany(p => p.QbField)
	                .HasForeignKey(d => d.EntityName)
	                .HasConstraintName("QB_FIELD_FK1");
        
			if (!types.Contains(typeof(QbRelation)))
				entity.Ignore(e => e.QbRelationQbField);

			if (!types.Contains(typeof(QbRelation)))
				entity.Ignore(e => e.QbRelationR);
		});
	}
}
