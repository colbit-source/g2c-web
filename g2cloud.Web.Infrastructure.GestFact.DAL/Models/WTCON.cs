using System;
using System.Collections.Generic;

namespace g2cloud.Web.Infrastructure.GestFact.DAL;

public partial class WTCON
{
    public string COD_WTC { get; set; } = null!;

    public string WTC_NOM { get; set; } = null!;

    public string WTC_CLA { get; set; } = null!;

    public string WTC_EST { get; set; } = null!;

    public string? WTC_TAG { get; set; }

    public DateTime? WTC_FUE { get; set; }

    public string WTC_REG { get; set; } = null!;

    public string WTC_LCK { get; set; } = null!;

    public DateTime? WTC_UPD { get; set; }

    public DateTime WTC_FAL { get; set; }
}
