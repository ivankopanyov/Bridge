namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UserAccessView
{
    public string AppUser { get; set; }
    public string FullName { get; set; }
    public decimal? AppUserId { get; set; }
    public decimal? NameId { get; set; }
    public string Resort { get; set; }
    public string Skipcompare { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserAccessView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USER_ACCESS_VIEW");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Skipcompare)
                .HasColumnName("SKIPCOMPARE")
                .HasColumnType("CHAR(1)");
        });
	}
}
