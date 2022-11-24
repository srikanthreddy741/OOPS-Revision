﻿using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Service
{
    public class AddressBookRL : IAddressBookRL
    {
        private readonly string ConnectionString;
        public AddressBookRL(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("Addressbook1");
        }
        public AddressBookModel Create(AddressBookModel model)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand Address = new SqlCommand("SpAddressBook", connection);
                Address.CommandType = CommandType.StoredProcedure;
                Address.Parameters.AddWithValue("@FirstName", model.FirstName);
                Address.Parameters.AddWithValue("@LastName", model.LastName);
                Address.Parameters.AddWithValue("@Email", model.Email);
                Address.Parameters.AddWithValue("@Mobile", model.Mobile);
                Address.Parameters.AddWithValue("@Address", model.Address);
                Address.Parameters.AddWithValue("@City", model.City);
                Address.Parameters.AddWithValue("@State", model.State);
                Address.Parameters.AddWithValue("@Pincode", model.Pincode);
                connection.Open();
                var result = Address.ExecuteNonQuery();
                connection.Close();
                if (result != null)
                {
                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<GetAddressBookModel> GetAddressBook()
        {
            List<GetAddressBookModel> result = new List<GetAddressBookModel>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand("getAddressBook", connection);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    GetAddressBookModel get = new GetAddressBookModel();
                    get.Id = reader.GetInt32("Id");
                    get.FirstName = reader.GetString("FirstName");
                    get.LastName = reader.GetString("LastName");
                    get.Email = reader.GetString("Email");
                    get.Mobile = reader.GetString("Mobile");
                    get.Address = reader.GetString("Address");
                    get.City = reader.GetString("City");
                    get.State = reader.GetString("State");
                    get.Pincode = reader.GetString("Pincode");
                    result.Add(get);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public AddressBookModel UpdateaddressBook(long Id, AddressBookModel model)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("UpdateAddressBook", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@FirstName", model.FirstName);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Mobile", model.Mobile);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@City", model.City);
                command.Parameters.AddWithValue("@State", model.State);
                command.Parameters.AddWithValue("@Pincode", model.Pincode);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                if (result != null)
                {
                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteAddressBook(long Id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("DeleteAddressBook", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}