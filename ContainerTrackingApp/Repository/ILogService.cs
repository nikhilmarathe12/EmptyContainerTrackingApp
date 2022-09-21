using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTrackingApp.Repository
{
    interface ILogService
    {

        List<ExceptionDetail> GetExceptionDetails();
        void AddException(Exception exception);
    }
}
