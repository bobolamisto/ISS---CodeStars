using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.Services
{
    public interface IModelConverterService<POCO,DTO>
    {
        DTO convertToDTOModel(POCO model);
        POCO convertToPOCOModel(DTO model);
        IEnumerable<DTO> convertToDTOList(IEnumerable<POCO> models);
    }
}
