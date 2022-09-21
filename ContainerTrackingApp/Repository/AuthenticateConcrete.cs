using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContainerTrackingApp.AES256;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;

namespace ContainerTrackingApp.Repository
{
    public class AuthenticateConcrete : IAuthenticate
    {
        DatabaseContext _context;
        AES256Encryption EncryptionLibrary;
        ILogService _logService;
        public AuthenticateConcrete()
        {
            _logService = new RepositoryExceptionLog();
            _context = new DatabaseContext();
            EncryptionLibrary = new AES256Encryption();
        }

        public int DeleteGenerateToken(int CompanyID)
        {
            try
            {
                var token = _context.TokensManager.SingleOrDefault(x => x.CompanyID == CompanyID);
                _context.TokensManager.Remove(token);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public string GenerateToken(ClientKey ClientKeys, DateTime IssuedOn)
        {
            try
            {
                string randomnumber =
                   string.Join(":", new string[]
                   {
                       Convert.ToString(ClientKeys.UserID),
                       KeyGenerator.GetUniqueKey(),
                       Convert.ToString(ClientKeys.CompanyID),
                       Convert.ToString(IssuedOn.Ticks),
                       ClientKeys.ClientID
                   });

                return EncryptionLibrary.Encrypt(randomnumber);
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public ClientKey GetClientKeysDetailsbyCLientIDandClientSecert(string clientID, string clientSecert)
        {
            try
            {
                var varClientID = EncryptionLibrary.Encrypt(clientID);
                var varClientSecret = EncryptionLibrary.Encrypt(clientSecert);

                var result = (from clientkeys in _context.ClientKeys
                              where clientkeys.ClientID == varClientID && clientkeys.ClientSecret == varClientSecret
                              select clientkeys).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public int InsertToken(TokensManager token)
        {
            try
            {
                _context.TokensManager.Add(token);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public bool IsTokenAlreadyExists(int CompanyID)
        {
            try
            {
                var result = (from token in _context.TokensManager
                              where token.CompanyID == CompanyID
                              select token).Count();
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

        public bool ValidateKeys(ClientKey ClientKeys)
        {
            try
            {
                var ClientID = EncryptionLibrary.Encrypt(ClientKeys.ClientID);
                var ClientSecret = EncryptionLibrary.Encrypt(ClientKeys.ClientSecret);

                var result = (from clientkeys in _context.ClientKeys
                              where clientkeys.ClientID == ClientID && clientkeys.ClientSecret == ClientSecret
                              select clientkeys).Count();
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
    }
}