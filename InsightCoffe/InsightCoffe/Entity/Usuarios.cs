using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightCoffe.Entity
{
    public class Usuarios
    {
        public int ID { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Acesso { get; set; }

        public override int GetHashCode()
        {
            return ID;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Usuarios objAsUsuarios = obj as Usuarios;
            if (objAsUsuarios == null) return false;
            else return Equals(objAsUsuarios);
        }

        public bool Equals(Usuarios other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
    }
}
