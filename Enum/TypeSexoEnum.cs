using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modulum.Shared.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeSexoEnum
    {
        [Display(Name = "Masculino")]
        Masculino,
        [Display(Name = "Feminino")]
        Feminino
    }
}
