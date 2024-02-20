namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidExtSystemsSys
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal? SeqNo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? PmsType { get; set; }
    public string? LookupYn { get; set; }
    public string? SystemType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidExtSystemsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_EXT_SYSTEMS_SYS");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LookupYn)
                .IsRequired()
                .HasColumnName("LOOKUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PmsType)
                .HasColumnName("PMS_TYPE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
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
