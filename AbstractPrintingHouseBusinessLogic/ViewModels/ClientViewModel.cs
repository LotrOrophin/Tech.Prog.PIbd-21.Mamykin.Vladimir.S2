using AbstractPrintingHouseBusinessLogic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel : BaseViewModel
    {
        [Column(title: "ФИО клиента", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string FIO { get; set; }
        [DataMember]
        [Column(title: "Почта", width: 150)]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "FIO",
            "Email"
        };

    }
}
