using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTrackingApp.Repository
{
    public interface IClientKeys
    {
        bool IsUniqueKeyAlreadyGenerate(int UserID);
        bool IsUniqueKeyAlreadyGenerate(int UserID,int CompanyID);
        void GenerateUniqueKey(string ClientID, string ClientSecert);
        int SaveClientIDandClientSecert(ClientKey ClientKeys);
        int UpdateClientIDandClientSecert(ClientKey ClientKeys);
        ClientKey GetGenerateUniqueKeyByUserID(int UserID);
        ClientKey GetGenerateUniqueKeyByUserID(int UserID,int CompanyID);
        (string, string) GenerateEncryptedKey(string ClientID, string ClientSecert);
        (string, string) GenerateDecryptedKey(string clientID, string clientSecret);
        List<ClientTokenViewModel> GetLitKeysTokenListByUserID(int UserID);
        ClientTokenViewModel GetClientTokenByID(int UserID, int CompanyID);
    }
}
