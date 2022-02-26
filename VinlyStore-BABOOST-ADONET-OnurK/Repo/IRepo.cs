using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Repo
{
    public interface IRepo<T>
    {
        List<T> Get();
        T GetById(int id);

        int Create(T item);
        int Update(T item);
        int Delete(int id);
    }
}
