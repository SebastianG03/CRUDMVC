using CRUDMVC.Models;

namespace CRUDMVC.Util
{
    public class Utils
    {
        public static List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Producto",
                Descripcion = "Descripcion",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre = "Producto",
                Descripcion = "Descripcion",
                Cantidad = 1
            }
        };
    }
}
