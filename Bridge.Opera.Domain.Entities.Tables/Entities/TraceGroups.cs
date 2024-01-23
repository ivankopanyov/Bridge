namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TraceGroups
{
    public TraceGroups()
    {
        ScFields = new HashSet<ScFields>();
        TraceCodes = new HashSet<TraceCodes>();
    }

    public string Groupcode { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual ICollection<ScFields> ScFields { get; set; }
    public virtual ICollection<TraceCodes> TraceCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TraceGroups>(entity =>
        {
            entity.HasKey(e => e.Groupcode)
                .HasName("TG_PK");

            entity.ToTable("TRACE$GROUPS");

            entity.Property(e => e.Groupcode)
                .HasColumnName("GROUPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(ScFields)))
				entity.Ignore(e => e.ScFields);

			if (!types.Contains(typeof(TraceCodes)))
				entity.Ignore(e => e.TraceCodes);
		});
	}
}
