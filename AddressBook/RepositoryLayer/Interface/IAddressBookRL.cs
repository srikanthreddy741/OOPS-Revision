using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{

    public interface IAddressBookRL
    {
        public AddressBookModel Create(AddressBookModel model);
        public List<GetAddressBookModel> GetAddressBook();
    }
}