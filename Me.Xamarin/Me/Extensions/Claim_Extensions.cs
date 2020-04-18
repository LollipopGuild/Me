using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Me.ViewModels;

namespace Me
{
    public static class Claim_Extensions
    {
        public static string QRCodeString(this ObservableCollection<ClaimViewModel> claims)
        {
            //return $"IOPClaimVerification://{string.Join("|", claims.Where(c => c?.Value != null).Select(c => $"{c.Name}~{c.Value}"))}";
            var claim = $"{string.Join("|", claims.Where(c => c?.Value != null).Select(c => $"{c.Name}~{c.Value}"))}";
            return $"https://me-web.azurewebsites.net/IOPClaimVerification?{claim.EncodeBase64()}";
        }

        public static string FamilyName(this ObservableCollection<ClaimViewModel> claims)
        {
            return claims.FirstOrDefault(c => c.Name == "Name_Family")?.Value;
        }

        public static string GivenName(this ObservableCollection<ClaimViewModel> claims)
        {
            return string.Join(" ", claims.Where(c => c.Name == "Name_Given")
                                               .Select(c => c.Value));
        }


        public static string EncodeBase64(this string inStr)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(inStr));
        }

        public static string DecodeBase64(this string inStr)
        {
            byte[] buf = Convert.FromBase64String(inStr);
            return Encoding.UTF8.GetString(buf, 0, buf.Length);
        }

    }
}
