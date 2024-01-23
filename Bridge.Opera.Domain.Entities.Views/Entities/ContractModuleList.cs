namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ContractModuleList
{
    public decimal ModuleId { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDesc { get; set; }
    public string Destination { get; set; }
    public string LanguageCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ContractModuleList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONTRACT_MODULE_LIST");

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
