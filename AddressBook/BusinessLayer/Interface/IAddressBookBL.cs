﻿using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IAddressBookBL
    {
        public AddressBookModel Create(AddressBookModel model);
        public List<GetAddressBookModel> GetAddressBook();
        public AddressBookModel UpdateAddressBook(long Id, AddressBookModel model);

    }
}