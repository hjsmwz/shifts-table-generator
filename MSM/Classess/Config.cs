using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace MSM
{
    class Config
    {
        public static List<DateTime> GetDates(int year, int month)
        {
            var dates = new List<DateTime>();

            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            return dates;
        }


        public static List<Soldier> AddServicesCountForSoldiers(List<Soldier> soldiers, int available_services)
        {

            while (available_services >= 1)
            {
                foreach (Soldier soldier in soldiers)
                {
                    if (soldier.Soldier_case == Constants.FULL_SERVICES)
                    {
                        if (available_services >= 1)
                        {
                            soldier.Services_count++;
                            available_services--;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }


            /*
            int available_soldiers_count = soldiers.Where(item => item.Soldier_case == Constants.FULL_SERVICES).Count();
            int min_services = available_services / available_soldiers_count;

            //var query = soldiers.Select(x => { x.Services_count = min_services; return x; });
            soldiers.Where(item => item.Soldier_case == Constants.FULL_SERVICES).ToList().ForEach(item => item.Services_count = min_services);

            int remaining_services = Constants.SERVICES_PER_MONTH - (min_services * available_soldiers_count);

            while (remaining_services >= 1)
            {
                foreach (Soldier soldier in soldiers)
                {
                    if (remaining_services >= 1)
                    {
                        if (soldier.Soldier_case == Constants.FULL_SERVICES)
                        {
                            soldier.Services_count++;
                            remaining_services--;
                        }
                    }
                    else break;
                }
            }

            */
            return soldiers;
        }


        public static Random rand = new Random(DateTime.Now.Second);

        /*
        public static string GenerateName()
        {
            
            string[] maleNames = { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian" };
            string[] femaleNames = { "abby", "abigail", "adele", "adrian" };
            string[] lastNames = { "abbott", "acosta", "adams", "adkins", "aguilar" };
            string FirstName = "";
            //Random rand = new Random(DateTime.Now.Second);
            if (rand.Next(1, 2) == 1)
            {
                FirstName = maleNames[rand.Next(0, maleNames.Length - 1)];
            }
            else
            {
                FirstName = femaleNames[rand.Next(0, femaleNames.Length - 1)];
            }

            return FirstName + " " + lastNames[rand.Next(0, lastNames.Length - 1)];

        }

        public static string GeneratePosition()
        {
            string[] positions = { "nozom", "keyada", "estalam", "sarya", "batna", "dawry", "saf dawry", "legan", "saf legan", "toan", "sonar" };
          
         
            return positions[rand.Next(0, positions.Length - 1)];

        }
        */



        //Phase 1 from 3
        // set dofa soldiers to vacations days
        public static Dictionary<List<Soldier>, Dictionary<DateTime, int>> SetVacationsServices(List<Soldier> soldiers, List<DateTime> days)
        {
            Dictionary<DateTime, int> days_dic = days.ToDictionary(v => v, v => 0);
            foreach (Soldier soldier in soldiers)
            {
                if (soldier.Vac_type == Constants.dofa_case && soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (!soldier.Vacations.Contains(date.Date)
                            && Constants.mbet_vac_1.Contains(date)
                            && days_dic[date] < Constants.SERVICES_PER_DAY
                            && !soldier.Services.Contains(date)
                            && soldier.haveAvailableServices())
                        {
                            soldier.Services.Add(date);
                            soldier.Services_count--;
                            days_dic[date] += 1;
                            //break;
                        }

                    }
                }
            }
            // set mabet soldiers to vacations days
            Dictionary<DateTime, int> remaining_vacations = (days_dic.Where(date => date.Value < Constants.SERVICES_PER_DAY && Constants.mbet_vac_1.Contains(date.Key))).ToDictionary(x => x.Key, x => x.Value);
            if (remaining_vacations.Count > 0)
            {
                foreach (Soldier soldier in soldiers)
                {
                    if (soldier.Vac_type == Constants.mbet_case && soldier.haveAvailableServices())
                    {
                        foreach (DateTime date in days_dic.Keys.ToList())
                        {
                            if (Constants.mbet_vac_1.Contains(date) && days_dic[date] < Constants.SERVICES_PER_DAY && !soldier.Services.Contains(date) && soldier.haveAvailableServices())
                            {
                                soldier.Services.Add(date);
                                soldier.Services_count--;
                                days_dic[date] += 1;
                                // break;
                            }
                        }
                    }
                }
            }
            // set rhat soldiers to vacations days
            // mabet hena may take 5mes m3 eno moken ya5od sabt 3ady :D :D :D postponed case
            // nfs el kalam m3 el rhat mmokn ya5od sabt m3 eno mmoken ya5od arb3 m3 el 3lm eno 5mes gomaa sabt heya agzto
           
            remaining_vacations = (days_dic.Where(date => date.Value < Constants.SERVICES_PER_DAY && Constants.mbet_vac_1.Contains(date.Key))).ToDictionary(x => x.Key, x => x.Value);
            if (remaining_vacations.Count > 0)
            {
                foreach (Soldier soldier in soldiers)
                {
                    if ((soldier.Vac_type == Constants.rhat_case_1 || soldier.Vac_type == Constants.rhat_case_2) && soldier.haveAvailableServices())
                    {
                        foreach (KeyValuePair<DateTime, int> date in days_dic)
                        {
                            if (Constants.rhat_vac_combine.Contains(date.Key) && date.Value < Constants.SERVICES_PER_DAY && !soldier.Services.Contains(date.Key) && soldier.haveAvailableServices())
                            {
                                soldier.Services.Add(date.Key);
                                soldier.Services_count--;
                                days_dic[date.Key] += 1;
                                //break;
                            }
                        }
                    }
                }
            }



            // no before and after technique for mabet and rhat first to avoid vacation days

            foreach (Soldier soldier in soldiers.Where(soldier => soldier.Soldier_case == Constants.mbet_case || soldier.Soldier_case == Constants.rhat_case_1 || soldier.Soldier_case == Constants.rhat_case_2))
            {
                if (soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (days_dic[date] < Constants.SERVICES_PER_DAY)
                        {
                            if (soldier.haveAvailableServices())
                            {
                                //don't have before or after
                                DateTime nextDate = new DateTime(20200);
                                DateTime previousDate = new DateTime(20200);
                                List<DateTime> dTemp = days_dic.Keys.ToList();




                                if (dTemp.IndexOf(date) + 1 < dTemp.Count)
                                {
                                    nextDate = dTemp[dTemp.IndexOf(date) + 1];
                                }

                                if (dTemp.IndexOf(date) - 1 >= 0)
                                {
                                    previousDate = dTemp[dTemp.IndexOf(date) - 1];
                                }

                                if (!soldier.Services.Contains(previousDate) && !soldier.Services.Contains(nextDate) && !soldier.Services.Contains(date) && !soldier.Vacations.Contains(date))
                                {
                                    soldier.Services.Add(date);
                                    soldier.Services_count--;
                                    days_dic[date] += 1;
                                }
                            }

                        }
                    }
                }
            }

            // add the remaining services for rhat even el 5damat wra b3d to avoid services in vacations days 
            foreach (Soldier soldier in soldiers.Where(soldier => soldier.Soldier_case == Constants.rhat_case_1
                                                                  || soldier.Soldier_case == Constants.rhat_case_2))
            {
                if (soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (days_dic[date] < Constants.SERVICES_PER_DAY && !soldier.Services.Contains(date) && !soldier.Vacations.Contains(date) && soldier.haveAvailableServices())
                        {
                            soldier.Services.Add(date);
                            soldier.Services_count--;
                            days_dic[date] += 1;
                        }
                    }
                }
            }


            // no before and after technique for dofa

            foreach (Soldier soldier in soldiers.Where(soldier => soldier.Soldier_case == Constants.dofa_case))
            {
                if (soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (days_dic[date] < Constants.SERVICES_PER_DAY)
                        {
                            if (soldier.haveAvailableServices())
                            {
                                //don't have before or after
                                DateTime nextDate = new DateTime(20200);
                                DateTime previousDate = new DateTime(20200);
                                List<DateTime> dTemp = days_dic.Keys.ToList();





                                if (dTemp.IndexOf(date) + 1 < dTemp.Count)
                                {
                                    nextDate = dTemp[dTemp.IndexOf(date) + 1];
                                }

                                if (dTemp.IndexOf(date) - 1 >= 0)
                                {
                                    previousDate = dTemp[dTemp.IndexOf(date) - 1];
                                }

                                if (!soldier.Services.Contains(previousDate) && !soldier.Services.Contains(nextDate) && !soldier.Services.Contains(date) && !soldier.Vacations.Contains(date))
                                {
                                    soldier.Services.Add(date);
                                    soldier.Services_count--;
                                    days_dic[date] += 1;
                                }
                            }

                        }
                    }
                }
            }



            // add the remaining services for mbet  first
            foreach (Soldier soldier in soldiers.Where(soldier => soldier.Soldier_case == Constants.mbet_case))
            {
                if (soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (days_dic[date] < Constants.SERVICES_PER_DAY && !soldier.Services.Contains(date) && soldier.haveAvailableServices())
                        {
                            soldier.Services.Add(date);
                            soldier.Services_count--;
                            days_dic[date] += 1;
                        }
                    }
                }
            }



            // add the remaining services for rhat
            foreach (Soldier soldier in soldiers.Where(soldier => soldier.Soldier_case == Constants.rhat_case_1
                                                                  || soldier.Soldier_case == Constants.rhat_case_2))
            {
                if (soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (days_dic[date] < Constants.SERVICES_PER_DAY && !soldier.Services.Contains(date) && soldier.haveAvailableServices())
                        {
                            soldier.Services.Add(date);
                            soldier.Services_count--;
                            days_dic[date] += 1;
                        }
                    }
                }
            }



            // add the remaining services for dofa
            foreach (Soldier soldier in soldiers.Where(soldier => soldier.Soldier_case == Constants.dofa_case))
            {
                if (soldier.haveAvailableServices())
                {
                    foreach (DateTime date in days_dic.Keys.ToList())
                    {
                        if (days_dic[date] < Constants.SERVICES_PER_DAY && !soldier.Services.Contains(date) && soldier.haveAvailableServices())
                        {
                            soldier.Services.Add(date);
                            soldier.Services_count--;
                            days_dic[date] += 1;
                        }
                    }
                }
            }





            foreach (DateTime date in days_dic.Keys.ToList().Where(date => days_dic[date] < Constants.SERVICES_PER_DAY))
            {
                while (days_dic[date] < Constants.SERVICES_PER_DAY)
                {
                    remaining_vacations = days_dic.Where(d => d.Value < Constants.SERVICES_PER_DAY).ToDictionary(x => x.Key, x => x.Value);
                    List<Soldier> ss = soldiers.Where(s => s.haveAvailableServices()).ToList();
                    if (ss.Count() == 0 && remaining_vacations.Keys.Count() < Constants.SERVICES_PER_DAY) break;
                    //MessageBox.Show(ss.Count().ToString());
                    foreach (Soldier soldier in soldiers.Where(soldier => soldier.haveAvailableServices() && soldier.Services.Contains(date)))
                    {

                        //date is not full
                        //soldier is not full
                        //soldier have a service in this day and cannot take another one 

                        //TODO: find another avaliable soldier and swap another service of the soldier

                        foreach (Soldier sold in soldiers.Where(sold => sold != soldier))
                        {
                            if (soldier.haveAvailableServices() && days_dic[date] < Constants.SERVICES_PER_DAY)
                            {
                                foreach (DateTime day in sold.Services.ToList())
                                {
                                    if (!soldier.Vacations.Contains(day) && !soldier.Services.Contains(day) && !sold.Vacations.Contains(date) && !sold.Services.Contains(date) && soldier.haveAvailableServices() && days_dic[date] < Constants.SERVICES_PER_DAY)
                                    {
                                        //change service for sold and give another service for soldier 
                                        soldier.Services.Add(day);
                                        sold.Services.Remove(day);
                                        sold.Services.Add(date);
                                        soldier.Services_count--;
                                        days_dic[date] += 1;

                                    }
                                }
                            }
                        }
                    }
                }
            }





            //remaining_vacations = days_dic.Where(date => date.Value < Constants.SERVICES_PER_DAY).ToDictionary(x => x.Key, x => x.Value);
            //MessageBox.Show(remaining_vacations.Keys.Count().ToString());
            //MessageBox.Show(remaining_vacations.First().Key.Day.ToString());


            Dictionary<List<Soldier>, Dictionary<DateTime, int>> final_dic = new Dictionary<List<Soldier>, Dictionary<DateTime, int>>();
            final_dic.Add(soldiers, days_dic);
            return final_dic;




        }

        public static void renderTable(Dictionary<List<Soldier>, Dictionary<DateTime, int>> final_dic)
        {
            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.

            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            excelApp.DefaultSheetDirection = (int)Excel.Constants.xlRTL; //or xlRTL
            workSheet.DisplayRightToLeft = true;
            List<DateTime> dates = (final_dic.First().Value).Keys.ToList();
            List<Soldier> soldiers = (final_dic.First().Key).ToList();

            workSheet.Cells[2, 1] = "الاسم";
            workSheet.Cells[2, 2] = "المكتب";

            Range cr0 = (Range)workSheet.Cells[2, 1];
            cr0.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            cr0 = (Range)workSheet.Cells[2, 2];
            cr0.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            var column = 3;
            foreach (var day in dates)
            {

                workSheet.Cells[1, column] = Constants.translated_days[day.DayOfWeek.ToString()];
                workSheet.Cells[2, column] = day.Day;

                // rotate the days names
                Range cellRange = (Range)workSheet.Cells[1, column];
                cellRange.Orientation = 90;

                workSheet.Columns[column].AutoFit();
                column++;
            }
            workSheet.Cells[2, column] = "المجموع";
            workSheet.Columns[column].AutoFit();

            var row = 3;

            foreach (var soldier in soldiers)
            {
                column = 3;

                workSheet.Cells[row, "A"] = soldier.Name;
                workSheet.Cells[row, "B"] = soldier.Position;

                workSheet.Columns["A"].AutoFit();
                workSheet.Columns["B"].AutoFit();
                Range cr1 = (Range)workSheet.Cells[row, "A"];
                cr1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                cr1 = (Range)workSheet.Cells[row, "B"];
                cr1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int i = 0; i < dates.Count; i++)
                {
                    if (soldier.Services.Contains(dates[i]))
                    {
                        workSheet.Cells[row, column + i] = "خ";
                        Range cellRange = (Range)workSheet.Cells[row, column + i];
                        cellRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }

                    if (soldier.Vacations.Contains(dates[i]))
                    {
                        Range cellRange = (Range)workSheet.Cells[row, column + i];
                        cellRange.Interior.Color = ConvertColour(Color.Gray);
                    }
                }
                workSheet.Cells[row, column + dates.Count] = soldier.Services.Count();
                Range cr2 = (Range)workSheet.Cells[row, column + dates.Count];
                cr2.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                cr2.Interior.Color = ConvertColour(Color.Beige);



                workSheet.Rows[row].AutoFit();
                workSheet.Rows[row].AutoFit();

                row++;
            }

            column = 3;
            for (int i = 0; i < dates.Count; i++)
            {

                workSheet.Cells[row, column + i] = soldiers.Where(soldier => soldier.Services.Contains(dates[i])).ToList().Count();



                Range cellRange = (Range)workSheet.Cells[row, column + i];
                cellRange.Interior.Color = ConvertColour(Color.Beige);
                cellRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            }

            workSheet.Cells[row, dates.Count + 3] = soldiers.Sum(soldier => soldier.Services.Count());



            Range cr3 = (Range)workSheet.Cells[row, dates.Count + 3];
            cr3.Interior.Color = ConvertColour(Color.Beige);
            cr3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;






        }

        public static int ConvertColour(Color colour)
        {
            int r = colour.R;
            int g = colour.G * 256;
            int b = colour.B * 65536;

            return r + g + b;
        }





    }

}
