using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class OfficeComponentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название компонента")]
        public string ComponentName { get; set; }
    }

}
