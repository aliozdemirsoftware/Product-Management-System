using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_NTierDesign.TypeLayer
{
    public class Common_Messages
    {
        public static string Dont_Choose_From_List = "Listeden seçim yapmadınız";

        public static string Info = "0544 582 35 39 Ali Özdemir ";

        public static string Find_TableName(string TableName)
        {
            string answer = "";

            for (int i = 0; i < TableName.Length; i++)
            {
                answer += TableName[i];

                if (TableName[i] == ' ') break;
            }
            return answer;
        }

        public static string CRUD_Message(string TableName, bool successOrFailure, string crudType)
        {
            string messages = "";

            if (successOrFailure)
            {
                if (crudType == CrudTypes.Insert)
                {
                    messages = $"{TableName} başarıyla eklendi";
                }
                else if (crudType == CrudTypes.Update)
                {
                    messages = $"{TableName} başarıyla güncellendi";
                }
                else if (crudType == CrudTypes.Delete)
                {
                    messages = $"{TableName} başarıyla silindi";
                }
            }
            else
            {
                if (crudType == CrudTypes.Insert)
                {
                    messages = $"{TableName} eklenirken hata oluştu";
                }
                else if (crudType == CrudTypes.Update)
                {
                    messages = $"{TableName} güncellenirken hata oluştu";
                }
                else if (crudType == CrudTypes.Delete)
                {
                    messages = $"{TableName} silinirken hata oluştu";
                }
            }
            return messages.ToUpper();
        }
    }
}
