using GymProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace GymProject.DataAccess
{
    public class UserDataProvider : BaseDataProvider
    {
        public bool CreateUser(User user)
        {
            try
            {
                OpenConnection();
                transaction = connection.BeginTransaction();

                string sql = @"INSERT INTO User(userName,password,firstName,lastName,gender,email,dob,mobileNo,address,landNo,typeID) 
                               VALUES(@userName,@password,@firstName,@lastName,@gender,@email,@dob,@mobileNo,@address,@landNo,@userType)";

                DbCommand dbCommand = db.GetSqlStringCommand(sql);

                db.AddInParameter(dbCommand, "@userName", DbType.String, user.Username);
                db.AddInParameter(dbCommand, "@password", DbType.String, user.Password);
                db.AddInParameter(dbCommand, "@firstName", DbType.String, user.FirstName);
                db.AddInParameter(dbCommand, "@lastName", DbType.String, user.LastName);
                db.AddInParameter(dbCommand, "@gender", DbType.String, user.Gender);
                db.AddInParameter(dbCommand, "@email", DbType.String, user.Email);
                db.AddInParameter(dbCommand, "@mobileNo", DbType.String, user.MobileNumber);
                db.AddInParameter(dbCommand, "@landNo", DbType.String, user.LandNumber);
                db.AddInParameter(dbCommand, "@address", DbType.String, user.Address);
                db.AddInParameter(dbCommand, "@dob", DbType.DateTime, user.DateOfBirth);
                db.AddInParameter(dbCommand, "@userType", DbType.Int32, user.UserType);

                db.ExecuteNonQuery(dbCommand, transaction);
                transaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                    return false;
                }

                if (ex.InnerException == null)
                    throw new Exception("Stack Trace:" + ex.StackTrace + "Message:" + ex.Message, ex);
                else
                    throw ex;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public User GetUser(string username, string password)
        {
            User user = null;

            try
            {
                OpenConnection();

                string sql = "SELECT * FROM user WHERE userName=@userName AND password=@password";

                DbCommand dbCommand = db.GetSqlStringCommand(sql);

                db.AddInParameter(dbCommand, "@userName", DbType.String, username);
                db.AddInParameter(dbCommand, "@password", DbType.String, password);

                int intVal;
                DateTime dateVal;

                using (var reader = db.ExecuteReader(dbCommand))
                {
                    if (reader.Read())
                    {
                        user = new User();

                        if (int.TryParse(reader["userID"].ToString(), out intVal))
                            user.UserId = intVal;

                        user.Username = reader["userName"].ToString();
                        user.Password = reader["password"].ToString();
                        user.FirstName = reader["firstName"].ToString();
                        user.LastName = reader["lastName"].ToString();
                        user.Gender = reader["gender"].ToString();
                        user.Email = reader["email"].ToString();
                        user.MobileNumber = reader["mobileNo"].ToString();
                        user.LandNumber = reader["landNo"].ToString();
                        user.Address = reader["address"].ToString();

                        if (DateTime.TryParse(reader["dob"].ToString(), out dateVal))
                            user.DateOfBirth = dateVal;

                        if (int.TryParse(reader["typeID"].ToString(), out intVal))
                            user.UserType = (UserType)intVal;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null)
                    throw new Exception("Stack Trace:" + ex.StackTrace + "Message:" + ex.Message, ex);
                else
                    throw ex;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }

            return user;
        }
    }
}
