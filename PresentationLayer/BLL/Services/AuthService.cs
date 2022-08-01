using BLL.BOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenModel Authenticate(string uname, string pass)
        {
            var user = DataAccessFactory.GetAuthDataAccess().Authenticate(uname, pass);
            TokenModel t = null;
            if(user != null)
            {
                var key = GenToken();
                Token token= new Token();
                token.Token1 = key;
                token.UserId = user.Id;
                token.CreatedAt = DateTime.Now;
                var created_token = DataAccessFactory.GetTokenDataAccess().Create(token);
                t = new TokenModel()
                {
                    Id = created_token.Id,
                    TokenKey = created_token.Token1,
                    CreatedAt = created_token.CreatedAt,
                    UserId = created_token.UserId,
                    ExpiredAt = created_token.ExpiredAt
                };
                

            }
            return t;
        }
        public static string GenToken()
        {
            Random res = new Random();

            // String of alphabets 
            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = 40;

            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(26);

                // Appending the character at the 
                // index to the random string.
                ran = ran + str[x];
            }
            return ran;
        }
        public static bool TokenValidity(string token)
        {
            var tk = DataAccessFactory.GetTokenDataAccess().Get(token);
            if(tk != null && tk.ExpiredAt== null)
            {
                return true;
            }
            return false;

        }
        public static bool Logout(TokenModel tk)
        {
            var d_tk = DataAccessFactory.GetTokenDataAccess().Get(tk.TokenKey);
            d_tk.ExpiredAt = DateTime.Now;
            return DataAccessFactory.GetTokenDataAccess().Update(d_tk);

        }
    }
}
