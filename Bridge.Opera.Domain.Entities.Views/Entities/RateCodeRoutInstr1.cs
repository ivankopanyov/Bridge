namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateCodeRoutInstr1
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string TrxCode { get; set; }
    public string ProfileType { get; set; }
    public decimal? ArrangementId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateCodeRoutInstr1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_CODE_ROUT_INSTR");

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProfileType)
                .IsRequired()
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
