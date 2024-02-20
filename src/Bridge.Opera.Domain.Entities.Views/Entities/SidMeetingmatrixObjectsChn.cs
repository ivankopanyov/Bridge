namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMeetingmatrixObjectsChn
{
    public string? ChainCode { get; set; }
    public string? ObjectGroup { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMeetingmatrixObjectsChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MEETINGMATRIX_OBJECTS_CHN");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjectGroup)
                .IsRequired()
                .HasColumnName("OBJECT_GROUP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .IsRequired()
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
