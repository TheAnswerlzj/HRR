using IDAO;
using MVC_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace DAO
{
    public class config_file_second_kindDAO : Daobase<config_file_second_kind>, config_file_second_kindIDAO
    {
        public int Add(config_file_second_kindModel item)
        {
            config_file_second_kind ko = new config_file_second_kind(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.second_salary_id = item.second_salary_id;  
                    ko.second_sale_id = item.second_sale_id; return  Add(ko);
        }

        public List<config_file_second_kindModel> select()
        {
            List<config_file_second_kind> list = SelectAll();
            List<config_file_second_kindModel> li = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel ko = new config_file_second_kindModel();  
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.second_salary_id = item.second_salary_id;  
                    ko.second_sale_id = item.second_sale_id;  li.Add(ko);
            }
            return li;
        }

        public int update(config_file_second_kindModel item)
        {
            config_file_second_kind ko = new config_file_second_kind(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.second_salary_id = item.second_salary_id;  
                    ko.second_sale_id = item.second_sale_id;   return ModifyWithOutproNames(ko);
            }
        public List<config_file_second_kindModel> selectupdate(int id)
        {
            List<config_file_second_kind> list = SeleteBy(e => e.Id == id);


            List<config_file_second_kindModel> li = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel ko = new config_file_second_kindModel(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.second_salary_id = item.second_salary_id;  
                    ko.second_sale_id = item.second_sale_id;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            config_file_second_kind us = new config_file_second_kind();
            //����ǰ̨����id����idƥ��
            us.Id = id;
            //��ʼɾ��
            db.Entry(us).State = EntityState.Deleted;
            //����            
            return db.SaveChanges();


            // int pd = Del(e => e.id == id);
            // return pd;
        }
        private static MyDbContext CreateDbContext()
        {

            //�ӵ�ǰ������߳�ȡֵ
            db = CallContext.GetData("s") as MyDbContext;
            if (db == null)
            {
                db = new MyDbContext();
                //�������Ķ�����뵱ǰ������߳���
                CallContext.SetData("s", db);
            }
            return db;
        }

        public List<config_file_second_kindModel> selectxlk(string id)
        {
            List<config_file_second_kind> list = SeleteBy(e => e.first_kind_id == id);
            List<config_file_second_kindModel> li = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel ko = new config_file_second_kindModel();
                ko.Id = item.Id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.second_salary_id = item.second_salary_id;
                ko.second_sale_id = item.second_sale_id; li.Add(ko);
            }
            return li;

        }
    }
}
