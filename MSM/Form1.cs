using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           /* if (this.vacDays.Text != null)
            {
                try
                {
                    DateTime start = this.firstOfAll.SelectionStart;
                    DateTime end = this.firstOfAll.SelectionEnd;
                    int vacDaysCount = Int32.Parse(this.vacDays.Text);
                    int groups_no = Int32.Parse(this.groupsCount.Text);
                    Vacation vac = new Vacation(vacDaysCount, groups_no);
                    int startedGroup = Int32.Parse(this.startedGroup.Text);

                    Dictionary<int, List<DateTime>> vacations = vac.getGroupsRange(start, end, startedGroup);
                    Constants constant = Constants.getInstance();
                    constant.dofa1_vac = vacations[1];
                    constant.dofa2_vac = vacations[2];
                    constant.dofa3_vac = vacations[3];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Days & Groups Count Value Must Be A Number");
                }

            }
            else {
                MessageBox.Show("Please Enter The Days Count Of Each Vacation");
            }*/

           
          
            Soldier soldier = new Soldier("", 0, "", 0, 0, 0, 0, new List<DateTime>(), new List<DateTime>());
            List<Soldier> soldiers = soldier.getAllSoldiers();
            //List<DateTime> dates = Config.GetDates(2019,4);
            int special_services_count = soldiers.Where(item => item.Soldier_case == Constants.SPECIAL_SERVICES).Sum(item => item.Services_count);
            int available_services_count = Constants.SERVICES_PER_MONTH - special_services_count;

            soldiers = Config.AddServicesCountForSoldiers(soldiers, available_services_count);
            List<Soldier> temp = soldiers;
            Dictionary<List<Soldier>, Dictionary<DateTime, int>> final_dic = Config.SetVacationsServices(soldiers, Constants.days);
            Config.renderTable(final_dic);
            /*  /*
            MessageBox.Show("special services count is : " + special_services_count.ToString());
            MessageBox.Show("available services count is : " + available_services_count.ToString());
            MessageBox.Show(Constants.getInstance().SERVICES_PER_MONTH.ToString());
            MessageBox.Show(soldiers.Count.ToString());
            MessageBox.Show(dates.Count.ToString());
            */

        }

    }
}
