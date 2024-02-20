namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisMembershipHistory
{
    public decimal? MembershipId { get; set; }
    public string? ChangeType { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisMembershipHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_MEMBERSHIP_HISTORY");

            entity.Property(e => e.ChangeType)
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
