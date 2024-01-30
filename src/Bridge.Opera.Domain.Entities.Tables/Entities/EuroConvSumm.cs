namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EuroConvSumm
{
    public string? TableName { get; set; }
    public decimal? MaxRecords { get; set; }
    public string? ProcedureName { get; set; }
    public decimal? JobNo { get; set; }
    public string? Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EuroConvSumm>(entity =>
        {
            entity.HasKey(e => e.TableName)
                .HasName("ECS_PK");

            entity.ToTable("EURO_CONV_SUMM");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobNo)
                .HasColumnName("JOB_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRecords)
                .HasColumnName("MAX_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .IsUnicode(false);
        });
	}
}
