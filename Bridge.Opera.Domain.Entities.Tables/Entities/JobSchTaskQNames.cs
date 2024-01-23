namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchTaskQNames
{
    public string QCode { get; set; }
    public string QName { get; set; }
    public string QType { get; set; }
    public string QDescription { get; set; }
    public string CanDeleteYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchTaskQNames>(entity =>
        {
            entity.HasKey(e => e.QCode)
                .HasName("JOB_SCH_Q_NAM_PK");

            entity.ToTable("JOB_SCH_TASK_Q_NAMES");

            entity.Property(e => e.QCode)
                .HasColumnName("Q_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QDescription)
                .HasColumnName("Q_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.QName)
                .HasColumnName("Q_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.QType)
                .HasColumnName("Q_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
