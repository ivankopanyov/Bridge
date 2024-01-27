namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntApplicationUsers
{
    public string ExtSystemCode { get; set; }
    public decimal? AppUserId { get; set; }
    public string SystemType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntApplicationUsers>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_APPLICATION_USERS");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtSystemCode)
                .IsRequired()
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
