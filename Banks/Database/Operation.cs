//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banks.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation
    {
        public Nullable<int> card_id { get; set; }
        public Nullable<int> id_terminal { get; set; }
        public int id_operation { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }
        public Nullable<bool> comission { get; set; }
        public int sum { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Terminals Terminals { get; set; }
    }
}