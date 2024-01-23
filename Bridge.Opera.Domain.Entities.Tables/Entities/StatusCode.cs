namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StatusCode
{
    public StatusCode()
    {
        Reasons = new HashSet<Reasons>();
        Tasks = new HashSet<Tasks>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string Resort { get; set; }
    public string StatusCode1 { get; set; }
    public string Description { get; set; }
    public string LanguageCode { get; set; }
    public decimal? PpStatusCode { get; set; }
    public string UsedInApp { get; set; }

    public virtual ICollection<Reasons> Reasons { get; set; }
    public virtual ICollection<Tasks> Tasks { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StatusCode>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.StatusCode1 })
                .HasName("SC_PK");

            entity.ToTable("STATUS$CODE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode1)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PpStatusCode)
                .HasColumnName("PP_STATUS_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(Reasons)))
				entity.Ignore(e => e.Reasons);

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
