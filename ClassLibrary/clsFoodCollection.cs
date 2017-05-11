using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ClassLibrary
{
    public class clsFoodCollection
    {

        //global variable MyDatabase
        clsDataConnection MyDatabase = new clsDataConnection();

        // constructor
        public clsFoodCollection()
        {
        }
    }
}
