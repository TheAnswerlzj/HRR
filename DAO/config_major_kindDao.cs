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
    public class config_major_kindDAO : Daobase<config_major_kind>, config_major_kindIDAO
    {
        public int Add(config_major_kindModel1 item)
        {
            config_major_kind ko = new config_major_kind(); 
                    ko.id = item.mfk_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name; return  Add(ko);
        }

        public List<config_major_kindModel1> select()
        {
            List<config_major_kind> list = SelectAll();
            List<config_major_kindModel1> li = new List<config_major_kindModel1>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel1 ko = new config_major_kindModel1();  
                    ko.mfk_id = item.id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  li.Add(ko);
            }
            return li;
        }

        public int update(config_major_kindModel1 item)
        {
            config_major_kind ko = new config_major_kind(); 
                    ko.id = item.mfk_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;   return ModifyWithOutproNames(ko);
            }
        public List<config_major_kindModel1> selectupdate(string id)
        {
           
            List<config_major_kind> list = SeleteBy(e => e.major_kind_id.Equals(id));


            List<config_major_kindModel1> li = new List<config_major_kindModel1>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel1 ko = new config_major_kindModel1(); 
                    ko.mfk_id = item.id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            config_major_kind us = new config_major_kind();
            //����ǰ̨����id����idƥ��
            us.id = id;
            //��ʼɾ��
            db.Entry<config_major_kind>(us).State = EntityState.Deleted;
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

        
    }
}
