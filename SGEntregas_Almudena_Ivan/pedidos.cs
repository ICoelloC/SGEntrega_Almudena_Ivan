//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGEntregas_Almudena_Ivan
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidos
    {
        public int id_pedido { get; set; }
        public string cliente { get; set; }
        public System.DateTime fecha_pedido { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
        public byte[] firma { get; set; }
    
        public virtual clientes clientes { get; set; }
    }
}
