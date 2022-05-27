using System.ComponentModel.DataAnnotations;

namespace Concesionario.Data
{
    public class Cliente
    {

        [Key]
        public int numero { get; set; }
        public string nombre { get; set; }
        public string sueldo { get; set; }
        public int numeroCarros { get; set; }
        public string marcaPreferida { get; set; }
    }
}
