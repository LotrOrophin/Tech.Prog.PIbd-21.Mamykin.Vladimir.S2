using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.BindingModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class OfficeComponentBindingModel
    {
        public int? Id { get; set; }
        public string ComponentName { get; set; }
    }
}
