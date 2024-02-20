namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailingHitlist
{
    public decimal? QueryIdLink { get; set; }
    public string? HitlistTable { get; set; }
    public decimal? UserId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual MailingHeader QueryIdLinkNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingHitlist>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAILING$HITLIST");

            entity.HasIndex(e => e.QueryIdLink)
                .HasName("HL_MH_IDX");

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

			if (!types.Contains(typeof(MailingHeader)))
				entity.Ignore(e => e.QueryIdLinkNavigation);
			else
	            entity.HasOne(d => d.QueryIdLinkNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.QueryIdLink)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("HL_MH_FK");
        });
	}
}
