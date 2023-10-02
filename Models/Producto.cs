namespace CRUDMVC.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set;}
        public int Cantidad { get; set;}

        List<Producto> GenerarProductosAleatorios(int cantidad)
        {
            Random random = new Random();
            List<Producto> productos = new List<Producto>();

            for (int i = 1; i <= cantidad; i++)
            {
                Producto producto = new Producto
                {
                    IdProducto = i,
                    Nombre = "Producto" + i,
                    Descripcion = "Descripción del Producto " + i,
                    Cantidad = random.Next(1, 101) // Cantidad aleatoria entre 1 y 100
                };

                productos.Add(producto);
            }

            return productos;
        }
        
    }
}
