using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.Filter;
using ContainerTrackingApp.Models;

namespace ContainerTrackingApp.Repository
{
    
    public class RegisterCompanyConcrete : IRegisterCompany
    {
        DatabaseContext _context;
        ExceptionDetail exceptionDetail;
        ILogService _logService;
        public RegisterCompanyConcrete()
        {
            _logService = new RepositoryExceptionLog();
            exceptionDetail = new ExceptionDetail();
            _context = new DatabaseContext();
        }

        public IEnumerable<RegisterCompany> ListofCompanies(int UserID)
        {
            try
            {
                var CompanyList = (from companies in _context.RegisterCompany
                                   where companies.UserID == UserID
                                   select companies).ToList();
                return CompanyList;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public void Add(RegisterCompany entity)
        {
            try
            {
                _context.RegisterCompany.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public void Delete(RegisterCompany entity)
        {
            try
            {
                var itemToRemove = _context.RegisterCompany.SingleOrDefault(x => x.CompanyID == entity.CompanyID);
                _context.RegisterCompany.Remove(itemToRemove);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public RegisterCompany FindCompanyByUserId(int UserID)
        {
            try
            {
                var Company = _context.RegisterCompany.SingleOrDefault(x => x.UserID == UserID);
                return Company;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public RegisterCompany FindCompanyByCompanyId(int CompanyID)
        {
            try
            {
                var Company = _context.RegisterCompany.SingleOrDefault(x => x.CompanyID == CompanyID);
                return Company;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public RegisterCompany FindCompanyByUserId(int UserID, int CompanyID)
        {
            try
            {
                //var Company = _context.RegisterCompany. (x => x.UserID == UserID );
                var Company = (from comp in _context.RegisterCompany
                               where comp.UserID == UserID && comp.CompanyID == CompanyID
                               select comp).SingleOrDefault();
                return Company;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public bool ValidateCompanyName(RegisterCompany registercompany)
        {
            try
            {
                var result = (from company in _context.RegisterCompany
                              where company.Name == registercompany.Name &&
                                    company.EmailID == registercompany.EmailID
                              select company).Count();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public bool CheckIsCompanyRegistered(int UserID)
        {
            try
            {
                var companyExists = _context.RegisterCompany.Any(x => x.UserID == UserID);

                if (companyExists)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        
        public void Update(RegisterCompany entity)
        {
            try
            {
                var companyExists = _context.RegisterCompany.Any(x => x.UserID == entity.UserID && x.CompanyID == entity.CompanyID);

                if (companyExists)
                {
                    var Company = _context.RegisterCompany.SingleOrDefault(x => x.UserID == entity.UserID && x.CompanyID == entity.CompanyID);
                    Company.Name = entity.Name;
                    Company.Description = entity.Description;
                    Company.EmailID = entity.EmailID;
                    Company.CompanyID = entity.CompanyID;
                    Company.PersonInCharge = entity.PersonInCharge;
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
               _logService.AddException(ex);
                throw ex;
            }
        }
    }
}