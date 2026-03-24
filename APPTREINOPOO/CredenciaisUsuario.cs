using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace APPTREINOPOO
{
    public class CredenciaisUsuario
    {
        public string usuario { get; set; }
        public string setor { get; set; }
        public string senha { get; set; }

        public CredenciaisUsuario(string NomeUsuario, string SetorUsuario, string SenhaUsuario) { 

            usuario = NomeUsuario;
            setor = SetorUsuario;
            senha = SenhaUsuario;

        }


        public bool VerificarCredenciais()
        {

            return usuario == "Priscila" && setor == "Administrador" && senha == "0000";
        }

        
        
        
    }
}
