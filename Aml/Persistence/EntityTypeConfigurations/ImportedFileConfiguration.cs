using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ImportedFileConfiguration : IEntityTypeConfiguration<ImportedFile>
{
    public void Configure(EntityTypeBuilder<ImportedFile> builder)
    {
        builder.ToTable("IMPORTED_FILE");  // Map to table

        builder.HasKey(i => i.ImportedFileId) ;  // Primary key configuration

        builder.Property(i => i.ImportedFileId)
            .ValueGeneratedOnAdd();  // Identity column for ImportedFileId

        builder.Property(i => i.ImportedFileName)
            .IsRequired()
            .HasMaxLength(100);  // ImportedFileName is required and has a max length of 100

        builder.Property(i => i.FullPath)
            .IsRequired();  // FullPath is required

        builder.Property(i => i.FileSize)
            .IsRequired();  // FileSize is required

        builder.Property(i => i.BatchTypeId) ;  // BatchTypeId is nullable

        builder.Property(i => i.ImportDate)
            .IsRequired();  // ImportDate is required

        builder.Property(i => i.UserId)
            .IsRequired();  // UserId is required

        builder.Property(i => i.NoOfRecords)
            .IsRequired();  // NoOfRecords is required

        builder.Property(i => i.TotalAmount)
            .IsRequired();  // TotalAmount is required

        builder.Property(i => i.NoOfRejects)
            .IsRequired();  // NoOfRejects is required

        builder.Property(i => i.RejectAmount)
            .IsRequired();  // RejectAmount is required

        builder.Property(i => i.BatchNo) ;  // BatchNo is nullable

        // Configuring the relationship with Salary
        builder.HasMany(i => i.Salaries)
            .WithOne()  // Assuming one-to-many relationship with Salary
            .HasForeignKey(s => s.ImportedFileId);  // Foreign key to ImportedFile
    }
}
