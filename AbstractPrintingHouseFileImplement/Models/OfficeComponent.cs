using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseFileImplement.Models
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class OfficeComponent
    {
        public int Id { get; set; }
        public string ComponentName { get; set; }
    }
}
