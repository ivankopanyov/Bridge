namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomInspectionDetails
{
    public string Resort { get; set; }
    public decimal? WoGenerated { get; set; }
    public decimal? TaskCode { get; set; }
    public decimal RiTemplateId { get; set; }
    public decimal RiId { get; set; }
    public decimal RiQuestionId { get; set; }
    public string QuestionType { get; set; }
    public decimal? RiQuestionSeq { get; set; }
    public decimal? RiAnswerValue { get; set; }
    public string RiAnswerNote { get; set; }
    public decimal? RiPointsAchieved { get; set; }
    public decimal? RiQualityLevel { get; set; }

    public virtual SurveyTemplate R { get; set; }
    public virtual RiQualityLevels R1 { get; set; }
    public virtual RoomInspections RNavigation { get; set; }
    public virtual Tasks Tasks { get; set; }
    public virtual WorkOrders WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomInspectionDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RiId, e.RiQuestionId })
                .HasName("RID_PK");

            entity.ToTable("ROOM_INSPECTION_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.RiTemplateId })
                .HasName("RID_SURT_FKI");

            entity.HasIndex(e => new { e.Resort, e.TaskCode })
                .HasName("RID_TL_FK_IDX");

            entity.HasIndex(e => new { e.RiId, e.Resort })
                .HasName("RID_RI_FK_IDX");

            entity.HasIndex(e => new { e.RiQualityLevel, e.Resort })
                .HasName("RID_RQL_FK_IDX");

            entity.HasIndex(e => new { e.WoGenerated, e.Resort })
                .HasName("RID_WO_FK_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiId)
                .HasColumnName("RI_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiQuestionId)
                .HasColumnName("RI_QUESTION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QuestionType)
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiAnswerNote)
                .HasColumnName("RI_ANSWER_NOTE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiAnswerValue)
                .HasColumnName("RI_ANSWER_VALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiPointsAchieved)
                .HasColumnName("RI_POINTS_ACHIEVED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiQualityLevel)
                .HasColumnName("RI_QUALITY_LEVEL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiQuestionSeq)
                .HasColumnName("RI_QUESTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WoGenerated)
                .HasColumnName("WO_GENERATED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(SurveyTemplate)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RoomInspectionDetails)
	                .HasForeignKey(d => new { d.Resort, d.RiTemplateId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RID_SURT_FK");

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);
			else
	            entity.HasOne(d => d.Tasks)
	                .WithMany(p => p.RoomInspectionDetails)
	                .HasForeignKey(d => new { d.Resort, d.TaskCode })
	                .HasConstraintName("RID_TL_FK");

			if (!types.Contains(typeof(RoomInspections)))
				entity.Ignore(e => e.RNavigation);
			else
	            entity.HasOne(d => d.RNavigation)
	                .WithMany(p => p.RoomInspectionDetails)
	                .HasForeignKey(d => new { d.RiId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RID_RI_FK");

			if (!types.Contains(typeof(RiQualityLevels)))
				entity.Ignore(e => e.R1);
			else
	            entity.HasOne(d => d.R1)
	                .WithMany(p => p.RoomInspectionDetails)
	                .HasForeignKey(d => new { d.RiQualityLevel, d.Resort })
	                .HasConstraintName("RID_RQL_FK");

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
			else
	            entity.HasOne(d => d.WorkOrders)
	                .WithMany(p => p.RoomInspectionDetails)
	                .HasForeignKey(d => new { d.WoGenerated, d.Resort })
	                .HasConstraintName("RID_WO_FK");
        });
	}
}
