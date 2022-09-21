using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;

namespace ContainerTrackingApp.Repository
{
    public class RegisterUserConcrete : IRegisterUser
    {
        DatabaseContext _context;
        ILogService _logService;
        public RegisterUserConcrete()
        {
            _logService = new RepositoryExceptionLog();
            _context = new DatabaseContext();
        }
        public void Add(RegisterUser registeruser)
        {
            try
            {
                _context.RegisterUser.Add(registeruser);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public int GetLoggedUserID(RegisterUser registeruser)
        {
            try
            {
                var usercount = (from User in _context.RegisterUser
                                 where User.UserName == registeruser.UserName &&
                                       User.Password == registeruser.Password
                                 select User.UserID).FirstOrDefault();

                return usercount;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public RegisterUser GetUser(int UserID)
        {
            try
            {
                RegisterUser UserInfo = (from User in _context.RegisterUser
                                         where User.UserID == UserID
                                         select User).FirstOrDefault();
                if (UserInfo != null)
                {
                    return UserInfo;
                }
                return null;
            }
            catch(Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public bool ValidateRegisteredUser(RegisterUser registeruser)
        {
            try
            {
                var usercount = (from User in _context.RegisterUser
                                 where User.UserName == registeruser.UserName &&
                                 User.Password == registeruser.Password
                                 select User).Count();
                if (usercount > 0)
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

        public bool ValidateUsername(RegisterUser registeruser)
        {
            try
            {
                var usercount = (from User in _context.RegisterUser
                                 where User.UserName == registeruser.UserName
                                 select User).Count();
                if (usercount > 0)
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
    }
}