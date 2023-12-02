using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwglqProMax_Frontend
{
    class Configration
    {
        // 服务器的根地址
        public static string BASICURL = "http://127.0.0.1:8000/api";
        // public static string BASICURL = "http://43.138.46.106:8000/jwapi";
        // public static string BASICURL = "http://jwglq.wobushidalao.top/jwapi";

        public static string Cookie = "Hm_lvt_13b40e489bb711d52e8face65ffaa168=1675647385; __root_domain_v=.ustb.edu.cn; _qddaz=QD.666475647416795; JSESSIONID=B28EA50E95FFD39FAC710B82D6BE8652; SERVERID=125";
        public static string Name = "";
        public static string LogFilePath = "cookies.txt";
        public static string jx0502zbid = "";
        public static string Token = "";
        // 当前的软件版本
        public static string version = "2.0.0";
        // 抢课时间间隔
        public static int interval = 1000;
        // 超时时间
        public static int TIMEOUT = 5000;
        // 是否等待上一次结束
        public static bool waitingtStop = true;
        // 是否已经登录
        public static bool Logined = false;
        // 教务系统的sis认证地址
        public static string JwSisBaseUrl = "https://sis.ustb.edu.cn";
    }
}
