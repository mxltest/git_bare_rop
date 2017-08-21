using System.Collections.Generic;
using EmitMapper;

namespace Net4Frm.Assembler.Impl
{
    public class EmitMapperWrap : IMapper
    {



        public TDestination Map<TSource, TDestination>(TSource source)
        {
            var mapper = ObjectMapperManager.DefaultInstance.GetMapper<TSource, TDestination>();
            var res = mapper.Map(source);
            return res;


        }

        public IEnumerable<TDestination> MapGeneric<TSource, TDestination>(IEnumerable<TSource> source)
        {
            IList<TDestination> list = new List<TDestination>();
            foreach (TSource item in source)
            {
                list.Add(Map<TSource, TDestination>(item));
            }
            return list;
        }
    }
}
