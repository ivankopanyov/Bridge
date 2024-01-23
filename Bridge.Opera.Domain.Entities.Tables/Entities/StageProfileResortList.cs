namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileResortList
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string ExtResortCode { get; set; }
    public string OperaResortCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileResortList>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_RESORT_LIST");

            entity.Property(e => e.ExtResortCode)
                .IsRequired()
                .HasColumnName("EXT_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OperaResortCode)
                .HasColumnName("OPERA_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
