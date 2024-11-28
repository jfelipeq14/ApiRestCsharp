using System;
using System.Collections.Generic;

namespace ApiRest.Models;

public partial class RolPrivilegio
{
    public int IdRolPrivilegio { get; set; }

    public int IdRol { get; set; }

    public int IdPrivilegio { get; set; }

    public virtual Privilegio IdPrivilegioNavigation { get; set; } = null!;

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
