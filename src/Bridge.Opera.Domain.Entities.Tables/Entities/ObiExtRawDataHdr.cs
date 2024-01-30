namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiExtRawDataHdr
{
    public decimal? ExtHdrId { get; set; }
    public string? DatamartName { get; set; }
    public string? RawDataName { get; set; }
    public decimal? ExpDataId { get; set; }
    public DateTime? SrcDate { get; set; }
    public decimal? TotalRows { get; set; }
    public string? Resort { get; set; }
    public string? SrcVer { get; set; }
    public string? SrcType { get; set; }
    public string? SrcJob { get; set; }
    public string? SrcScriptVer { get; set; }
    public decimal? SrcSeq { get; set; }
    public string? SrcFileName { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Status { get; set; }
    public string? Error { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiExtRawDataHdr>(entity =>
        {
            entity.HasKey(e => e.ExtHdrId)
                .HasName("OBI_EXT_RAW_DATA_HDR_PK");

            entity.ToTable("OBI_EXT_RAW_DATA_HDR");

            entity.HasIndex(e => e.ExpDataId)
                .HasName("OBI_EXT_RAW_DATA_HDR_IND1");

            entity.Property(e => e.ExtHdrId)
                .HasColumnName("EXT_HDR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DatamartName)
                .IsRequired()
                .HasColumnName("DATAMART_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Error)
                .HasColumnName("ERROR")
                .IsUnicode(false);

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RawDataName)
                .IsRequired()
                .HasColumnName("RAW_DATA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SrcDate)
                .HasColumnName("SRC_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SrcFileName)
                .HasColumnName("SRC_FILE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SrcJob)
                .HasColumnName("SRC_JOB")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SrcScriptVer)
                .HasColumnName("SRC_SCRIPT_VER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SrcSeq)
                .HasColumnName("SRC_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SrcType)
                .HasColumnName("SRC_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SrcVer)
                .HasColumnName("SRC_VER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TotalRows)
                .HasColumnName("TOTAL_ROWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
