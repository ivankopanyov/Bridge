namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvAccessChangeableFields
{
    public string AccessSourceType { get; set; }
    public string AccessSourceValue { get; set; }
    public string FormName { get; set; }
    public string StatusCode { get; set; }
    public string FieldName { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string Condition { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvAccessChangeableFields>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESV_ACCESS_CHANGEABLE_FIELDS");

            entity.HasIndex(e => new { e.AccessSourceType, e.AccessSourceValue, e.FormName, e.StatusCode, e.Condition, e.FieldName })
                .HasName("RESV_ACCESS_CHNG_FIELDS_IDX1")
                .IsUnique();

            entity.Property(e => e.AccessSourceType)
                .HasColumnName("ACCESS_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccessSourceValue)
                .HasColumnName("ACCESS_SOURCE_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Condition)
                .HasColumnName("CONDITION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
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
