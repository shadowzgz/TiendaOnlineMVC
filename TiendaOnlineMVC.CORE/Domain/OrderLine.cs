namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// entidad de dominio de líneas de pedido
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        #region Datos del producto

        /// <summary>
        /// Identificador del producto
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Precio del producto
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Nombre del impuesto aplicado
        /// </summary>
        public string TaxName { get; set; }

        /// <summary>
        /// Valor del impuesto aplicado
        /// </summary>
        public decimal TaxValue { get; set; }

        /// <summary>
        /// Precio total
        /// </summary>
        public decimal TotalPrice { get; set; }

        #endregion

        /// <summary>
        /// Cantidad de producto
        /// </summary>
        public decimal Quantity { get; set; }




    }
}