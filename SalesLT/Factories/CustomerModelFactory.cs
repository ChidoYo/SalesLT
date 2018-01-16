using SalesLT.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesLT.Factories
{
    public class CustomerModelFactory
    {
        public Customer Create(Customer customer, List<CustomerAddress> address)
        {
            return new Customer
            {
                FirstName = customer.FirstName,
                MiddleName = customer.MiddleName,
                LastName = customer.LastName,
                EmailAddress = customer.EmailAddress,
                Phone = customer.Phone,
                CustomerAddresses = address == null ? new List<CustomerAddress>() : address
            };
        }
    }
}


//namespace myInstitute.Factories
//{
//    public class UserModelFactory : IUserModelFactory
//    {
//        public UserDataModel Create(SAMLUserData CurrentUser, List<UserPreference> prefs, LanguageDataModel langData)
//        {
//            return new UserDataModel
//            {
//                FirstName = CurrentUser.GivenName,
//                LastName = CurrentUser.Surname,
//                Role = CurrentUser.Role,
//                ChurchUnit = CurrentUser.UnitNumber,
//                Preferences = prefs == null ? new List<UserPreference>() : prefs,
//                LangData = langData,
//                IsImpersonating = CurrentUser.IsEmployeeImpersonating || CurrentUser.IsAdminImpersonating,
//                UserName = CurrentUser.LdsAccountUserName
//            };
//        }
//    }
//}