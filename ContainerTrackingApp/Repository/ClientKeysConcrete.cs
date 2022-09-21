using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ContainerTrackingApp.AES256;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;


namespace ContainerTrackingApp.Repository
{
    public class ClientKeysConcrete : IClientKeys
    {
        DatabaseContext _context;
        AES256Encryption EncryptionLibrary;
        ILogService _logService;
        public ClientKeysConcrete()
        {
            _logService = new RepositoryExceptionLog();
            EncryptionLibrary = new AES256Encryption();
            _context = new DatabaseContext();
        }

        public void GenerateUniqueKey(string ClientID,string ClientSecert)
        {
            try
            {
                ClientID = AES256.KeyGenerator.GetUniqueKey();
                ClientSecert = AES256.KeyGenerator.GetUniqueKey();
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public (string, string) GenerateEncryptedKey(string ClientID, string ClientSecert)
        {
            try
            {
                var strClientNameID = EncryptionLibrary.Encrypt(ClientID);
                var StrClientSecert = EncryptionLibrary.Encrypt(ClientSecert);
                return (strClientNameID, StrClientSecert);
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public (string, string) GenerateDecryptedKey(string clientID, string clientSecret)
        {
            try
            {
                var strClientNameID = EncryptionLibrary.Decrypt(clientID);
                var StrClientSecert = EncryptionLibrary.Decrypt(clientSecret);
                return (strClientNameID, StrClientSecert);
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }
        public ClientKey GetGenerateUniqueKeyByUserID(int UserID)
        {
            try
            {
                var clientkey = (from ckey in _context.ClientKeys
                                 where ckey.UserID == UserID
                                 select ckey).FirstOrDefault();
                return clientkey;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }
        public ClientKey GetGenerateUniqueKeyByUserID(int UserID, int CompanyID)
        {
            try
            {
                var clientkey = (from ckey in _context.ClientKeys
                                 where ckey.UserID == UserID & ckey.CompanyID == CompanyID
                                 select ckey).FirstOrDefault();
                return clientkey;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public ClientTokenViewModel GetClientTokenByID(int UserID, int CompanyID)
        {
            try
            {
                var clientkeyToken = (from Client in _context.ClientKeys
                                      join Token in _context.TokensManager
                                      on Client.CompanyID equals Token.CompanyID
                                      where Client.UserID == UserID & Client.CompanyID == CompanyID
                                      select new
                                      {
                                          KeyID = Client.ClientKeyID,
                                          clientID = Client.ClientID,
                                          clientSecret = Client.ClientSecret,
                                          companyID = Client.CompanyID,
                                          userID = Client.UserID,
                                          tokenID = Token.TokenID,
                                          tokenKey = Token.TokenKey,
                                          createdOn = Token.CreatedOn,
                                          expiredOn = Token.ExpiredOn,
                                          issuedOn = Token.IssuedOn
                                      }).ToList();
                                     

                ClientTokenViewModel VMclientToken = null;
                foreach (var item in clientkeyToken)
                {
                    VMclientToken = new ClientTokenViewModel
                    {
                        UserID = item.userID,
                        UserName = _context.RegisterUser.SingleOrDefault(x => x.UserID == UserID).UserName,
                        CompanyID = item.companyID,
                        CompanyName = _context.RegisterCompany.SingleOrDefault(x =>x.CompanyID == CompanyID).Name,
                        ClientKeyID = item.KeyID,
                        ClientID = EncryptionLibrary.Decrypt(item.clientID),
                        ClientSecret = EncryptionLibrary.Decrypt(item.clientSecret),
                        TokenID = item.tokenID,
                        TokenKey = item.tokenKey,
                        CreatedOn = item.createdOn,
                        ExpiredOn = item.expiredOn,
                        IssuedOn = item.issuedOn
                    };
                }

                return VMclientToken;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }
        public bool IsUniqueKeyAlreadyGenerate(int UserID)
        {
            try
            {
                bool keyExists = _context.ClientKeys.Any(clientkeys => clientkeys.UserID.Equals(UserID));

                if (keyExists)
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

        public bool IsUniqueKeyAlreadyGenerate(int UserID, int CompanyID)
        {
            try
            {
                
                bool keyExists = (from ClientData in _context.ClientKeys
                            where ClientData.UserID == UserID && ClientData.CompanyID == CompanyID
                            select ClientData).Any();

                if (keyExists)
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

        public int SaveClientIDandClientSecert(ClientKey ClientKeys)
        {
            try
            {
                bool ClientDataExist = (from ClientData in _context.ClientKeys
                                        where ClientData.UserID == ClientKeys.UserID && ClientData.CompanyID == ClientKeys.CompanyID && ClientData.ClientID == ClientKeys.ClientID
                                        select ClientData.ClientKeyID).Any();
                if (ClientDataExist)
                {
                    _context.Database.ExecuteSqlCommand("UPDATE [dbo].[ClientKeys] SET [ClientID] = '" + ClientKeys.ClientID + "', [ClientSecret] = '" + ClientKeys.ClientSecret + "' WHERE [CompanyID] = '" + ClientKeys.CompanyID + "' and [UserID] = '" + ClientKeys.UserID + "'");
                    //_context.Entry(ClientKeys).State = EntityState.Modified;
                    //_context.SaveChanges();
                    return _context.SaveChanges();
                }
                else
                {
                    _context.ClientKeys.Add(ClientKeys);
                    return _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public int UpdateClientIDandClientSecert(ClientKey ClientKeys)
        {
            try
            {
                _context.Entry(ClientKeys).State = EntityState.Modified;
                _context.SaveChanges();
                return _context.SaveChanges();
                
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public List<ClientTokenViewModel> GetLitKeysTokenListByUserID(int UserID)
        {
            try
            {
                //List<ClientTokenViewModel> clientTokenViewModel = (from Client in _context.ClientKeys
                //                                                   join Token in _context.TokensManager
                //                                                   on Client.CompanyID equals Token.CompanyID
                //                                                   where Client.UserID == UserID
                //                                                   select new ClientTokenViewModel {
                //                                                            ClientID = Client.ClientID,
                //                                                            ClientKeyID = Client.ClientKeyID,
                //                                                            ClientSecret = Client.ClientSecret,
                //                                                            CompanyID = Client.CompanyID,
                //                                                            UserID = Client.UserID,
                //                                                            TokenID = Token.TokenID,
                //                                                            TokenKey = Token.TokenKey,
                //                                                            CreatedOn = Token.CreatedOn,
                //                                                            ExpiredOn = Token.ExpiredOn,
                //                                                            IssuedOn = Token.IssuedOn 
                //                                                   }).ToList();
                //return clientTokenViewModel;

                var clientTokenViewModel = (from Client in _context.ClientKeys
                                                                   join Token in _context.TokensManager
                                                                   on Client.CompanyID equals Token.CompanyID
                                                                   where Client.UserID == UserID
                                                                   select new {
                                                                        Client.ClientID,Client.ClientKeyID,Client.ClientSecret,Client.CompanyID,Client.UserID,
                                                                        Token.TokenID,Token.TokenKey,Token.CreatedOn,Token.ExpiredOn,Token.IssuedOn
                                                                   }).ToList();
                List<ClientTokenViewModel> listClientToken = new List<ClientTokenViewModel>();
                ClientTokenViewModel VMclientToken;
                  foreach(var item in clientTokenViewModel)
                    {
                    VMclientToken = new ClientTokenViewModel();
                    VMclientToken.UserID = item.UserID;
                    VMclientToken.CompanyID = item.CompanyID;
                    VMclientToken.ClientKeyID = item.ClientKeyID;
                    VMclientToken.ClientID = EncryptionLibrary.Decrypt(item.ClientID); 
                    VMclientToken.ClientSecret = EncryptionLibrary.Decrypt(item.ClientSecret);
                    VMclientToken.TokenID = item.TokenID;
                    VMclientToken.TokenKey = item.TokenKey;
                    VMclientToken.CreatedOn = item.CreatedOn;
                    VMclientToken.ExpiredOn = item.ExpiredOn;
                    VMclientToken.IssuedOn = item.IssuedOn;
                    listClientToken.Add(VMclientToken);
                    }

                return listClientToken;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

       
    }
}