﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookRepository
    {
        public static string connectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=AddressBookService; integrated security=true";
        SqlConnection sqlconnection = new SqlConnection(connectionString);
        public int GetPerson()
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<Contacts> PersonList = new List<Contacts>();
                    SqlCommand command = new SqlCommand("spGetPerson", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    int count = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        PersonList.Add(new Contacts
                        {
                            FName = Convert.ToString(dr["FirstName"]),
                            LName = Convert.ToString(dr["LastName"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            Zipcode = Convert.ToInt32(dr["ZipCode"]),
                            Email = Convert.ToString(dr["EmailAddress"])
                        });
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int UpdatePresoninAddressBook(Contacts model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand("spUpdatePerson", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", model.ID);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    int result = command.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Person Updated Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetPersonDate(Contacts model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<Contacts> PersonList = new List<Contacts>();
                    SqlCommand command = new SqlCommand("spGetPersonDate", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DateAdded", model.DateAdded);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    int count = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        PersonList.Add(new Contacts
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            FName = Convert.ToString(dr["FirstName"]),
                            LName = Convert.ToString(dr["LastName"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            Zipcode = Convert.ToInt32(dr["ZipCode"]),
                            Email = Convert.ToString(dr["EmailAddress"]),
                            DateAdded = Convert.ToString(dr["DateAdded"])
                        });
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetPersonByCity(Contacts model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<Contacts> PersonList = new List<Contacts>();
                    SqlCommand command = new SqlCommand("spGetPersonCity", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@City", model.City);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    int count = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        PersonList.Add(new Contacts
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            FName = Convert.ToString(dr["FirstName"]),
                            LName = Convert.ToString(dr["LastName"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            Zipcode = Convert.ToInt32(dr["ZipCode"]),
                            Email = Convert.ToString(dr["EmailAddress"]),
                            DateAdded = Convert.ToString(dr["DateAdded"])
                        });
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int AddPresoninAddressBook(Contacts model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand("spAddPerson", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", model.ID);
                    command.Parameters.AddWithValue("@FirstName", model.FName);
                    command.Parameters.AddWithValue("@LastName", model.LName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@EmailAddress", model.Email);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@ZipCode", model.Zipcode);
                    command.Parameters.AddWithValue("@DateAdded", model.DateAdded);
                    int result = command.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Person Added Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
