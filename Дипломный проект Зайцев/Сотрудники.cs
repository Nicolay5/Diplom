//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Дипломный_проект_Зайцев
{
    using System;
    using System.Collections.Generic;
    
    public partial class Сотрудники
    {
        public int ид_сотрудника { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public int ид_должности { get; set; }
        public Nullable<bool> Администратор { get; set; }
    
        public virtual Должность_сотрудника Должность_сотрудника { get; set; }
    }
}
