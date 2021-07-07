using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Telephone_directory.Manager
{
    class Search : IFindManager
    {
        public void MailGet(string Mail)
        {
            throw new NotImplementedException();
        }

        public void NameGet(string Name)
        {
            throw new NotImplementedException();
        }

        public void NumberGet(string Phone)
        {
            throw new NotImplementedException();
        }
    }

    class Repository : IRepository
    {
        public void GetTable()
        {
            using (var Connect=new Connection())
            {

            }
        }

        public void SetObj()
        {
            throw new NotImplementedException();
        }
    }

    class DBSize : IDBCounter
    {
        public int ColumnCnt()
        {
            throw new NotImplementedException();
        }

        public int RowCnt()
        {
            
        }
    }
}
