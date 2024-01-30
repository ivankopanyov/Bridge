namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileMergeRules
{
    public string? Region { get; set; }
    public string? NameType { get; set; }
    public string? ValidationItem { get; set; }
    public string? ValidationType { get; set; }
    public string? ValidationValue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ApplyRuleYn { get; set; }
    public string? UserMaintainable { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileMergeRules>(entity =>
        {
            entity.HasKey(e => new { e.Region, e.NameType, e.ValidationItem })
                .HasName("PROFILE_MERGE_RULES_PK");

            entity.ToTable("PROFILE_MERGE_RULES");

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidationItem)
                .HasColumnName("VALIDATION_ITEM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ApplyRuleYn)
                .HasColumnName("APPLY_RULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserMaintainable)
                .HasColumnName("USER_MAINTAINABLE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ValidationType)
                .HasColumnName("VALIDATION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ValidationValue)
                .HasColumnName("VALIDATION_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
