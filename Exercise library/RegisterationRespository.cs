using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using ajayLibrary;

namespace Registeration

    {
  
        public class Studentnamerepository
        {

            public readonly string connectionString;

            public Model adddata()
            {
               Model Stud = new Model();

                Console.WriteLine("enter first name");
                 Stud.FirstName = Console.ReadLine();

                Console.WriteLine("enter lastname name");
                Stud.LastName = Console.ReadLine();
                              
                 Console.WriteLine("enter age");
                 Stud.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter Email");
                 Stud.Email = Console.ReadLine();

                Console.WriteLine("enter gender");
                Stud.Gender = Console.ReadLine();

                return Stud;
            }

            public Studentnamerepository()
            {


                connectionString = @"Data source=DESKTOP-23V7KHU;Initial catalog=Register;User Id=sa;Password=Anaiyaan@123";
            }


        public void InsertSP(Model a)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec inserts  '{a.FirstName}','{a.LastName}',{a.Age},'{a.Email}','{a.Gender}'");
                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public List<Model> SelectSP()

        {
            try
            {
                List<Model> res = new List<Model>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                res = connection.Query<Model>("exec selects; ", connectionString).ToList();
                connection.Close();


                foreach (var h in res)
                {

                    Console.WriteLine($"Id{h.Id}---Name--{h.FirstName}   lastName--{h.LastName}   age--{h.Age}   email--{h.Email}   gender--{h.Gender} ");
                }

                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateSP()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                Console.WriteLine("Enter a FirstName to alter");
                string FirstName = Console.ReadLine();

                Console.WriteLine("Enter a LastName to alter");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter a Age to alter");
                int Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a Email to alter");
                string Email = Console.ReadLine();

                Console.WriteLine("Enter a Gender to alter");
                string Gender = Console.ReadLine();

                Console.WriteLine("Enter a Id ");
                int UpdateId = Convert.ToInt32(Console.ReadLine()); 


                con.Open();
                con.Execute($"  exec updates set '{FirstName}','{LastName}','{Age}','{Email}','{Gender}' where '{UpdateId}'");
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void updateSP(Model a)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"  exec updates set '{a.FirstName}','{a.LastName}','{a.Age}','{a.Email}','{a.Gender}' where '{a.Id}'");
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void deleteSP()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                Console.WriteLine("enter a Id  to delete record");
                string del = Console.ReadLine();
                con.Open();
                con.Execute($"exec deletes '{del}'");
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void deleteSP(Model a)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);


                con.Open();
                con.Execute($"exec deletes '{a.Id}'");
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            public void Menu()
            {

                int b;
                do
                {
                    Console.WriteLine("Choose the option");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("1.Insert SP");
                    Console.WriteLine("2.Select SP");
                    Console.WriteLine("3.ubdate SP");
                    Console.WriteLine("4.delete SP");

                    Studentnamerepository obj = new Studentnamerepository();

                    b = Convert.ToInt32(Console.ReadLine());

                    switch (b)
                    {


                        case 1:
                            var add1 = obj.adddata();
                            obj.InsertSP(add1);
                            break;
                        case 2:
                            obj.SelectSP();

                            break;
                        case 3:
                            obj.updateSP();

                            break;
                        case 4:
                            obj.deleteSP();
                            break;

                        default:
                            Console.WriteLine("Please give a valid Option");
                            break;

                    }

                } while (b != 0);
            }
        }

    }




