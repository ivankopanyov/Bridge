namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BmAccountsVw
{
    public decimal NameId { get; set; }
    public string AccountCode { get; set; }
    public string TemplateAccount { get; set; }
    public string AccountType { get; set; }
    public string Note { get; set; }
    public string Currency { get; set; }
    public string ChainCode { get; set; }
    public string ExportFormat { get; set; }
    public string Name { get; set; }
    public string Sname { get; set; }
    public string AcctContact { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Address1b { get; set; }
    public string Address2b { get; set; }
    public string Address3b { get; set; }
    public string Countryb { get; set; }
    public string Stateb { get; set; }
    public string Cityb { get; set; }
    public string ZipCodeb { get; set; }
    public string PhoneNo { get; set; }
    public string FaxNo { get; set; }
    public string Resorts { get; set; }
    public string ArNo { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string Sxname { get; set; }
    public string NoResorts { get; set; }
    public string NoRooms { get; set; }
    public string Instances { get; set; }
    public DateTime? RebateDate { get; set; }
    public DateTime? ContractEnd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmAccountsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BM_ACCOUNTS_VW");

            entity.Property(e => e.AccountCode)
                .IsRequired()
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address1b)
                .HasColumnName("ADDRESS1B")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address2b)
                .HasColumnName("ADDRESS2B")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address3b)
                .HasColumnName("ADDRESS3B")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cityb)
                .HasColumnName("CITYB")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractEnd)
                .HasColumnName("CONTRACT_END")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Countryb)
                .HasColumnName("COUNTRYB")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportFormat)
                .HasColumnName("EXPORT_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Instances)
                .HasColumnName("INSTANCES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoResorts)
                .HasColumnName("NO_RESORTS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RebateDate)
                .HasColumnName("REBATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resorts)
                .HasColumnName("RESORTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Stateb)
                .HasColumnName("STATEB")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TemplateAccount)
                .HasColumnName("TEMPLATE_ACCOUNT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ZipCodeb)
                .HasColumnName("ZIP_CODEB")
                .HasMaxLength(15)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
