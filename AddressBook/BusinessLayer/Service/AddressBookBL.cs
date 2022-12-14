using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class AddressBookBL : IAddressBookBL
    {
        public IAddressBookRL addressRL;
        public AddressBookBL(IAddressBookRL addressRL)
        {
            this.addressRL = addressRL;
        }

        public AddressBookModel Create(AddressBookModel model)
        {
            try
            {
                return addressRL.Create(model);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<GetAddressBookModel> GetAddressBook()
        {
            try
            {
                return addressRL.GetAddressBook();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public AddressBookModel UpdateAddressBook(long Id, AddressBookModel model)
        {
            try
            {
                return addressRL.UpdateaddressBook(Id, model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteAddressBook(long Id)
        {
            try
            {
                return addressRL.DeleteAddressBook(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}