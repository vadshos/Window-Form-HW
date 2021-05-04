using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.FileIOServices
{
    
        static class FileIOService
        {
            static public BindingList<ProductModel> LoadData(string PATH)
            {
                var fileExist = File.Exists(PATH);
                if (!fileExist)
                {
                    File.CreateText(PATH).Dispose();
                    return new BindingList<ProductModel>();
                }
                using (var reader = File.OpenText(PATH))
                {
                    var fileText = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<BindingList<ProductModel>>(fileText);
                }
            }

            static public void SaveData(object todoDataList, string PATH)
            {
                File.Delete(PATH);
                using (StreamWriter writer = File.CreateText(PATH))
                {
                    string output = JsonConvert.SerializeObject(todoDataList);
                    writer.Write(output);
                }
            }
        }
    
}
