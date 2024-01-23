namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsRequestParameter
{
    public decimal ReqId { get; set; }
    public string Par { get; set; }
    public string ParValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsRequestParameter>(entity =>
        {
            entity.HasKey(e => new { e.ReqId, e.Par })
                .HasName("FS_REQUEST_PARAMETER_PK");

            entity.ToTable("FS_REQUEST_PARAMETER");

            entity.Property(e => e.ReqId)
                .HasColumnName("REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Par)
                .HasColumnName("PAR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParValue)
                .IsRequired()
                .HasColumnName("PAR_VALUE")
                .IsUnicode(false);
        });
	}
}
