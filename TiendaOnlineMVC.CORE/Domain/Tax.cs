namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Clase de dominio de impuestos (IVA)
    /// </summary>
    public class Tax
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Porcentaje de impuesto
        /// </summary>
        public decimal Percent { get; set; }
    }
}