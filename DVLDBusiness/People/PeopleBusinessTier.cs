using DVLDProject.DVLDBusiness;
using PeopleData;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using UserBusinessTier;


namespace PeopleBusinessTier
{


    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1  };
        public enMode Mode ;
        public int PersonId  { get; set; }
        public string NationalNumber { get; set; }
        
        public string FirstName { get; set; }
        
        public string SecondName { get; set; }
       
        public string ThirdName { get; set; }

        public string LastName { get; set; }

        public string FullName { 
            get 
            { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }
        public DateTime DateofBirth {  get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public short Gender {  get; set; }
       
        public string Address { get; set; }
       
        public string ImagePath {  get; set; }
       
        public string Country { get; set; }
       

        public clsPerson() {
            PersonId = -1;
            NationalNumber = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateofBirth = DateTime.Now;
            Email = "";
            PhoneNumber = "";
            Address = "";
            ImagePath = "";
            Country = "";

          Mode = enMode.AddNew;
        }

        private clsPerson(int personID, string nationalNumber, string firstname , string secondname, string thirdname,
            string lastname , DateTime dateofbirth, string email, string phone, string address, short gender, string imagepath, string country )
        {
            PersonId = personID;
            NationalNumber = nationalNumber;
            FirstName = firstname;
            SecondName = secondname;
            ThirdName = thirdname;
            LastName = lastname;
            DateofBirth = dateofbirth;
            Email = email;
            PhoneNumber = phone;
            Address = address;
            Gender = gender;
            Country = country;
            ImagePath = imagepath;


            Mode = enMode.Update;


        }


        public static DataTable GetAllPeople()
        {
            return PeopleData.clsPeople.GetPeople(); ;

        }

        public static clsPerson Find(int personID)
        {
           
         string  NationalNumber = "";
         string   FirstName = "";
         string   SecondName = "";
         string   ThirdName = "";
         string   LastName = "";
         DateTime   DateofBirth = DateTime.MinValue;
         string   Email = "";
         string   PhoneNumber = "";
         short   Gender=0 ;
         string   Address = "Haram";
         string   ImagePath = "";
         int Country = -1;

            if (PeopleData.clsPeople.FindFillPersonByID(personID, ref FirstName, ref SecondName,
                                                   ref ThirdName, ref LastName,ref NationalNumber, ref DateofBirth, ref Gender, ref Address, ref PhoneNumber, ref Email,
                                                   ref Country, ref ImagePath))
                return   new clsPerson( personID, NationalNumber, FirstName, SecondName, ThirdName,
                LastName, DateofBirth, Email, PhoneNumber, Address, Gender, ImagePath, clsCountry.Find(Country).CountryName);
            
            return null;

        }

        public static clsPerson Find(string NationalNumber)
        {
            int ID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateofBirth = DateTime.Now;
            string Email = "010";
            string PhoneNumber = "015";
            short Gender = 0 ;
            string Address = "";
            string ImagePath = "";
            int Country = -1;

            if (PeopleData.clsPeople.FindFillPersonByNationalNumber(NationalNumber, ref ID, ref FirstName, ref SecondName,
                                                   ref ThirdName, ref LastName, ref DateofBirth, ref Gender, ref Address, ref PhoneNumber, ref Email,ref Country, ref ImagePath))
                return new clsPerson(ID, NationalNumber, FirstName, SecondName, ThirdName,
                  LastName, DateofBirth, Email, PhoneNumber, Address, Gender, ImagePath, clsCountry.Find(Country).CountryName);

            return null;

        }
        private bool _AddNewPerson()
        {
            //call DataAccess Layer 
            int countryID = clsCountry.Find(this.Country).CountryID;

            this.PersonId = PeopleData.clsPeople.AddNewPerson(
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNumber,
                this.DateofBirth, this.Gender, this.Address, this.PhoneNumber, this.Email,
                 this.ImagePath, countryID);

            return (this.PersonId != -1);
        }


        private bool _Update()
        {
            //int CountryID = clsCountry.Find(this.Country)!=null ? Cou .CountryID) != null ? clsCountry.Find(this.Country).CountryID : 1;
            return PeopleData.clsPeople.Update(this.PersonId, this.FirstName, this.SecondName, this.ThirdName,
                  this.LastName, this.NationalNumber, this.DateofBirth, this.Gender, this.Address, this.PhoneNumber, this.Email,   this.ImagePath, 5);
        }

        public static bool IsPersonExist(int ID)
        {
            return PeopleData.clsPeople.IsPersonExist(ID);
        }

        public static bool IsPersonExist(string NationalNumber)
        {
            return PeopleData.clsPeople.IsPersonExist(NationalNumber);

        }


        public static bool Delete(int personID)
        {
            bool found = UserData.clsUser.IsPersonIDExists(personID);
            if (found) { return false; }
            return PeopleData.clsPeople.DeletePersonByPersonID(personID);


        }
        public static int GetPersonID(string NationalNo)
        {

            return PeopleData.clsPeople.GetPersonID(NationalNo);


        }
   
        public bool ConfirmDelete()
        {

            //return clsData.Delete(NationalNumber);
            return true;


        }
        public  bool save()
        {

            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    { return false; }

                case enMode.Update:


                    return _Update();
            }

            return false;

        }



    }

    }

