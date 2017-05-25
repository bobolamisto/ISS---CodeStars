using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOModels
{[Serializable]
    public class EnumObject
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public EnumObject(int id,string value)
        {
            Id = id;
            Value = value;
        }
        public EnumObject() { }
    }
}
