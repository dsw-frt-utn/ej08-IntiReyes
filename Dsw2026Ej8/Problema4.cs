using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;

public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        var notas = new[] { nota1, nota2, nota3 };

        double suma = 0;
        int cantidad = 0;

        foreach (var nota in notas)
        {
            if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
            {
                suma += nota.Value;
                cantidad++;
            }
        }

        if (cantidad == 0) return 0;

        return suma / cantidad;
    }
}
