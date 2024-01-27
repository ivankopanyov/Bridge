namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MergeDetails1
{
    public decimal MergeIdLink { get; set; }
    public string TableName { get; set; }
    public string FieldName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MergeDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MERGE_DETAILS");

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
        });
	}
}
