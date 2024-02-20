namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmpAvail
{
    public decimal? AvailId { get; set; }
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? Starttime { get; set; }
    public DateTime? Endtime { get; set; }
    public decimal? TemplateId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ScheduleTemplates ScheduleTemplates { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmpAvail>(entity =>
        {
            entity.HasKey(e => new { e.AvailId, e.Resort })
                .HasName("EA_PK");

            entity.ToTable("EMP_AVAIL");

            entity.HasIndex(e => new { e.TemplateId, e.Resort })
                .HasName("EA_ST_FK_I");

            entity.Property(e => e.AvailId)
                .HasColumnName("AVAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Endtime)
                .HasColumnName("ENDTIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Starttime)
                .HasColumnName("STARTTIME")
                .HasColumnType("DATE");

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ScheduleTemplates)))
				entity.Ignore(e => e.ScheduleTemplates);
			else
	            entity.HasOne(d => d.ScheduleTemplates)
	                .WithMany(p => p.EmpAvail)
	                .HasForeignKey(d => new { d.TemplateId, d.Resort })
	                .HasConstraintName("EA_ST_FK");
        });
	}
}
