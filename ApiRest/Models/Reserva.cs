using System;
using System.Collections.Generic;

namespace ApiRest.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int IdProgramacion { get; set; }

    public int IdCliente { get; set; }

    public DateOnly? FechaReserva { get; set; }

    public decimal ValorReserva { get; set; }

    public string EstadoReserva { get; set; } = null!;

    public virtual ICollection<DetalleReservaViajero> DetalleReservaViajeros { get; set; } = new List<DetalleReservaViajero>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Programacion IdProgramacionNavigation { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
