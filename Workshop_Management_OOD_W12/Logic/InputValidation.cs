using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public class InputValidation
    {
		public InputValidation()
		{
			
		}
		public void ValidatePCN(string pcn)
		{
			int result = 0;
			bool ch = int.TryParse(pcn, out result);
			if (!ch)
            {
				throw new Exception("This pcn is not in digits format");
            }
		}
		public void ValidateName(string name)
		{
			if (String.IsNullOrEmpty(name))
            {
				throw new Exception("This name should not be empty");
            }
		}
		public void ValidateEmail(string email)
		{
			var addr = new System.Net.Mail.MailAddress(email);
			if (addr.Address != email)
            {
				throw new Exception("This email is not in right format");
            }
		}
		public void ValidateBirthdate(DateTime birthdate)
		{
			DateTime now = DateTime.Now;
			if (birthdate.AddYears(18).CompareTo(now) == 1)
            {
				throw new Exception("Cannot add a user below 18 years old in university");
            }
		}
		public void ValidateWorkshopTitle(string title)
		{
			if (String.IsNullOrEmpty(title))
			{
				throw new Exception("This title should not be empty");
			}
		}
		public void ValidateURL(string url)
        {
			Uri uriResult;
			bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult);
			result = result && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
			if (!result)
            {
				throw new Exception("This url is not in the correct http or https format");
            }
		}
		public void ValidateAddress(string address)
        {
			if (String.IsNullOrEmpty(address))
			{
				throw new Exception("This address should not be empty");
			}
		}
		public void ValidateRoom(string room)
        {
			if (String.IsNullOrEmpty(room))
			{
				throw new Exception("This room address should not be empty");
			}
		}
	}
}
