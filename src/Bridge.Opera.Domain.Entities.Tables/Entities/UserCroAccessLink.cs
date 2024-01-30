namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UserCroAccessLink
{
    public decimal? AppUserId { get; set; }
    public string? CroCode { get; set; }

    public virtual Resort CroCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserCroAccessLink>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.CroCode })
                .HasName("USER_CRO_ACCESS_LINK_PK");

            entity.ToTable("USER_CRO_ACCESS_LINK");

            entity.HasIndex(e => e.CroCode)
                .HasName("USER_CRO_ACCESS_LINK_IDX1");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CroCode)
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.CroCodeNavigation);
			else
	            entity.HasOne(d => d.CroCodeNavigation)
	                .WithMany(p => p.UserCroAccessLink)
	                .HasForeignKey(d => d.CroCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("USER_CRO_ACCESS_LINK_FK");
        });
	}
}
