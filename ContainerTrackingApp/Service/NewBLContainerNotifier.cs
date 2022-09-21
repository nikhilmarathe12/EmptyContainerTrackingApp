using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Service
{
    #region Delegate
    public delegate void ResultChangedEventHandler(object sender, SqlNotificationEventArgs e);
    #endregion

    public class NewBLContainerNotifier
    {
        #region Fields
        public event ResultChangedEventHandler NewBLnContainer;
        string _connString;
        string _selectQuery;
        #endregion

        internal NewBLContainerNotifier(string connString,string selectQuery)
        {
            _connString = connString;
            _selectQuery = selectQuery;
            RegisterForNotifications();
        }

        private void RegisterForNotifications()
        {
            using (var connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = new SqlCommand(_selectQuery, connection))
                {
                    command.Notification = null;
                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
                    if (connection.State == System.Data.ConnectionState.Closed)
                        connection.Open();
                    var reader = command.ExecuteReader();
                }
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (NewBLnContainer != null)
            {
                //subscribe again to notifier
                NewBLnContainer(sender, e);
                RegisterForNotifications();
            }
        }
    }
}