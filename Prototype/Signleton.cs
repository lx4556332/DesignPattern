using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Signleton
    {
        private static volatile Signleton instance = null;

        private static object lockHelper = new Object();

        private Signleton() { }

        /// <summary>
        /// 获取单例对象
        /// </summary>
        /// <returns></returns>
        public static Signleton GetInstance()
        {
            if (instance == null)
            {
                lock (lockHelper)
                {
                    if (instance == null)
                    {
                        instance = new Signleton();
                    }
                }
            }
            return instance;
        }

        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        public  DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}
