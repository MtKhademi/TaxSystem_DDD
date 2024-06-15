namespace TaxSystem.Entities;

public class TaxPayer
{
    public bool TaxCitizen { get; set; }

    public bool HasDisability { get; set; }

    public bool IsMuslim { get; set; }

    public decimal ZakatPaid { get; set; }

    public bool IsRetierd { get; set; }

    /// <summary>
    /// وضعیت تعهل
    /// </summary>
    public bool MartialStatus { get; set; }
}
