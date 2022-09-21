using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Repository
{
    public interface IRegisterCompany
    {
        IEnumerable<RegisterCompany> ListofCompanies(int UserID);
        void Add(RegisterCompany entity);
        void Delete(RegisterCompany entity);
        void Update(RegisterCompany entity);
        RegisterCompany FindCompanyByUserId(int UserID);
        RegisterCompany FindCompanyByCompanyId(int CompanyID);
        RegisterCompany FindCompanyByUserId(int UserID,int CompanyID);
        bool ValidateCompanyName(RegisterCompany registercompany);
        bool CheckIsCompanyRegistered(int UserID);
    }
}