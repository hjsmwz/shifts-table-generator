using System;
using System.Collections.Generic;

namespace MSM
{
    public class Soldier
    {
        public Soldier(String name, int id, String position, int soldier_case, int services_count, int current_services_count,int vac_type,List<DateTime> vacations, List<DateTime> services,bool from_upper_egypt = false)
        {
            this.Name = name;
            this.Id = id;
            this.Position = position;
            this.Soldier_case = soldier_case;
            this.Services_count = services_count;
            this.Current_services_count = current_services_count;
            this.Vacations = vacations;
            this.Vac_type = vac_type;
            this.Services = services;
            this.from_upper_egypt = from_upper_egypt;
        }



        public String Name;
        public int Id;
        public String Position;
        public int Soldier_case;
        public int Services_count;
        public int Current_services_count;
        public int Vac_type;
        public List<DateTime> Vacations;
        public List<DateTime> Services;
        public bool from_upper_egypt;
    
        /*

        //setters and getters
        public List<DateTime> Services { get => services; set => services = value; }
        public List<DateTime> Vacations { get => vacations; set => vacations = value; }
        public int Current_services_count { get => current_services_count; set => current_services_count = value; }
        public int Soldier_case { get => soldier_case; set => soldier_case = value; }
        public int Services_count { get => services_count; set => services_count = value; }
        public string Position { get => position; set => position = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Vac_type { get => vac_type; set => vac_type = value; }
        */
        public System.Collections.Generic.List<Soldier> getAllSoldiers()
        {
            // TODO: get all soldiers form database or cvs or whatever you have 
            System.Collections.Generic.List<Soldier> soldiers = new List<Soldier>();

            /*
            Soldier soldier = new Soldier("Karim Alaa", 0, "computer lab", Constants.SPECIAL_SERVICES, 1, 0, Constants.mbet_case, new List<DateTime>(), new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("Abdelrahman Abouzaid", 200, "computer lab", Constants.SPECIAL_SERVICES, 0, 0, Constants.rhat_case_1, new List<DateTime>(),  new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("Mostafa Hamza", 900, "computer lab", Constants.SPECIAL_SERVICES, 3, 0, Constants.dofa_case, new List<DateTime>(), new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("Ahmed Ali", 500, "computer lab", Constants.SPECIAL_SERVICES, 2, 0, Constants.mbet_case, new List<DateTime>(), new List<DateTime>());
            soldiers.Add(soldier);

            for (int i = 0; i <= 18; i++)
            {
                int rand_num = Config.rand.Next(0, Constants.days.Count - 8);
                soldier = new Soldier(Config.GenerateName(), i, Config.GeneratePosition(), Constants.FULL_SERVICES, 0, 0, 0, (Constants.days).GetRange(rand_num, 7), new List<DateTime>());
                soldiers.Add(soldier);
            }

            for (int i = 0; i <= 10; i++)
            {
                int rand_num = Config.rand.Next(0, Constants.days.Count - 8);
                soldier = new Soldier(Config.GenerateName(), i, Config.GeneratePosition(), Constants.FULL_SERVICES, 0, 0, Config.rand.Next(1, 3), (Constants.days).GetRange(rand_num, 7), new List<DateTime>());
                soldiers.Add(soldier);
            }

    */
            //Constants constant = Constants.getInstance();


            Soldier soldier = new Soldier("name_1", 0, "pos_1", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa1_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_1", 0, "pos_1", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa1_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_2", 0, "pos_2", Constants.SPECIAL_SERVICES, 3, 0, Constants.dofa_case, Constants.dofa1_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_3", 0, "pos_2", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa1_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_4", 0, "pos_3", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa1_vac1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_5", 0, "pos_4", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa1_vac1, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_6", 0, "pos_5", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa1_vac1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_7", 0, "pos_5", Constants.SPECIAL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa1_vac1, new List<DateTime>());
            soldiers.Add(soldier);


            soldier = new Soldier("name_8", 0, "pos_6", Constants.SPECIAL_SERVICES, 1, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_9", 0, "pos_6", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_10", 0, "pos_7", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_11", 0, "pos_8", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_12", 0, "pos_9", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_13", 0, "pos_10", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_14", 0, "pos_11", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_15", 0, "pos_11", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_16", 0, "pos_11", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa2_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);



            soldier = new Soldier("name_17", 0, "pos_12", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_18", 0, "pos_12", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_19", 0, "pos_15", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_20", 0, "pos_14", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_21", 0, "pos_13", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>(), true);
            soldiers.Add(soldier);
            soldier = new Soldier("name_22", 0, "pos_13", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_23", 0, "pos_15", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_24", 0, "pos_16", Constants.SPECIAL_SERVICES, 5, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_25", 0, "pos_17", Constants.FULL_SERVICES, 0, 0, Constants.dofa_case, Constants.dofa3_vac, new List<DateTime>());
            soldiers.Add(soldier);
           




            soldier = new Soldier("name_21", 0, "pos_12", Constants.SPECIAL_SERVICES, 1, 0, Constants.rhat_case_2, Constants.rhat_vac_2, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_22", 0, "pos_13", Constants.FULL_SERVICES, 0, 0, Constants.rhat_case_2, Constants.rhat_vac_2, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_23", 0, "pos_14", Constants.SPECIAL_SERVICES, 3, 0, Constants.rhat_case_1, Constants.rhat_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_24", 0, "pos_1", Constants.FULL_SERVICES, 0, 0, Constants.rhat_case_1, Constants.rhat_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_25", 0, "pos_2", Constants.FULL_SERVICES, 0, 0, Constants.rhat_case_1, Constants.rhat_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_26", 0, "pos_10", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_27", 0, "pos_15", Constants.SPECIAL_SERVICES, 1, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_28", 0, "pos_11", Constants.SPECIAL_SERVICES, 1, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_29", 0, "pos_16", Constants.SPECIAL_SERVICES, 1, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_30", 0, "pos_19", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_31", 0, "pos_18", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_32", 0, "pos_20", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_33", 0, "pos_20", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_34", 0, "pos_21", Constants.SPECIAL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_35", 0, "pos_21", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_36", 0, "pos_21", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_37", 0, "pos_9", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_38", 0, "pos_8", Constants.FULL_SERVICES, 0, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);
            soldier = new Soldier("name_39", 0, "pos_7", Constants.SPECIAL_SERVICES, 3, 0, Constants.mbet_case, Constants.mbet_vac_1, new List<DateTime>());
            soldiers.Add(soldier);





            return soldiers;
        }


        public bool haveAvailableServices()
        {
            // return this.current_services_count < this.Services_count;
            return  this.Services_count > 0;

        }
    }


}