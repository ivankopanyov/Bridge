namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QbRelation
{
    public string? EntiryName { get; set; }
    public string? FieldName { get; set; }
    public string? REntiryName { get; set; }
    public string? RFieldName { get; set; }
    public decimal? Position { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual QbField QbField { get; set; }
    public virtual QbField R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbRelation>(entity =>
        {
            entity.HasKey(e => new { e.EntiryName, e.FieldName, e.REntiryName, e.RFieldName })
                .HasName("QB_RELATION_PK");

            entity.ToTable("QB_RELATION");

            entity.Property(e => e.EntiryName)
                .HasColumnName("ENTIRY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.REntiryName)
                .HasColumnName("R_ENTIRY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RFieldName)
                .HasColumnName("R_FIELD_NAME")
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

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
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
			else
	            entity.HasOne(d => d.QbField)
	                .WithMany(p => p.QbRelationQbField)
	                .HasForeignKey(d => new { d.EntiryName, d.FieldName })
	                .HasConstraintName("QB_RELATION_FK1");

			if (!types.Contains(typeof(QbField)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.QbRelationR)
	                .HasForeignKey(d => new { d.REntiryName, d.RFieldName })
	                .HasConstraintName("QB_RELATION_FK2");
        });
	}
}
