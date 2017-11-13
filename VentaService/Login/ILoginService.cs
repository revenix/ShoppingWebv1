using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaData;

namespace VentaService.Login
{
    interface ILoginService : IDisposable
    {
        List<sp_login_Result> Validar_InicioSesion(string Correo, string Contrasenia);
    }
}
