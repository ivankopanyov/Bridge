namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrsResvLookupFields
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string FldName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsResvLookupFields>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORS_RESV_LOOKUP_FIELDS");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FldName)
                .HasColumnName("FLD_NAME")
                .HasMaxLength(17)
                .IsUnicode(false);
        });
	}
}
