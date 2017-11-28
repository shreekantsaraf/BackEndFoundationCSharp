using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
namespace DataSource
{
    public class Items 
    {
        public List<Item> cs;
        public Items()
        {
            cs = new List<Item>();
            for (int i=0; i<100; i++)
            {
                cs.Add(new Item{Id=i, title="title"+i.ToString(), user="Rim Zim"});
            }
        }
        public List<Item>  getAll()
        {
            return cs;
        }
    }
}