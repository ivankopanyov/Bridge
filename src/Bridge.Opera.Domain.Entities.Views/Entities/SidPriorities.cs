namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidPriorities
{
    public string Resort { get; set; }
    public string PriorityCode { get; set; }
    public string Description { get; set; }
    public decimal PrioritySeqNumber { get; set; }
    public string ColorCode { get; set; }
    public string ColorCodeDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidPriorities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PRIORITIES");

            entity.Property(e => e.ColorCode)
                .HasColumnName("COLOR_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ColorCodeDescription)
                .HasColumnName("COLOR_CODE_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PriorityCode)
                .IsRequired()
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrioritySeqNumber)
                .HasColumnName("PRIORITY_SEQ_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
