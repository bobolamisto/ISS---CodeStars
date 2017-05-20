using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOModels;

namespace Server.ServicesImplementation
{
    public class EnumGetDataService
    {
        public List<EnumObject> getData<E>()
        {
            List<EnumObject> list = new List<EnumObject>();
            foreach (var item in Enum.GetNames(typeof(E)))
            {
                string value = item;
                int id = (int)Enum.Parse(typeof(E), item);
                list.Add(new EnumObject(id, value));
            }
            return list;
        }
    }
}
