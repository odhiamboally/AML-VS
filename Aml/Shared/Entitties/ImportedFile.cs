using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

public partial class ImportedFile
{
    public ImportedFile()
    {
        Salaries = new HashSet<Salary>();  // Updated to PascalCase
    }

    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal ImportedFileId { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(100)]
    public string? ImportedFileName { get; set; }  // Updated to PascalCase

    [Required]
    public string? FullPath { get; set; }  // Updated to PascalCase

    public decimal FileSize { get; set; }  // Updated to PascalCase

    public int? BatchTypeId { get; set; }  // Updated to PascalCase

    public DateTime ImportDate { get; set; }  // Updated to PascalCase

    public int UserId { get; set; }  // Updated to PascalCase

    public int NoOfRecords { get; set; }  // Updated to PascalCase

    public decimal TotalAmount { get; set; }  // Updated to PascalCase

    public int NoOfRejects { get; set; }  // Updated to PascalCase

    public decimal RejectAmount { get; set; }  // Updated to PascalCase

    [Column(TypeName = "numeric")]
    public decimal? BatchNo { get; set; }  // Updated to PascalCase

    // Navigation property with PascalCase
    public virtual ICollection<Salary> Salaries { get; set; }  // Updated to PascalCase
}

