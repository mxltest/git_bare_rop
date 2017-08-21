using Net4Frm.Model;

namespace Net4Frm.IRepository
{
    public interface IUnitOfWorkRepository
    {
        string PersistNewItem(params  ModelBase[] item);
        string PersistUpdatedItem(params ModelBase[] items);
    }
}
