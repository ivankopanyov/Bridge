namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailingHeader
{
    public decimal? QueryId { get; set; }
    public decimal? UserId { get; set; }
    public string? QueryName { get; set; }
    public string? Description { get; set; }
    public string? QueryStatement { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingHeader>(entity =>
        {
            entity.HasKey(e => e.QueryId)
                .HasName("MH_PK");

            entity.ToTable("MAILING$HEADER");

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueryName)
                .HasColumnName("QUERY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.QueryStatement)
                .HasColumnName("QUERY_STATEMENT")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");
        });
	}
}
