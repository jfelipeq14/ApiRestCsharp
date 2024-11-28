using System;
using System.Collections.Generic;

namespace ApiRest.Models;

public partial class DetalleReservaViajero
{
    public int IdDetalleReservaViajero { get; set; }

    public int IdReserva { get; set; }

    public int IdCliente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Reserva IdReservaNavigation { get; set; } = null!;
}
