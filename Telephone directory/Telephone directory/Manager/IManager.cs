using System;
using System.Collections.Generic;
using System.Text;

namespace Telephone_directory.Manager
{
    interface IFindManager
    {
        void NameGet(string Name);
        void MailGet(string Mail);
        void NumberGet(string Phone);
    }
    interface IRepository 
    {
        void GetTable();
        void SetObj();

    }

}
