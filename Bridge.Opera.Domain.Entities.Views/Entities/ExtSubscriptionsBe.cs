namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExtSubscriptionsBe
{
    public decimal DataElementId { get; set; }
    public string ActionType { get; set; }
    public decimal ActionInstanceId { get; set; }
    public string TargetId { get; set; }
    public decimal? ElementSeq { get; set; }
    public string TargetSystem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtSubscriptionsBe>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXT_SUBSCRIPTIONS_BE");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DataElementId)
                .HasColumnName("DATA_ELEMENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElementSeq)
                .HasColumnName("ELEMENT_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TargetId)
                .HasColumnName("TARGET_ID")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TargetSystem)
                .HasColumnName("TARGET_SYSTEM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
