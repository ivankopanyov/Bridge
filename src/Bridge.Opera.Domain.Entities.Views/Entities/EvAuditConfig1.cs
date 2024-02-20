namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EvAuditConfig1
{
    public string? Tablename { get; set; }
    public string? Fieldname { get; set; }
    public string? InsertYn { get; set; }
    public string? UpdateYn { get; set; }
    public string? DeleteYn { get; set; }
    public string? ResourceType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvAuditConfig1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EV_AUDIT_CONFIG");

            entity.Property(e => e.DeleteYn)
                .HasColumnName("DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Fieldname)
                .IsRequired()
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertYn)
                .HasColumnName("INSERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResourceType)
                .HasColumnName("RESOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tablename)
                .IsRequired()
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UpdateYn)
                .HasColumnName("UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
