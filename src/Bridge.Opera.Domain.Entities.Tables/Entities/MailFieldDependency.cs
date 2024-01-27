namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailFieldDependency
{
    public decimal FieldId { get; set; }
    public decimal DependentFieldId { get; set; }
    public string Param1 { get; set; }
    public string Param2 { get; set; }
    public string Param3 { get; set; }

    public virtual MailVirtualFields DependentField { get; set; }
    public virtual MailVirtualFields Field { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailFieldDependency>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAIL_FIELD_DEPENDENCY");

            entity.HasIndex(e => e.DependentFieldId)
                .HasName("MAILFD_DEPFIELDID_IDX");

            entity.HasIndex(e => e.FieldId)
                .HasName("MAILFD_FIELDID_IDX");

            entity.Property(e => e.DependentFieldId)
                .HasColumnName("DEPENDENT_FIELD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FieldId)
                .HasColumnName("FIELD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Param1)
                .HasColumnName("PARAM1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Param2)
                .HasColumnName("PARAM2")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Param3)
                .HasColumnName("PARAM3")
                .HasMaxLength(500)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailVirtualFields)))
				entity.Ignore(e => e.DependentField);
			else
	            entity.HasOne(d => d.DependentField)
	                .WithMany()
	                .HasForeignKey(d => d.DependentFieldId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILFD_MAILVF_FK2");

			if (!types.Contains(typeof(MailVirtualFields)))
				entity.Ignore(e => e.Field);
			else
	            entity.HasOne(d => d.Field)
	                .WithMany()
	                .HasForeignKey(d => d.FieldId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILFD_MAILVF_FK");
        });
	}
}
