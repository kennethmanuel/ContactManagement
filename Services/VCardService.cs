using FolkerKinzel.VCards;
using FolkerKinzel.VCards.Enums;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement;

public class VCardService
{
    public static byte[] GenerateVCardBasedOnContact()
    {
        VCard vCard = VCardBuilder
          .Create()
          .NameViews.Add(familyName: "Sonntag", givenName: "Susi")
          .Phones.Add("+49-321-1234567",
                       parameters: p => p.PhoneType = Tel.Cell
                     )
          .EMails.Add("susi@contoso.com")
          .EMails.Add("susi@home.de")
          .EMails.SetPreferences()
          .VCard;

        return System.Text.Encoding.UTF8.GetBytes(Vcf.ToString(vCard));
    }
}
