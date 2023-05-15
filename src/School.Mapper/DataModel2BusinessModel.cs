using AutoMapper;
using School.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Mapper
{
    public class DataModel2BusinessModel : Profile
    {
        public DataModel2BusinessModel()
        {
            CreateMap<DataModel.Student, Student>();
        }
    }
}
