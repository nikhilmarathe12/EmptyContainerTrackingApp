using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTrackingApp.Repository
{
    public interface IAuthenticate
    {
        ClientKey GetClientKeysDetailsbyCLientIDandClientSecert(string clientID, string clientSecert);
        bool ValidateKeys(ClientKey ClientKeys);
        bool IsTokenAlreadyExists(int CompanyID);
        int DeleteGenerateToken(int CompanyID);
        int InsertToken(TokensManager token);
        string GenerateToken(ClientKey ClientKeys, DateTime IssuedOn);
    }
}
