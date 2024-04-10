

using CrudUsingADO.Models;
using System.Data;
using System.Data.SqlClient;

namespace CrudUsingADO.Service
{ 

    public class EmpDAL
    {
        private SqlConnection _connection;

        public EmpDAL()
        {
            String EmpConStr = "Server=LAPTOP-3KHIIDIU\\SQLEXPRESS;Database=ADOCRUD_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            _connection = new SqlConnection(EmpConStr);

        }
        public List<EmployeeModel> GetEmployeeDetails()
        {
            List<EmployeeModel> employeelsList = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("GetEmployeeDetails", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter Adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            Adp.Fill(dt); 
            

            foreach (DataRow dr in dt.Rows)
            {
                employeelsList.Add(

                    new EmployeeModel
                    {
                        Employee_Code = Convert.ToInt32(dr["Employee_Code"]),
                        Employee_Name = Convert.ToString(dr["Employee_Name"]),                     
                        Address = Convert.ToString(dr["Address"]),
                        Country= Convert.ToString(dr["Country"]),
                        State= Convert.ToString(dr["State"]),  
                        City= Convert.ToString(dr["City"]),
                        Project_Assigned = Convert.ToString(dr["Project_Assigned"]),


                    });

            }
            return employeelsList;

        }


        public bool InsertEmployee(EmployeeModel InstEmp)

        {

           

            SqlCommand cmd = new SqlCommand("InsertEmployee", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            

            cmd.Parameters.AddWithValue("@Employee_Code", InstEmp.Employee_Code);
            cmd.Parameters.AddWithValue("@Employee_Name", InstEmp.Employee_Name);
            cmd.Parameters.AddWithValue("@Address", InstEmp.Address);
            cmd.Parameters.AddWithValue("@Country", InstEmp.Country);
            cmd.Parameters.AddWithValue("@State", InstEmp.State);
            cmd.Parameters.AddWithValue("@City", InstEmp.City);
            cmd.Parameters.AddWithValue("@Project_Assigned", InstEmp.Project_Assigned);

            _connection.Open();
            
            int i = cmd.ExecuteNonQuery();
          
            _connection.Close();

            if (i >= 0)
            {
               
                return true;    
            }else
            {
              
                return false;   

            }

        }



        public EmployeeModel GetEmployeeById(int id2)
        {
            EmployeeModel employeelsList = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("GetEmployeeById", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param;
            cmd.Parameters.Add(new SqlParameter("@Employee_Code", id2));

            
            SqlDataAdapter Adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            Adp.Fill(dt);

            
            foreach (DataRow dr in dt.Rows)
            {
                employeelsList = new EmployeeModel

                {

                     
                        Employee_Code = Convert.ToInt32(dr["Employee_Code"]),
                        Employee_Name = Convert.ToString(dr["Employee_Name"]),
                        Address = Convert.ToString(dr["Address"]),
                        Country = Convert.ToString(dr["Country"]),
                        State = Convert.ToString(dr["State"]),
                        City = Convert.ToString(dr["City"]),
                        Project_Assigned = Convert.ToString(dr["Project_Assigned"]),


                    };

            }
            return employeelsList;

        }



        public bool EditEmployeeDetailsDAL(int id,EmployeeModel EdtEmp)

        {
           SqlCommand cmd = new SqlCommand("UpdateEmployee", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@Employee_Code", id);

            cmd.Parameters.AddWithValue("@Employee_Name", EdtEmp.Employee_Name);
            cmd.Parameters.AddWithValue("@Address", EdtEmp.Address);
            cmd.Parameters.AddWithValue("@Country", EdtEmp.Country);
            cmd.Parameters.AddWithValue("@State", EdtEmp.State);
            cmd.Parameters.AddWithValue("@City", EdtEmp.City);
            cmd.Parameters.AddWithValue("@Project_Assigned", EdtEmp.Project_Assigned);

            _connection.Open();

            int i = cmd.ExecuteNonQuery();

            _connection.Close();

            if (i >= 0)
            {

                return true;
            }
            else
            {

                return false;

            }

        }



        public EmployeeModel DeleteEmployee(int id2)
        {
            EmployeeModel employeelsList = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("GetEmployeeById", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param;
            cmd.Parameters.Add(new SqlParameter("@Employee_Code", id2));


            SqlDataAdapter Adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            Adp.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                employeelsList = new EmployeeModel

                {
                    Employee_Code = Convert.ToInt32(dr["Employee_Code"]),
                    Employee_Name = Convert.ToString(dr["Employee_Name"]),
                    Address = Convert.ToString(dr["Address"]),
                    Country = Convert.ToString(dr["Country"]),
                    State = Convert.ToString(dr["State"]),
                    City = Convert.ToString(dr["City"]),
                    Project_Assigned = Convert.ToString(dr["Project_Assigned"]),


                };

            }
            return employeelsList;

        }



        public bool DeleteEmployeeDetailsDAL(int id)

        {
            SqlCommand cmd = new SqlCommand("DeleteEmployee", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@Employee_Code", id);

           
            _connection.Open();

            int i = cmd.ExecuteNonQuery();

            _connection.Close();

            if (i >= 0)
            {

                return true;
            }
            else
            {

                return false;

            }

        }


        public EmployeeModel DetailsOfEmployee(int id2)
        {
            EmployeeModel employeelsList = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("GetEmployeeById", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param;
            cmd.Parameters.Add(new SqlParameter("@Employee_Code", id2));


            SqlDataAdapter Adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            Adp.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                employeelsList = new EmployeeModel

                {
                    Employee_Code = Convert.ToInt32(dr["Employee_Code"]),
                    Employee_Name = Convert.ToString(dr["Employee_Name"]),
                    Address = Convert.ToString(dr["Address"]),
                    Country = Convert.ToString(dr["Country"]),
                    State = Convert.ToString(dr["State"]),
                    City = Convert.ToString(dr["City"]),
                    Project_Assigned = Convert.ToString(dr["Project_Assigned"]),


                };

            }
            return employeelsList;

        }




    }
}
