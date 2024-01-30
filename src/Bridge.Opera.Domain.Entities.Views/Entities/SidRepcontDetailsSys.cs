namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidRepcontDetailsSys
{
    public decimal? AttachId { get; set; }
    public string? Tablename { get; set; }
    public string? Fieldname { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidRepcontDetailsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_REPCONT$DETAILS_SYS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fieldname)
                .IsRequired()
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tablename)
                .IsRequired()
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
