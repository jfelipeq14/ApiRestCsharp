﻿using System;
using System.Collections.Generic;

namespace ApiRest.Models;

public partial class Privilegio
{
    public int IdPrivilegio { get; set; }

    public string NombrePrivilegio { get; set; } = null!;

    public int IdPermiso { get; set; }

    public virtual Permiso IdPermisoNavigation { get; set; } = null!;

    public virtual ICollection<RolPrivilegio> RolPrivilegios { get; set; } = new List<RolPrivilegio>();
}
