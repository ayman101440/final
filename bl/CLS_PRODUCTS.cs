using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_PRODUCTS
    {

        public DataTable GET_ALL_CATEGORIES()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            
            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_CATEGORIES", null);
            dal.close();
            return Dt;


        }

       
        public void ADD_PRODUCT(int id_cat, string label_product, string id_product,
                                    int Qte, string price, byte[] img)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0]=new SqlParameter("@id_cat",SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar,30);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@label", SqlDbType.VarChar, 30);
            param[2].Value = label_product;

            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = Qte;


            param[4] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[4].Value =price;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;
            dal.ExecuteCommand("ADD_PRODUCR", param);



            dal.close();
        }
        public DataTable verifyproductid(string id)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id; 
            Dt = dal.SelectData("verifyproductid", param);
            dal.close();
            return Dt;


        }

        public DataTable GET_ALL_PRODUCTS()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_PRODUCTS", null);
            dal.close();
            return Dt;


        }

        public DataTable searchProduct(string id)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            Dt = dal.SelectData("searchProduct", param);
            dal.close();
            return Dt;


        }

        public DataTable searchProductname(string id)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            Dt = dal.SelectData("searchProductname", param);
            dal.close();
            return Dt;


        }

        public void deleteproduct(string id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;


            dal.ExecuteCommand("deleteproduct", param);



            dal.close();
        }
        public DataTable GET_IMAGE_PRODUCT(string id)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            Dt = dal.SelectData("GET_IMAGE_PRODUCT", param);
            dal.close();
            return Dt;


        }
        public void UPDATE_PRODUCT(int id_cat, string label_product, string id_product,
                                   int Qte, string price, byte[] img)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@label", SqlDbType.VarChar, 30);
            param[2].Value = label_product;

            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = Qte;


            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[4].Value = price;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;
            dal.ExecuteCommand("UPDATE_PRODUCT", param);



            dal.close();
            //this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }
    }
}
