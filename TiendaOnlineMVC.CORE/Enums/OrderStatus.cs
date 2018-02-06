namespace TiendaOnlineMVC.CORE.Enums
{
    /// <summary>
    /// enumerado de estados de pedido
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Pendiente
        /// </summary>
        Pending,
        /// <summary>
        /// Pagado
        /// </summary>
        Paid,
        /// <summary>
        /// Preparación
        /// </summary>
        InProcess,
        /// <summary>
        /// Enviado
        /// </summary>
        Sent,
        /// <summary>
        /// Finalizado
        /// </summary>
        End,
        /// <summary>
        /// Cancelado
        /// </summary>
        Canceled

    }
}