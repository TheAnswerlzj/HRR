using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class RoleManagerModel
    {   
        public System.Int32 RoleID { get; set; }


        [Required(ErrorMessage = "��ɫ���Ʋ���Ϊ��")]
        public System.String RoleName { get; set; }
        [Required(ErrorMessage = "��ɫ˵������Ϊ��")]
        public System.String RoleState { get; set; }

        [Required(ErrorMessage = "��ѡ���Ƿ�")]
        public System.String RoleOk { get; set; }

                     } }
