using DVLDProject;
using DVLDProject.DVLDBusiness;
using PeopleData;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace UserBusinessTier
{


    public class clsUser
    {
     
        public bool IsActive = false;
        public int UserID { get; set; }
        public int PersonID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;

        }

        private clsUser(int Userid, int personID, string username,string password, bool isActive )
        {
            this.PersonID = personID;
            this.UserID  = Userid;
            this.UserName = username;
            this.Password = password;
            this.IsActive =isActive;

        }


        public static DataTable GetAllUsers()
        { 
         
            return UserData.clsUser.GetUsers();

        }
        public static bool IsPersonExistInUsers(int PersonID)
        {
            return UserData.clsUser.IsPersonIDExists(PersonID);
        }
        public static clsUser Find(string UserName, string Password)
        {

            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;
            string HashedPassword = ClsHashing.ComputeHash(Password);

            if (UserData.clsUser.FindUserByUserNameAndPassword(UserName, HashedPassword, ref UserID, ref PersonID,ref IsActive))
            {
                clsGlobal.CurrentUser.Password = Password; clsGlobal.CurrentUser.UserID = UserID;
                clsGlobal.CurrentUser.UserName = UserName;
                clsGlobal.CurrentUser.IsActive = IsActive; clsGlobal.CurrentUser.PersonID = PersonID;

                return new clsUser(UserID,PersonID, UserName, HashedPassword, IsActive);

            }

            return null;
        }
       



        public int AddNewUser( int PersonID, string UserName, string Password, bool IsActive)
        {
            string HashedPassword = ClsHashing.ComputeHash(Password);

            this.UserID = UserData.clsUser.AddNewUser(PersonID, UserName, HashedPassword,IsActive);
            return this.UserID ;
        }

        //private bool _Update()
        //{
           

        //    return UserData.clsUser.Update(this.PersonID,this.UserID,
        //        this.UserName, this.Password, this.IsActive);

        //}


        //public static bool IsPersonExist(int ID)
        //{
        //    return PeopleDataTier.IsPersonExist(ID);
        //}

        //public static bool IsPersonExist(string NationalNumber)
        //{
        //    return PeopleDataTier.IsPersonExist(NationalNumber);

        //}

        public static string GetUserNameByUserID(int UserID)
        {

            return UserData.clsUser.GetUserNameByUserID(UserID);
        }
        public static bool Delete(int UserID)
        {

            return UserData.clsUser.DeleteUserByUserID(UserID);
        }

        private bool _Delete(string NationalNumber)
        {

            //return clsData.Delete(NationalNumber);
            return true;



        }

        public static bool PasswordChanged(int UserID, string Password)
        {
            string HashedPassword = ClsHashing.ComputeHash(Password);

            return (UserData.clsUser.ChangePassword(UserID, HashedPassword) == true);
               
        }

      
    }

    }

