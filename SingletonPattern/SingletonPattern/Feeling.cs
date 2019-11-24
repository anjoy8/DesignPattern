using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 定义一个心情类
    /// </summary>
    public class Feeling
    {
        public Feeling()
        {
            Date = DateTime.Now;
        }
        public DateTime Date { get; set; }
    }
}
