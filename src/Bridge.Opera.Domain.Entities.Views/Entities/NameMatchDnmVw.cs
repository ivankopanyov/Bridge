namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameMatchDnmVw
{
    public string? RuleType { get; set; }
    public string? RuleCode { get; set; }
    public string? NameType { get; set; }
    public string? KeyValues { get; set; }
    public string? RuleValues { get; set; }
    public string? CanDeleteYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameMatchDnmVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_MATCH_DNM_VW");

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

            entity.Property(e => e.KeyValues)
                .HasColumnName("KEY_VALUES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .IsRequired()
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleType)
                .IsRequired()
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleValues)
                .HasColumnName("RULE_VALUES")
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
