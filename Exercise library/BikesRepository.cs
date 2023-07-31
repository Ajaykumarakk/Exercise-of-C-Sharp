using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data.SqlClient;

namespace ajayLibrary
{

    public class bikesinfo
    {
        public string models { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public int Topspeed { get; set; }


    }


    public class BikesRepository
    {
        public readonly string connectiongstring;

       

        public BikesRepository()
        {
            connectiongstring = @"Data source=DESKTOP-23V7KHU;Initial catalog=ajay SQL;User Id=sa;Password=Anaiyaan@123";

        }

        public bikesinfo Model()
        {
            bikesinfo vechile = new bikesinfo();
            
            Console.WriteLine("Enter the Model");
             vechile.models = Console.ReadLine();
            Console.WriteLine("Enter the Price");
             vechile.Price =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the Color");
            vechile.Color = Console.ReadLine();
            Console.WriteLine("Enter the Mileage");
            vechile.Mileage =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Topspeed");
            vechile.Topspeed = Convert.ToInt32(Console.ReadLine());


            return vechile;
        }
        public void Insert(bikesinfo a)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectiongstring);


                con.Open();
                con.Execute($"insert into Bikes(Models,Price,Color,Mileage,Topspeed) values ('{a.models}',{a.Price},'{a.Color}','{a.Mileage}','{a.Topspeed}')");

                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception)
            {

            }
        }
        public List<bikesinfo> select()
        {
            SqlConnection con = new SqlConnection(connectiongstring);
            List<bikesinfo> result = new List<bikesinfo>();

            con.Open();
            result = con.Query<bikesinfo>("select * from bikes", connectiongstring).ToList();
            con.Close();

            foreach(var tab in result)
            {
                Console.WriteLine($"Model{tab.models},Price{tab.Price},Color{tab.Color},Mileage{tab.Mileage},Topspeed{tab.Topspeed}");
            }

            return result;


        }
        public void D1()
        {
           
            SqlConnection con = new SqlConnection(connectiongstring);

            Console.WriteLine("enter the delete records");
            var del = Console.ReadLine();
            con.Open();
            con.Execute($"delete from Bikes where Models = '{del}'");
            con.Close();

        }

        public void U1(bikesinfo b)
        {
            SqlConnection con = new SqlConnection(connectiongstring);

            Console.WriteLine("enter the update records");
            var update = Console.ReadLine();
            con.Open();
            con.Execute($"update Bikes set Models='{b.models}',Price='{b.Price}',color='{b.Color}',Mileage='{b.Mileage}',Topspeed='{b.Topspeed}' where Models ='{update}'");
            con.Close();
        }

        public void PI(bikesinfo g)
        {
            SqlConnection con = new SqlConnection(connectiongstring);

            con.Open();
            con.Execute($"exec inserts  '{g.models}','{g.Price}','{g.Color}','{g.Mileage}','{g.Topspeed}'");
            con.Close();
        }

        public List<bikesinfo> PS()
        {
            SqlConnection con = new SqlConnection(connectiongstring);
            List<bikesinfo> show = new List<bikesinfo>();

            con.Open();
            show = con.Query<bikesinfo>("selects").ToList();
            con.Close();

            foreach (var tabs in show)
            {
                Console.WriteLine($"Model{tabs.models},Price{tabs.Price},Color{tabs.Color},Mileage{tabs.Mileage},Topspeed{tabs.Topspeed}");
            }

            return show;
        }

        public void PU()
        {
            SqlConnection con = new SqlConnection(connectiongstring);

            Console.WriteLine("enter the color to update mialage");
            string color = Console.ReadLine();
            Console.WriteLine("enter mialage");
            string mileage = Console.ReadLine();

            con.Open();
            con.Execute($"exec updates '{color}', {mileage} ");
            con.Close();
        }
        public void PD()
        {
            SqlConnection con = new SqlConnection(connectiongstring);

            Console.WriteLine("enter the delete records");
            var del = Console.ReadLine();

            con.Open();
            con.Execute($"exec d3delete {del}");
            con.Close();
        }

        public void s1()
        {
            int a;

            do
            {
                Console.WriteLine("choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.List");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Update");
                Console.WriteLine("5.Pinsert");
                Console.WriteLine("6.Pselect");
                Console.WriteLine("7.Pupdate");
                Console.WriteLine("8.Pdelete");

                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 0:

                        Console.WriteLine("Thank you");

                        break;

                    case 1:
                        BikesRepository obj = new BikesRepository();
                        var mini = obj.Model();
                        obj.Insert(mini);

                        break;

                    case 2:
                        BikesRepository obj1 = new BikesRepository();
                        obj1.select();
                        break;
                    case 3:
                        BikesRepository obj2 = new BikesRepository();
                        obj2.D1();
                        break;
                    case 4:
                        BikesRepository obj3 = new BikesRepository();
                        var alter = obj3.Model();
                        obj3.U1(alter);
                        break;

                    case 5:
                        BikesRepository obj4 = new BikesRepository();
                        var max = obj4.Model();
                        obj4.PI(max);
                        break;

                    case 6:
                        BikesRepository obj5 = new BikesRepository();
                        obj5.PS();
                        break;
                    case 7:
                        BikesRepository obj6 = new BikesRepository();
                       // var up = obj6.Model();
                        obj6.PU();
                        break;
                    case 8:
                        BikesRepository obj7 = new BikesRepository();
                        obj7.PD();
                        break;

                }
            } while (a != 0);
        }
    }



}
