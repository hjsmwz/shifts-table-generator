using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSM
{
    class Constants
    {

        private static Constants constant = null;
        
        private Constants()
        {
            // Apply SingleTone design pattern
        }

        public static Constants getInstance()
        {
            if (constant == null) {
                constant = new Constants();
            }

            return constant;
        }




        /*
          TODO : take from user 
         * 1- month
         * 2- dofa1, dofa2, dofa3, dofa4 and special vacations
         * 3- 
         
         
         
         */

        /* dates */
        public static List<DateTime> days = Config.GetDates(2019,6).ToList();

        /* services type */
        //public static int NO_SERVICES = 0;
        public static int SPECIAL_SERVICES = 0;
        public static int FULL_SERVICES = 1;

        /* services counts */
        public static int SERVICES_PER_DAY = 9;
        public static int SERVICES_PER_MONTH = days.Count * SERVICES_PER_DAY;

        /* vacations cases */
        public static int dofa_case = 0;
        public static int rhat_case_1 = 1;
        public static int rhat_case_2 = 2;
        public static int mbet_case = 3;

        /* special vacations */
        public static int[] dofa_1_days_vac_list = { 1,2,3,4,16,17,18,19,20,21,22};
        public static int[] dofa_1_days_vac_list1 = { 5,6,7,8,16,17,18,19,20,21,22};
        public static int[] dofa_2_days_vac_list = { 1,2,3,4,23,24,25,26,27,28,29};
        public static int[] dofa_3_days_vac_list = {5,6,7,8,9,10,11,12,13,14,15,30};
        //public static int[] dofa_4_days_vac_list = { 18, 19, 20, 21, 22, 23, 24 };
        public static int[] special_days_vac_list = { 3,4,5,6,7};

        public static List<DateTime> rhat_vac_1 = days.Where(date => date.DayOfWeek.ToString() == "Wednesday" || date.DayOfWeek.ToString() == "Thursday" || date.DayOfWeek.ToString() == "Friday" || Constants.special_days_vac_list.Contains((int)date.Day)).ToList();
        public static List<DateTime> rhat_vac_2 = days.Where(date => date.DayOfWeek.ToString() == "Thursday" || date.DayOfWeek.ToString() == "Friday" || date.DayOfWeek.ToString() == "Saturday" || Constants.special_days_vac_list.Contains((int)date.Day)).ToList();
        public static List<DateTime> rhat_vac_combine = days.Where(date => date.DayOfWeek.ToString() == "Wednesday" || date.DayOfWeek.ToString() == "Thursday" || date.DayOfWeek.ToString() == "Friday" || date.DayOfWeek.ToString() == "Saturday" || Constants.special_days_vac_list.Contains((int)date.Day)).ToList();
        public static List<DateTime> mbet_vac_1 = days.Where(date => date.DayOfWeek.ToString() == "Thursday" || date.DayOfWeek.ToString() == "Friday" || Constants.special_days_vac_list.Contains((int)date.Day)).ToList();

        //public List<DateTime> dofa1_vac;
        //public List<DateTime> dofa2_vac;
        //public List<DateTime> dofa3_vac;
        public static List<DateTime> dofa1_vac1 = days.Where(date => Constants.dofa_1_days_vac_list1.Contains((int)date.Day)).ToList();
        public static List<DateTime> dofa1_vac = days.Where(date => Constants.dofa_1_days_vac_list.Contains((int)date.Day)).ToList();
        public static List<DateTime> dofa2_vac = days.Where(date => Constants.dofa_2_days_vac_list.Contains((int) date.Day)).ToList();
        public static List<DateTime> dofa3_vac = days.Where(date => Constants.dofa_3_days_vac_list.Contains((int) date.Day)).ToList();
        // public static List<DateTime> dofa4_vac = days.Where(date => Constants.dofa_4_days_vac_list.Contains((int) date.Day)).ToList();

        



        //public static List<DateTime> special_vac_dates_per_month = days.Where(date => Constants.special_days_vac_list.Contains((int)date.DayOfWeek)).ToList();

        public static String[] en_week_days = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        public static String[] ar_week_days = { "السبت", "الاحد", "الاثنين", "الثلاثاء", "الاريعاء", "الخميس", "الجمعه" };
        public static Dictionary<String, String> translated_days = en_week_days.Zip(ar_week_days, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);

    }
}
