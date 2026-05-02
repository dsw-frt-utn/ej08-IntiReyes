using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        // Copia del valor (tipo por valor)
        int copia = originalValue;
        copia++;

        // Copia de la referencia (tipo por referencia)
        Product productoCopia = product;
        productoCopia.SetDescription("Descripcion modificada");

        return $"{originalValue}-{copia}-{product.Description}";
    }
}

