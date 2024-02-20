namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActDbOnholdItems
{
    public decimal? ActivityId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? GuestFullName { get; set; }
    public string? Type { get; set; }
    public string? Description { get; set; }
    public DateTime? BeginDate { get; set; }
    public string? BeginTime { get; set; }
    public DateTime? EndDate { get; set; }
    public string? EndTime { get; set; }
    public decimal? Persons { get; set; }
    public decimal? Amount { get; set; }
    public string? Notes { get; set; }

    public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
    {
        modelBuilder.Entity<ActDbOnholdItems>(entity =>
        {
            entity.HasKey(e => e.ActivityId)
                .HasName("ACT_DB_ONHOLD_PK");

            entity.ToTable("ACT_DB_ONHOLD_ITEMS");

            entity.Property(e => e.ActivityId)
                .HasColumnName("ACTIVITY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestFullName)
                .HasColumnName("GUEST_FULL_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
    }
}
