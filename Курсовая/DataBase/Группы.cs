//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Курсовая.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Группы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Группы()
        {
            this.Учащиеся = new HashSet<Учащиеся>();
            this.Занятие = new HashSet<Занятие>();
        }
    
        public int ID_группы { get; set; }
        public Nullable<long> Курс { get; set; }
        public Nullable<int> Тип { get; set; }
        public string Номер_группы { get; set; }
        public string Код_факультета { get; set; }
        public string Код_специальности { get; set; }
        public Nullable<long> Год_поступления { get; set; }
    
        public virtual Факультет Факультет { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Учащиеся> Учащиеся { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Занятие> Занятие { get; set; }
    }
}
