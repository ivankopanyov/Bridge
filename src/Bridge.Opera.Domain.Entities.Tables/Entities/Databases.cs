namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Databases
{
    public Databases()
    {
        DatabaseResorts = new HashSet<DatabaseResorts>();
    }

    public string DatabaseId { get; set; }
    public string DatabaseName { get; set; }
    public string DatabaseType { get; set; }
    public string InterfaceType { get; set; }
    public string DbConnectString { get; set; }
    public string PmsInstalledYn { get; set; }
    public string ScInstalledYn { get; set; }
    public string CrsInstalledYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string SfaInstalledYn { get; set; }
    public string PmsType { get; set; }
    public string Appservername { get; set; }
    public string Jndiname { get; set; }
    public string Operausername { get; set; }
    public string Operauserpassword { get; set; }
    public string Operaapplication { get; set; }
    public string Operacro { get; set; }
    public string Operalanguage { get; set; }
    public string Operaextsystem { get; set; }
    public string Operasecuritytoken { get; set; }
    public string Operasecurityws { get; set; }
    public string EmailAddress { get; set; }
    public string EmailSubject { get; set; }
    public string EmailText { get; set; }
    public decimal? EmailFrequency { get; set; }

    public virtual ICollection<DatabaseResorts> DatabaseResorts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Databases>(entity =>
        {
            entity.HasKey(e => e.DatabaseId)
                .HasName("DATABASES_PK");

            entity.ToTable("DATABASES");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Appservername)
                .HasColumnName("APPSERVERNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CrsInstalledYn)
                .HasColumnName("CRS_INSTALLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DatabaseName)
                .HasColumnName("DATABASE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DatabaseType)
                .HasColumnName("DATABASE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DbConnectString)
                .HasColumnName("DB_CONNECT_STRING")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EmailFrequency)
                .HasColumnName("EMAIL_FREQUENCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailSubject)
                .HasColumnName("EMAIL_SUBJECT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EmailText)
                .HasColumnName("EMAIL_TEXT")
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

            entity.Property(e => e.InterfaceType)
                .HasColumnName("INTERFACE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Jndiname)
                .HasColumnName("JNDINAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Operaapplication)
                .HasColumnName("OPERAAPPLICATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Operacro)
                .HasColumnName("OPERACRO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Operaextsystem)
                .HasColumnName("OPERAEXTSYSTEM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Operalanguage)
                .HasColumnName("OPERALANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Operasecuritytoken)
                .HasColumnName("OPERASECURITYTOKEN")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Operasecurityws)
                .HasColumnName("OPERASECURITYWS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Operausername)
                .HasColumnName("OPERAUSERNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Operauserpassword)
                .HasColumnName("OPERAUSERPASSWORD")
                .IsUnicode(false);

            entity.Property(e => e.PmsInstalledYn)
                .HasColumnName("PMS_INSTALLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PmsType)
                .HasColumnName("PMS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScInstalledYn)
                .HasColumnName("SC_INSTALLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SfaInstalledYn)
                .HasColumnName("SFA_INSTALLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(DatabaseResorts)))
				entity.Ignore(e => e.DatabaseResorts);
		});
	}
}
