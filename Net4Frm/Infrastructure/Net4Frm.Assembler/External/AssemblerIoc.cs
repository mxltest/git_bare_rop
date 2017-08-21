using Net4Frm.Assembler.Impl;

namespace Net4Frm.Assembler.External
{
    public class AssemblerIoc
    {
        private static IMapper mapper = null;

        public static IMapper GetMapper()
        {
            if (null == mapper)
            {
                mapper = new EmitMapperWrap();
            }
            return mapper;
        }
    }
}
