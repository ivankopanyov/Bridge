namespace Bridge.Opera.Entities;

public class NameData
{
    public string BirthDay { get; set; }

    public string PassId { get; set; }

    public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
    {
        modelBuilder.Entity<NameData>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BirthDay)
                .HasColumnName("BIRTHDAY")
                .IsUnicode(false);

            entity.Property(e => e.PassId)
                .HasColumnName("PASS_ID")
                .IsUnicode(false);
        });
    }
}