using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("TRANTYPE")]
public partial class TranType
{
    public TranType()
    {
        AchFileStatuses = new HashSet<AchFileStatus>();
        ClearingCodes = new HashSet<ClearingCode>();
        Vouchers = new HashSet<Voucher>();
    }

    public int TranTypeId { get; set; }

    [Required]
    [StringLength(5)]
    public string? TranTypeCode { get; set; }

    [Required]
    public string? TranTypeDesc { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AchFileStatus> AchFileStatuses { get; set; }

    public virtual ICollection<ClearingCode> ClearingCodes { get; set; }

    public virtual Status? Status { get; set; }

    public virtual ICollection<Voucher> Vouchers { get; set; }
}

