using System;
using VentaData;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaService.Login
{
    public class LoginService : ILoginService
    {
        shoppingwebEntities db = new shoppingwebEntities();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<sp_login_Result> Validar_InicioSesion(string Correo, string Contrasenia)
        {
            int flag = 0;
            List<sp_login_Result> listLog = new List<sp_login_Result>();
            listLog = db.sp_login(Correo, Contrasenia).ToList<sp_login_Result>();
            flag = listLog.Count();

            return listLog;
        }
    }
}
