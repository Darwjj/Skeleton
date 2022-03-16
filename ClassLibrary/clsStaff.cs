using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaff_ID;
        public int Staff_ID {
            get {
                return mStaff_ID;

            }
            set {
                mStaff_ID = value;
            }
        }

        public bool Find(int staff_ID)
        {
            mStaff_ID = 1;

            return true;
        }



        private bool mStaff_Gender;
        public bool Staff_Gender { get; set; }





        private string mStaff_Role;
        public string Staff_Role { get; set; }





        private DateTime mStaff_StartDate;
        public DateTime Staff_StartDate {
            get {
                return mStaff_StartDate;
            }
            set {
                mStaff_StartDate = value;
            }

             public bool Find(int Staff_StartDate)
        {
            mStaff_ID = 1;
            mStaff_StartDate = Convert.ToDateTime("20/08/2020");

            return true;
        }





        private double mStaff_Salary;
        public double Staff_Salary { get; set; }


       

        private string mStaff_FullName;
        public string Staff_FullName { get; set; }
       
        


        
    }






}