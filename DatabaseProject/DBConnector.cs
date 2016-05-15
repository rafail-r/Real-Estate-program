using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace DatabaseProject
{
    internal class DBConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        internal DBConnector()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "database";
            uid = "user";
            password = "user";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Status: Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Status: Invalid username/password, please try again");
                        break;
                }
                return false;
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.Data);
                return false;
            }

        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal Boolean addPayment(String billing_id)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("INSERT INTO payments (billing_id, date_payed) VALUES (@billingid,@datepayed)");

                    cmd.Parameters.Add("@billingid", MySqlDbType.Int32);
                    cmd.Parameters["@billingid"].Value = billing_id;
                    cmd.Parameters.Add("@datepayed", MySqlDbType.Date);
                    cmd.Parameters["@datepayed"].Value = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        internal Boolean isPhoneUnique(String phone)
        {
            Boolean retVal = false;

            if (this.OpenConnection() == true)
            {
                MySqlDataReader dataReader;
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("SELECT phone FROM addresses WHERE addresses.phone=@phone");

                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar);
                    cmd.Parameters["@phone"].Value = phone;


                    dataReader = cmd.ExecuteReader();
                    if (!dataReader.Read())
                    {
                        retVal = true;
                    }
                    dataReader.Close();
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return retVal;
        }

        internal List<String> getEmails(String c_id)
        {
            List<String> l = new List<String>();
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlDataReader dataReader;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("SELECT email FROM emails WHERE emails.cust_id=@cid");

                    cmd.Parameters.Add("@cid", MySqlDbType.Int32);
                    cmd.Parameters["@cid"].Value = c_id;

                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                       l.Add(dataReader["email"].ToString());
                    }
                    dataReader.Close();
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return l;
                }
            }
            return l;
        }

        internal Boolean isEmailUnique(List<String> emails)
        {
            Boolean retVal = false;
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlDataReader dataReader;
                    foreach (String email in emails)
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("SELECT email FROM emails WHERE emails.email=@email");

                        cmd.Parameters.Add("@email", MySqlDbType.VarChar);
                        cmd.Parameters["@email"].Value = email;

                        dataReader = cmd.ExecuteReader();
                        if (!dataReader.Read())
                        {
                            retVal = true;
                        }
                        else
                        {
                            dataReader.Close();
                            break;
                        }
                        dataReader.Close();
                    }
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return retVal;
        }

        internal Dictionary<String, List<String>> getPaymentInfo(String customersPhone)
        {
            Dictionary<String, List<String>> list = new Dictionary<String, List<String>>();
            list["info"] = new List<String>();
            list["amount"] = new List<String>();
            list["bill_id"] = new List<String>();
            list["cust_id"] = new List<String>();
            list["book_id"] = new List<String>();
            list["from"] = new List<String>();
            list["to"] = new List<String>();
            list["hotel_id"] = new List<String>();
            list["people_number"] = new List<String>();

            if (this.OpenConnection() == true)
            {
                try
                {
                    String query = "SELECT * FROM paymentsinfo WHERE phone = '" + customersPhone + "'";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list["info"].Add((dataReader["Info"].ToString()));
                        list["amount"].Add((dataReader["Amount"].ToString()));
                        list["bill_id"].Add((dataReader["bill_id"].ToString()));
                        list["cust_id"].Add((dataReader["cust_id"].ToString()));
                        list["book_id"].Add((dataReader["book_id"].ToString()));
                        list["from"].Add((dataReader["from_date"].ToString()));
                        list["to"].Add((dataReader["to_date"].ToString()));
                        list["hotel_id"].Add((dataReader["hotel_id"].ToString()));
                        list["people_number"].Add((dataReader["people_number"].ToString()));
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return list;
                }
                this.CloseConnection();
            }
            return list;
        }

        internal Boolean updateBilling(DBBilling bill, String book_id)
        {
            if (this.OpenConnection() == true)
            {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("UPDATE billing SET amount=@amount, way_pay=@waypay WHERE billing.book_id=@bookid");

                        cmd.Parameters.Add("@amount", MySqlDbType.Int32);
                        cmd.Parameters["@amount"].Value = bill.amount;
                        cmd.Parameters.Add("@waypay", MySqlDbType.VarChar);
                        cmd.Parameters["@waypay"].Value = bill.way_pay;
                        cmd.Parameters.Add("@bookid", MySqlDbType.VarChar);
                        cmd.Parameters["@bookid"].Value = book_id;
                        
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        return true;
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show("In here");
                        this.CloseConnection();
                        MessageBox.Show(ex.Message);
                        return false;
                    }
            }
            return false;
        }

        internal Boolean updateBooking(DBBooking book, String book_id, String peopleNo)
        {
            List<String> roomNumbers = getRooms(book.hotel_id, book.first_date.ToString("yyyy-MM-dd"), book.last_date.ToString("yyyy-MM-dd"), peopleNo)["roomno"];
            if (roomNumbers.Count != 0)
            {
                String roomNumber = roomNumbers[0];
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("UPDATE bookings SET hotel_id = @hotelid, room_number = @roomnumber," +
                               " first_date = @firstdate, last_date = @lastdate" +
                               " WHERE id = @bookid");

                        cmd.Parameters.Add("@hotelid", MySqlDbType.Int32);
                        cmd.Parameters["@hotelid"].Value = book.hotel_id;
                        cmd.Parameters.Add("@roomnumber", MySqlDbType.Int32);
                        cmd.Parameters["@roomnumber"].Value = roomNumber;
                        //cmd.Parameters.Add("@bookdate", MySqlDbType.Date);
                        //cmd.Parameters["@bookdate"].Value = book.book_date;
                        cmd.Parameters.Add("@firstdate", MySqlDbType.Date);
                        cmd.Parameters["@firstdate"].Value = book.first_date;
                        cmd.Parameters.Add("@lastdate", MySqlDbType.Date);
                        cmd.Parameters["@lastdate"].Value = book.last_date;
                        cmd.Parameters.Add("@bookid", MySqlDbType.Int32);
                        cmd.Parameters["@bookid"].Value = book_id;

                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        return true;
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        this.CloseConnection();
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
                return false;
            }
            else
            {
                MessageBox.Show("Room number not available");
                return false;
            }
        }

        internal Boolean updateReservation(DBBooking book, DBBilling bill, String book_id, String peopleNo)
        {
            if (updateBooking(book, book_id, peopleNo))
            {
                if (updateBilling(bill, book_id))
                {
                    return true;
                }
            }
            return false;
        }


        private String addBooking(DBBooking book, String customerId, String peopleNo)
        {
            String id = "-1";

            List<String> roomNumbers = getRooms(book.hotel_id, book.first_date.ToString("yyyy-MM-dd"), book.last_date.ToString("yyyy-MM-dd"), peopleNo)["roomno"];
            if (roomNumbers.Count != 0)
            {
                String roomNumber = roomNumbers[0];
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("INSERT INTO bookings (cust_id, hotel_id, room_number, first_date, last_date) VALUES (" +
                                        "@customerid,@hotelid,@roomnumber,@firstdate, @lastdate); SELECT LAST_INSERT_ID()");
                        //
                        cmd.Parameters.Add("@customerid", MySqlDbType.Int32);
                        cmd.Parameters["@customerid"].Value = customerId;
                        cmd.Parameters.Add("@hotelid", MySqlDbType.Int32);
                        cmd.Parameters["@hotelid"].Value = book.hotel_id;
                        cmd.Parameters.Add("@roomnumber", MySqlDbType.Int32);
                        cmd.Parameters["@roomnumber"].Value = roomNumber;
                        //cmd.Parameters.Add("@bookdate", MySqlDbType.Date);
                        //cmd.Parameters["@bookdate"].Value = book.book_date;
                        cmd.Parameters.Add("@firstdate", MySqlDbType.Date);
                        cmd.Parameters["@firstdate"].Value = book.first_date;
                        cmd.Parameters.Add("@lastdate", MySqlDbType.Date);
                        cmd.Parameters["@lastdate"].Value = book.last_date;

                        id = cmd.ExecuteScalar().ToString();
                        this.CloseConnection();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show("In Here");
                        this.CloseConnection();
                        MessageBox.Show(ex.Message);
                        return id;
                    }
                }
                return id;
            }
            else
            {
                MessageBox.Show("Room number not available");
                return id;
            }
        }

        private String addBilling(DBBilling bill, String bookId)
        {
            String id = "-1";
            if (bookId != "-1")
            {
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("INSERT INTO billing (book_id, amount, way_pay) VALUES (" +
                                        "@bookid,@amount,@waypay); SELECT LAST_INSERT_ID()");

                        cmd.Parameters.Add("@bookid", MySqlDbType.Int32);
                        cmd.Parameters["@bookid"].Value = bookId;
                        cmd.Parameters.Add("@amount", MySqlDbType.Int32);
                        cmd.Parameters["@amount"].Value = bill.amount;
                        cmd.Parameters.Add("@waypay", MySqlDbType.VarChar);
                        cmd.Parameters["@waypay"].Value = bill.way_pay;

                        id = cmd.ExecuteScalar().ToString();
                        this.CloseConnection();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        this.CloseConnection();
                        MessageBox.Show(ex.Message);
                        return id;
                    }
                }
            }
            return id;
        }

        internal Boolean cancelReservation(String book_id)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("DELETE FROM  bookings WHERE id = @bookid");
                    cmd.Parameters.Add("@bookid", MySqlDbType.Int32);
                    cmd.Parameters["@bookid"].Value = book_id;

                    cmd.ExecuteNonQuery();
                    /*
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("DELETE FROM  billing WHERE billing.book_id = @bookid");
                    cmd.Parameters.Add("@bookid", MySqlDbType.Int32);
                    cmd.Parameters["@bookid"].Value = book_id;

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = ("DELETE FROM  bookings WHERE bookings.id = @bookid");

                    cmd.ExecuteNonQuery();
                     */
                    this.CloseConnection();
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }
        
        internal Boolean addReservation(DBBooking book, DBBilling bill, String customerId, String peopleNo)
        {
            //MessageBox.Show("Adding reservation: Hotel id=" + book.hotel_id + " from=" + book.first_date + " to=" + book.last_date 
            //    + " amount=" + bill.amount + " deadline" + bill.deadline + " way pay" + bill.way_pay + ".");

            String book_id = addBooking(book, customerId, peopleNo);
            String bill_id = addBilling(bill, book_id);

            if (bill_id != "-1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal Dictionary<String, String> getCustomersName(String phone)
        {
            Dictionary<String, String> str = new Dictionary<String, String>();

            if (this.OpenConnection() == true)
            {
                try
                {
                    String query = "SELECT DISTINCT customers.id, customers.name, customers.lastname, customers.addr_id, customers.birthdate, addresses.phone, addresses.country," +
                        "addresses.city,addresses.street,addresses.zipcode,addresses.streetNo FROM customers, addresses WHERE " +
                        " addresses.phone='" + phone + "'AND customers.addr_id=addresses.id";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {
                        str["name"] = dataReader["name"].ToString() + " " + dataReader["lastname"].ToString();
                        str["id"] = dataReader["id"].ToString();
                        str["addrid"] = dataReader["addr_id"].ToString();
                        str["firstname"] = dataReader["name"].ToString();
                        str["lastname"] = dataReader["lastname"].ToString();
                        str["phone"] = dataReader["phone"].ToString();
                        str["country"] = dataReader["country"].ToString();
                        str["city"] = dataReader["city"].ToString();
                        str["street"] = dataReader["street"].ToString();
                        str["zipcode"] = dataReader["zipcode"].ToString();
                        str["streetNo"] = dataReader["streetNo"].ToString();
                        str["birthdate"] = dataReader["birthdate"].ToString();
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return str;
                }
            }
            //return list to be displayed
            return str;
        }

        internal Dictionary<String, List<String>> getRoomsInfo(String id)
        {
            String query = "SELECT DISTINCT type,price,number,people_number FROM rooms WHERE rooms.hotel_id = " + id;
            Dictionary<String, List<String>> list = new Dictionary<String, List<String>>();
            list["type"] = new List<String>();
            list["price"] = new List<String>();
            list["number"] = new List<String>();
            list["persons"] = new List<String>();
            list["data"] = new List<String>();

            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list["type"].Add((dataReader["type"].ToString()));
                        list["price"].Add((dataReader["price"].ToString()));
                        list["number"].Add((dataReader["number"].ToString()));
                        list["persons"].Add((dataReader["people_number"].ToString()));
                        list["data"].Add("Number:" + dataReader["number"].ToString() + ", Type: " + (dataReader["type"].ToString()) + ", Price: " + (dataReader["price"].ToString()) + " for" + (dataReader["people_number"].ToString()) + " persons");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return list;
                }
            }
            //return list to be displayed
            return list;
        }

        internal Boolean addRooms(DBRoom room, String h_id)
        {

            int i;
            int k;
            k = Int32.Parse(room.number);
            if (this.OpenConnection() == true)
            {
                for (i = 0; i < k; i++)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("INSERT INTO rooms (hotel_id,type,price,people_number) VALUES (" +
                                            "@hotel_id,@type,@price,@persons)");

                        cmd.Parameters.Add("@hotel_id", MySqlDbType.Int32);
                        cmd.Parameters["@hotel_id"].Value = h_id;
                        cmd.Parameters.Add("@type", MySqlDbType.VarChar);
                        cmd.Parameters["@type"].Value = room.type;
                        cmd.Parameters.Add("@price", MySqlDbType.Int32);
                        cmd.Parameters["@price"].Value = room.price;
                        cmd.Parameters.Add("@persons", MySqlDbType.Int32);
                        cmd.Parameters["@persons"].Value = room.persons;
                        cmd.ExecuteNonQuery();


                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        this.CloseConnection();
                        MessageBox.Show(ex.Message);
                        return false;
                    }

                }
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        internal Boolean deleteRoom(String numRoom2)
        {

            if (this.OpenConnection() == true)
            {
                int num2 = Int32.Parse(numRoom2);
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("SELECT DISTINCT bookings.hotel_id FROM bookings WHERE bookings.room_number =" + num2);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {
                        dataReader.Close();
                        this.CloseConnection();
                        return false;

                    }
                    dataReader.Close();
                    cmd.CommandText = ("DELETE FROM rooms WHERE rooms.number =" + num2);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        internal Boolean addHotel(DBHotels hotel)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("INSERT INTO hotels (addr_id, name, type, stars) VALUES (" +
                                        "@address_id, @name,@type,@stars);");

                    cmd.Parameters.Add("@address_id", MySqlDbType.Int32);
                    cmd.Parameters["@address_id"].Value = hotel.address_id;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = hotel.name;
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar);
                    cmd.Parameters["@type"].Value = hotel.type;
                    cmd.Parameters.Add("@stars", MySqlDbType.Int32);
                    cmd.Parameters["@stars"].Value = hotel.stars;

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        internal Boolean newHotel(DBHotels hotel, DBAddress address)
        {
            try
            {
                if (isPhoneUnique(address.phone))
                {
                    hotel.address_id = addAddress(address);
                    if (hotel.address_id != "-1")
                    {
                        if (addHotel(hotel))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                this.CloseConnection();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal Boolean updateHotel(DBHotels hotel, DBAddress address, String ad_id)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("UPDATE addresses SET phone=@phone, country=@country,city=@city," +
                        "zipcode=@zipcode,street=@street,streetNo=@streetno WHERE id=@addr_Id");
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar);
                    cmd.Parameters["@phone"].Value = address.phone;
                    cmd.Parameters.Add("@country", MySqlDbType.VarChar);
                    cmd.Parameters["@country"].Value = address.country;
                    cmd.Parameters.Add("@city", MySqlDbType.VarChar);
                    cmd.Parameters["@city"].Value = address.city;
                    cmd.Parameters.Add("@street", MySqlDbType.VarChar);
                    cmd.Parameters["@street"].Value = address.street;
                    cmd.Parameters.Add("@zipcode", MySqlDbType.VarChar);
                    cmd.Parameters["@zipcode"].Value = address.zipcode;
                    cmd.Parameters.Add("@streetno", MySqlDbType.UInt16);
                    cmd.Parameters["@streetno"].Value = address.streetno;
                    cmd.Parameters.Add("@addr_Id", MySqlDbType.Int32);
                    cmd.Parameters["@addr_Id"].Value = ad_id;
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        internal Boolean updateHotelView(DBHotels hotels)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("UPDATE updateablehotelsview SET name=@name,type=@type,stars=@stars WHERE addr_id=@addrid");
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = hotels.name;
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar);
                    cmd.Parameters["@type"].Value = hotels.type;
                    cmd.Parameters.Add("@addrid", MySqlDbType.Int32);
                    cmd.Parameters["@addrid"].Value = hotels.address_id;
                    cmd.Parameters.Add("@stars", MySqlDbType.Int32);
                    cmd.Parameters["@stars"].Value = hotels.stars;

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        internal Dictionary<String, List<String> > getHotelNames()
        {
            Dictionary<String, List<String>> list = new Dictionary<String, List<String>>();
            list["name"] = new List<String>();
            list["id"] = new List<String>();
            list["addr_id"] = new List<String>();
            list["type"] = new List<String>();
            list["stars"] = new List<String>();
            list["phone"] = new List<String>();
            list["country"] = new List<String>();
            list["city"] = new List<String>();
            list["street"] = new List<String>();
            list["zipcode"] = new List<String>();
            list["streetNo"] = new List<String>();


            if (this.OpenConnection() == true)
            {
                try
                {
                    String query = "SELECT DISTINCT hotels.id, hotels.name, hotels.addr_id, hotels.type, hotels.stars, addresses.phone, addresses.country," +
                        "addresses.city,addresses.street,addresses.zipcode,addresses.streetNo FROM hotels, addresses WHERE " +
                        " hotels.addr_id=addresses.id";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list["name"].Add(dataReader["name"].ToString());
                        list["id"].Add(dataReader["id"].ToString());
                        list["addr_id"].Add(dataReader["addr_id"].ToString());
                        list["type"].Add(dataReader["type"].ToString());
                        list["stars"].Add(dataReader["stars"].ToString());
                        list["phone"].Add(dataReader["phone"].ToString());
                        list["country"].Add(dataReader["country"].ToString());
                        list["city"].Add(dataReader["city"].ToString());
                        list["street"].Add(dataReader["street"].ToString());
                        list["zipcode"].Add(dataReader["zipcode"].ToString());
                        list["streetNo"].Add(dataReader["streetNo"].ToString());


                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return list;
                }
            }
            //return list to be displayed
            return list;
        }

        internal Dictionary<String, List<String>> getRooms(String hotelId, String from, String to, String peopleNo)
        {
            Dictionary<String, List<String>> list = new Dictionary<String, List<String> >();
            list["data"] = new List<String>();
            list["type"] = new List<String>();
            list["price"] = new List<String>();
            list["roomno"] = new List<String>();
            
                
            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("CALL getRooms(@hotelId, @from, @to, @people)");

                    cmd.Parameters.Add("@hotelId", MySqlDbType.Int32);
                    cmd.Parameters["@hotelId"].Value = hotelId;
                    cmd.Parameters.Add("@from", MySqlDbType.Date);
                    cmd.Parameters["@from"].Value = from;
                    cmd.Parameters.Add("@to", MySqlDbType.Date);
                    cmd.Parameters["@to"].Value = to;
                    cmd.Parameters.Add("@people", MySqlDbType.Int32);
                    cmd.Parameters["@people"].Value = peopleNo;

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        list["data"].Add(dataReader["AvailableNo"].ToString() + ", " + dataReader["Type"].ToString() +
                                                ", Price: " + dataReader["Price"].ToString());
                        list["type"].Add(dataReader["Type"].ToString());
                        list["price"].Add(dataReader["Price"].ToString());
                        list["roomno"].Add(dataReader["RoomNo"].ToString());
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return list;
                }  
            }
            //return list to be displayed
            return list;
        }

        internal String addAddress(DBAddress address)
        {
            String id = "-1";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("INSERT INTO addresses (phone, country, city, street, zipcode, streetNo) VALUES (" +
                                        "@phone,@country,@city,@street,@zipcode,@streetno); SELECT LAST_INSERT_ID()");

                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar);
                    cmd.Parameters["@phone"].Value = address.phone;
                    cmd.Parameters.Add("@country", MySqlDbType.VarChar);
                    cmd.Parameters["@country"].Value = address.country;
                    cmd.Parameters.Add("@city", MySqlDbType.VarChar);
                    cmd.Parameters["@city"].Value = address.city;
                    cmd.Parameters.Add("@street", MySqlDbType.VarChar);
                    cmd.Parameters["@street"].Value = address.street;
                    cmd.Parameters.Add("@zipcode", MySqlDbType.VarChar);
                    cmd.Parameters["@zipcode"].Value = address.zipcode;
                    cmd.Parameters.Add("@streetno", MySqlDbType.UInt16);
                    cmd.Parameters["@streetno"].Value = address.streetno;

                    id = cmd.ExecuteScalar().ToString();
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return id;
                }  
            }
            return id;
        }

        internal Boolean updateCustomer(DBCustomer cust, DBAddress address)
        {
            if (this.OpenConnection() == true)
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("UPDATE customers SET name=@name ,lastname=@lastname ,birthdate=@birthdate WHERE addr_id=@addressId");
                    cmd.Parameters.Add("@addressId", MySqlDbType.Int32);
                    cmd.Parameters["@addressId"].Value = cust.addressId;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = cust.name;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar);
                    cmd.Parameters["@lastname"].Value = cust.lastname;
                    cmd.Parameters.Add("@birthdate", MySqlDbType.Date);
                    cmd.Parameters["@birthdate"].Value = cust.birthdate;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = ("UPDATE addresses SET phone=@phone, country=@country,city=@city," +
                        "zipcode=@zipcode,street=@street,streetNo=@streetno WHERE id=@addr_Id");
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar);
                    cmd.Parameters["@phone"].Value = address.phone;
                    cmd.Parameters.Add("@country", MySqlDbType.VarChar);
                    cmd.Parameters["@country"].Value = address.country;
                    cmd.Parameters.Add("@city", MySqlDbType.VarChar);
                    cmd.Parameters["@city"].Value = address.city;
                    cmd.Parameters.Add("@street", MySqlDbType.VarChar);
                    cmd.Parameters["@street"].Value = address.street;
                    cmd.Parameters.Add("@zipcode", MySqlDbType.VarChar);
                    cmd.Parameters["@zipcode"].Value = address.zipcode;
                    cmd.Parameters.Add("@streetno", MySqlDbType.UInt16);
                    cmd.Parameters["@streetno"].Value = address.streetno;
                    cmd.Parameters.Add("@addr_Id", MySqlDbType.Int32);
                    cmd.Parameters["@addr_Id"].Value = cust.addressId;
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Updated!");
                    return true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        internal String addCustomer(DBCustomer customer)
        {
            String id = "-1";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = ("INSERT INTO customers (	addr_id, name, lastname, birthdate) VALUES (" +
                                        "@addressId, @name,@lastname,@birthdate); SELECT LAST_INSERT_ID()");

                    cmd.Parameters.Add("@addressId", MySqlDbType.Int32);
                    cmd.Parameters["@addressId"].Value = customer.addressId;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = customer.name;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar);
                    cmd.Parameters["@lastname"].Value = customer.lastname;
                    cmd.Parameters.Add("@birthdate", MySqlDbType.Date);
                    cmd.Parameters["@birthdate"].Value = customer.birthdate;

                    id = cmd.ExecuteScalar().ToString();
                    this.CloseConnection();        
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return id;
                }  
            }
            return id;
        }

        internal void addEmail(DBEmail email)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    foreach (String em in email.emails)
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = ("INSERT INTO emails (email,cust_id) VALUES (@email,@custId)");

                        cmd.Parameters.Add("@email", MySqlDbType.VarChar);
                        cmd.Parameters["@email"].Value = em;
                        cmd.Parameters.Add("@custId", MySqlDbType.Int32);
                        cmd.Parameters["@custId"].Value = email.customerId;
                        cmd.ExecuteNonQuery();
                    }
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                }  
            }
        }

        internal void newCustomer(DBCustomer customer, DBAddress address, DBEmail email)
        {
            try
            {
                if (isPhoneUnique(address.phone))
                {
                    if (isEmailUnique(email.emails))
                    {
                        customer.addressId = addAddress(address);
                        if (customer.addressId != "-1")
                        {
                            email.customerId = addCustomer(customer);
                            if (email.customerId != "-1")
                            {
                                addEmail(email);
                                MessageBox.Show("New Customer Added");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email is not unique.");
                    }
                }
                else
                {
                    MessageBox.Show("Phone is not unique.");
                }
                
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                this.CloseConnection();
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Data);
            }
        }

        //Insert statement
        internal void Insert()
        {
            string query = "INSERT INTO test (user, pass) VALUES('Joe', 'Joe2')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        internal void Update()
        {
            string query = "UPDATE test SET user='joe', pass='joe2' WHERE user='Joe'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        internal void Delete()
        {
            string query = "DELETE FROM test WHERE user='sheva'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        internal DataTable Select()
        {
            DataTable list = new DataTable();
            
            try
            {
                 string query = "SELECT * FROM customersview";

                //Create a list to store the result
            
                //list[0] = new List<string>();
                //list[1] = new List<string>();
                //list[2] = new List<string>();
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    //MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter myDA = new MySqlDataAdapter(query, connection);
                    MySqlCommandBuilder cmb = new MySqlCommandBuilder(myDA);
                    //Create a data reader and Execute the command
                    //MySqlDataReader dataReader = cmd.ExecuteReader();
                    myDA.Fill(list);
                    //Read the data and store them in the list
                    /* while (dataReader.Read())
                    {
                        MessageBox.Show(dataReader["id"].ToString());
                        MessageBox.Show(dataReader["user"].ToString());
                        MessageBox.Show(dataReader["pass"].ToString());
                        //list.Add(new StringValue(dataReader["id"].ToString()));
                        //list.Add(new StringValue(dataReader["user"].ToString()));
                        //list.Add(new StringValue(dataReader["pass"].ToString()));
                    }
                    */

                    //close Data Reader
                    //dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    
                }
                //return list to be displayed
                return list;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }           
        }

        //Count statement
        internal int Count()
        {
            string query = "SELECT Count(*) FROM test";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        internal void Backup()
        {
        }

        //Restore
        internal void Restore()
        {
        }
    }
}
