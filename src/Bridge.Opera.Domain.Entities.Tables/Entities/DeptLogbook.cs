namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DeptLogbook
{
    public decimal LogbookId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }
    public DateTime LogDate { get; set; }
    public string LogText { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual Department Department { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeptLogbook>(entity =>
        {
            entity.HasKey(e => e.LogbookId)
                .HasName("DLB_PK");

            entity.ToTable("DEPT_LOGBOOK");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("LOGBOOK_DEPT_IDX");

            entity.HasIndex(e => new { e.Resort, e.LogDate })
                .HasName("LOGBOOK_RESORT_IDX");

            entity.Property(e => e.LogbookId)
                .HasColumnName("LOGBOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogDate)
                .HasColumnName("LOG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LogText)
                .IsRequired()
                .HasColumnName("LOG_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);
			else
	            entity.HasOne(d => d.Department)
	                .WithMany(p => p.DeptLogbook)
	                .HasForeignKey(d => new { d.Resort, d.DeptId })
	                .HasConstraintName("DLB_DET_FK");
        });
	}
}
