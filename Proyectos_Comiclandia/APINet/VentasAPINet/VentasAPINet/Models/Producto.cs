using System.ComponentModel.DataAnnotations;

namespace VentasAPINet.Models
{
    public class Producto
    {
        [Key]
        public string cod_producto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string estado { get; set; }
    }
}
