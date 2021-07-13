namespace BerrySystem.Core.DTOs
{
    public  class ProductosDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? PrecioCosecha { get; set; }
        public int? PrecioVenta { get; set; }
        public int? PrecioCompra { get; set; }
    }
}
