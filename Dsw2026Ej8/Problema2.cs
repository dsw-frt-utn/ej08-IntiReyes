using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;

public class Problema2
{
    public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
    {
        decimal total = quantity <= 0 ? 0 : quantity * unitPrice;

        var venta = new
        {
            Code = productCode,
            Description = productDescription,
            Quantity = quantity,
            Total = total
        };

        return $"{venta.Code}-{venta.Description}-{venta.Total}";
    }
}
