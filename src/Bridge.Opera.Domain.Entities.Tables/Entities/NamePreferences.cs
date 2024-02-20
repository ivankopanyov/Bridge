namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NamePreferences
{
    public string? PreferenceType { get; set; }
    public string? PreferenceValue { get; set; }
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public string? ChargeYn { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Mpcode { get; set; }
    public string? ExternalPreferenceId { get; set; }

    public virtual Name Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NamePreferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NAME$PREFERENCES");

            entity.HasIndex(e => e.ExternalPreferenceId)
                .HasName("NAME_PREFERENCES_EXT_ID_IDX");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("NAME_PREFERENCES_IDX2");

            entity.HasIndex(e => new { e.NameId, e.PreferenceType, e.PreferenceValue, e.Resort })
                .HasName("NAME$PREFERENCES_UK")
                .IsUnique();

            entity.Property(e => e.ChargeYn)
                .HasColumnName("CHARGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExternalPreferenceId)
                .HasColumnName("EXTERNAL_PREFERENCE_ID")
                .HasMaxLength(20)
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

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceValue)
                .IsRequired()
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany()
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NAME_PREFERENCES_NAME_FK");
        });
	}
}
