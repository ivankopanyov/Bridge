namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MergeDetails
{
    public decimal MergeIdLink { get; set; }
    public string TableName { get; set; }
    public string FieldName { get; set; }

    public virtual MergeHeader MergeIdLinkNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MergeDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MERGE$DETAILS");

            entity.HasIndex(e => e.MergeIdLink)
                .HasName("MGD_MGH_IDX");

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MergeIdLink)
                .HasColumnName("MERGE_ID_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(MergeHeader)))
				entity.Ignore(e => e.MergeIdLinkNavigation);
			else
	            entity.HasOne(d => d.MergeIdLinkNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.MergeIdLink)
	                .HasConstraintName("MGD_MGH_FK");
        });
	}
}
