using System.Collections.Generic;

namespace Net4Frm.Assembler
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
        IEnumerable<TDestination> MapGeneric<TSource, TDestination>(IEnumerable<TSource> source);
    }
}
