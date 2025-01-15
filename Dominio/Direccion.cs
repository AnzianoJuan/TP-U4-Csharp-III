using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
    }

    public class DireccionNegocio
    {
        public List<Direccion> listar()
        {

            List<Direccion> listaDeDirecciones = new List<Direccion>();

            listaDeDirecciones.Add(new Direccion());
            listaDeDirecciones.Add(new Direccion());

            listaDeDirecciones[0].Id = 1;
            listaDeDirecciones[0].Calle = "Colon y bs as";
            listaDeDirecciones[0].Altura = 589;

            listaDeDirecciones[1].Id = 2;
            listaDeDirecciones[1].Calle = "Leloir 653";
            listaDeDirecciones[1].Altura = 653;

            return listaDeDirecciones;

        }

    }
}
