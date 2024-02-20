namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbPreferences
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbPreferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_PREFERENCES");

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
                .HasColumnType("NUMBER");

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
        });
	}
}
