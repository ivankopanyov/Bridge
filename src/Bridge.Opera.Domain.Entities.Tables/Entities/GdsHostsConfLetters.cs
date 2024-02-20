namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsHostsConfLetters
{
    public string? GdsHost { get; set; }
    public string? LanguageCode { get; set; }
    public string? LetterType { get; set; }
    public string? ConfirmLetterName { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Resort { get; set; }
    public decimal? ModuleId { get; set; }

    public virtual GdsHosts GdsHostNavigation { get; set; }
    public virtual AppModules Module { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsHostsConfLetters>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.Resort, e.LanguageCode, e.LetterType })
                .HasName("GDS_HOSTS_CONF_LETTERS_PK");

            entity.ToTable("GDS_HOSTS_CONF_LETTERS");

            entity.HasIndex(e => e.ModuleId)
                .HasName("GDS_HOSTS_CL_MODULE_FKI");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LetterType)
                .HasColumnName("LETTER_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmLetterName)
                .IsRequired()
                .HasColumnName("CONFIRM_LETTER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsHosts)))
				entity.Ignore(e => e.GdsHostNavigation);
			else
	            entity.HasOne(d => d.GdsHostNavigation)
	                .WithMany(p => p.GdsHostsConfLetters)
	                .HasForeignKey(d => d.GdsHost)
	                .HasConstraintName("GDS_HOSTS_CONF_LETTERS_FK");

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.Module);
			else
	            entity.HasOne(d => d.Module)
	                .WithMany(p => p.GdsHostsConfLetters)
	                .HasForeignKey(d => d.ModuleId)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("GDS_HOSTS_CL_MODULE_FK");
        });
	}
}
