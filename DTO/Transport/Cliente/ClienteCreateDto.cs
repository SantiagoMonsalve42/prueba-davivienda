namespace DTO.Transport.Cliente
{
    public class ClienteCreateDto
    {
        public decimal? Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
