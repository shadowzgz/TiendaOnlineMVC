using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Enums;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Entidad de dominio de pedido
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Linea de pedido
        /// </summary>
        public List<OrderLine> OrderLines { get; set; }

        /// <summary>
        /// Estado del pedido
        /// </summary>
        public OrderStatus Status { get; set; }

        #region Fechas
        /// <summary>
        /// Fecha de creación
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Fecha de pago
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Fecha de envío
        /// </summary>
        public DateTime? SentDate { get; set; }

        /// <summary>
        /// Fecha de entrega
        /// </summary>
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Fecha de cancelación
        /// </summary>
        public DateTime? CancellationDate { get; set; }
        #endregion

        #region Relacion con el usuario
        /// <summary>
        /// Identificador de usuario
        /// </summary>
        [ForeignKey("User")]
        public string UserId { get; set; }

        /// <summary>
        /// Objeto de usuario
        /// </summary>
        public ApplicationUser User { get; set; }
        #endregion

        #region Dirección de envío
        /// <summary>
        /// Identificador d la dirección de envío
        /// </summary>
        [ForeignKey("DeliveryAddress")]
        public int DeliveryAddressId { get; set; }

        /// <summary>
        /// Objeto de la dirección de envío
        /// </summary>
        public Address DeliveryAddress { get; set; }
        #endregion

        #region Dirección de facturación
        /// <summary>
        /// Identificador d la dirección de envío
        /// </summary>
        [ForeignKey("BillingAddress")]
        public int BillingAddressId { get; set; }

        /// <summary>
        /// Objeto de la dirección de envío
        /// </summary>
        public Address BillingAddress { get; set; }
        #endregion

        /// <summary>
        /// Método de pago
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Método de envío
        /// </summary>
        public string SendMethod { get; set; }
    }
}
