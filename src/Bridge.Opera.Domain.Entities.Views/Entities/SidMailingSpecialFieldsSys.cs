namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailingSpecialFieldsSys
{
    public string FieldName { get; set; }
    public string Description { get; set; }
    public string QuerySource { get; set; }
    public string QueryStatement { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailingSpecialFieldsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAILING$SPECIAL_FIELDS_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuerySource)
                .IsRequired()
                .HasColumnName("QUERY_SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.QueryStatement)
                .IsRequired()
                .HasColumnName("QUERY_STATEMENT")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
