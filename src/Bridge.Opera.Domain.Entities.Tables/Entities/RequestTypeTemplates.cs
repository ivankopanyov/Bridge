namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RequestTypeTemplates
{
    public RequestTypeTemplates()
    {
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string? Resort { get; set; }
    public string? RequestId { get; set; }
    public decimal? TemplateId { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? Id { get; set; }

    public virtual ResortActivityTypes Re { get; set; }
    public virtual ScAttachment Template { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RequestTypeTemplates>(entity =>
        {
            entity.ToTable("REQUEST_TYPE_TEMPLATES");

            entity.HasIndex(e => e.TemplateId)
                .HasName("RTT_ATTACHMENT_FKI");

            entity.HasIndex(e => new { e.RequestId, e.Resort })
                .HasName("RTT_ACTIVITY_FKI");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .IsRequired()
                .HasColumnName("REQUEST_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ScAttachment)))
				entity.Ignore(e => e.Template);
			else
	            entity.HasOne(d => d.Template)
	                .WithMany(p => p.RequestTypeTemplates)
	                .HasForeignKey(d => d.TemplateId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RTT_ATTACHMENT_FK");

			if (!types.Contains(typeof(ResortActivityTypes)))
				entity.Ignore(e => e.Re);
			else
	            entity.HasOne(d => d.Re)
	                .WithMany(p => p.RequestTypeTemplates)
	                .HasForeignKey(d => new { d.RequestId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RTT_ACTIVITY_FK");
        
			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
