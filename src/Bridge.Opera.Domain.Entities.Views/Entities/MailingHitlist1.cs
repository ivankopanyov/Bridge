namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailingHitlist1
{
    public decimal? QueryIdLink { get; set; }
    public string? HitlistTable { get; set; }
    public decimal? UserId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingHitlist1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAILING_HITLIST");

            entity.Property(e => e.HitlistTable)
                .IsRequired()
                .HasColumnName("HITLIST_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueryIdLink)
                .HasColumnName("QUERY_ID_LINK")
                .HasColumnType("NUMBER");

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
