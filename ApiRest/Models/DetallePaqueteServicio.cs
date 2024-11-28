using System;
using System.Collections.Generic;

namespace ApiRest.Models;

public partial class DetallePaqueteServicio
{
    public int IdDetallePaqueteServicio { get; set; }

    public int IdPaquete { get; set; }

    public int IdServicio { get; set; }

    public int CantidadServicioPaquete { get; set; }

    public decimal? ValorServicioPaquete { get; set; }

    public virtual Paquete IdPaqueteNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
