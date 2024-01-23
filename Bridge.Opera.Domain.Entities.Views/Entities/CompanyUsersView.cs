namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CompanyUsersView
{
    public decimal NameId { get; set; }
    public string DisplayName { get; set; }
    public decimal CompanyId { get; set; }
    public decimal? MasterCompanyId { get; set; }
    public string AppUser { get; set; }
    public decimal AppUserId { get; set; }
    public string UserGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CompanyUsersView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COMPANY_USERS_VIEW");

            entity.Property(e => e.AppUser)
                .IsRequired()
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.MasterCompanyId)
                .HasColumnName("MASTER_COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserGroup)
                .HasColumnName("USER_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
