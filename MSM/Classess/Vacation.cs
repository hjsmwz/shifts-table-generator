using System;
using System.Collections.Generic;
using System.Linq;

namespace MSM
{
    class Vacation
    {
        private int days;
        private int groups;

        public Vacation(int days, int groups)
        {
            this.days = days;
            this.groups = groups;
        }


        // Get vacation days for each group (Dof3at)
        public Dictionary<int, List<DateTime>> getGroupsRange(DateTime start, DateTime end, int startedGroup)
        {
            Dictionary<int, List<DateTime>> range = this.initializeRange();
            List<DateTime> month_days = Constants.days;
            int month_days_count = month_days.Count();
            int i = startedGroup;

            do{
                if (end.Month > start.Month) 
                {
                    end = month_days[month_days_count - 1];
                }
                range[i] = range[i].Concat(this.assignVacationsRange(start.Date, end.Date)).ToList();
                start = end.AddDays(1);
                end = start.AddDays(this.days-1);
                if (i == this.groups)
                    i = 1;
                else
                    i++;
            }
            while (start.Month == month_days[0].Month && start.Day <= month_days.Count());

            
            return range;
        }


        // Get vacation days for a single group
        public List<DateTime> assignVacationsRange(DateTime start, DateTime end)
        {
            return Enumerable.Range(0, 1 + end.Subtract(start).Days)
                             .Select(offset => start.AddDays(offset))
                             .ToList();
        }



        private Dictionary<int, List<DateTime>> initializeRange()
        {
            Dictionary<int, List<DateTime>> range = new Dictionary<int, List<DateTime>>();
            for (var i = 1; i <= this.groups; i++) {
                range.Add(i, new List<DateTime>());
            }

            return range;
        }

    }
                          
}
