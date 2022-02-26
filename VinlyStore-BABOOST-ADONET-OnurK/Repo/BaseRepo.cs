using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Repo
{
    public abstract class BaseRepo
    {
        SqlConnection connection = null;
        public BaseRepo()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbVinly"].ConnectionString);
        }
        public SqlConnection Connection
        {
            get { return connection; }
        }
    }
}
