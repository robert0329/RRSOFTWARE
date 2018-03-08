using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRSOFTWARE.Entidades
{
    public class User
    {
        public int UserId { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Disable { get; set; }
        public User()
        {
            
        }
        public User(int UserId, string Usuario, string Password, string Name, string Apellido)
        {
            this.UserId = UserId;
            this.Usuario = Usuario;
            this.Password = Password;
            this.Name = Name;
            this.Apellido = Apellido;
        }
    }
}
