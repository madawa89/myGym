using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace GymProject.DataAccess
{
    public class BaseDataProvider
    {
        #region private varibles

        protected DbTransaction transaction;
        protected DbConnection connection;
        protected Database db;
        #endregion

        #region Methods
        /// <summary>
        /// Opens the connection.
        /// </summary>
        protected void OpenConnection()
        {
            db = DatabaseFactory.CreateDatabase("MyGym");
            connection = db.CreateConnection();
            connection.Open();
        }

        protected string GetConnectionString()
        {
            db = DatabaseFactory.CreateDatabase("MyGym");
            return db.ConnectionString;
        }
        #endregion
    }
}
