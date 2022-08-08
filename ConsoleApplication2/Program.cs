using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class hospital
    {
        string[] Insurances = new string [4];
        string[] TypeOfIllnessCoverage = new string[4];
        string AcceptMessage;
        string FailedMesssage;
        string both;
        string Insurance1;
        
        int PricePerDay;

       public hospital()
        {
             Insurances = new[] {"razi","day","iran","tamin ejtemaee"};
             PricePerDay = 20000;
             TypeOfIllnessCoverage = new[] { "ghalbi", "omomi", "maghz va asab", "dandan", "ostokhan" };
             AcceptMessage = "(Your pationt be accepted)";
             FailedMesssage = "Yor pationt Not be accepted...Sorry";
            
             both = FailedMesssage;

             
        }

       public void setSearchIll(string Ill)
       {
           
           for (int i = 0; i < 4; i++)
               if (Ill == TypeOfIllnessCoverage[i])
               {
                   both = AcceptMessage;

                   break;

               }    
       }

       public string getSearchIll()
       {
           return both;
       }

       public void setSearchInsurance(string Insurance2)
       {
          string Insurance = "Your Insurance Be Accepted ... ";
          Insurance1 = "Your Insurance Not Be Accepted ...";

          for (int i = 0; i < 4; i++)
          {
              if (Insurance2 == Insurances[i])
              {
                  Insurance1 = Insurance;
                  continue;
              }
          }         
           
       }
       public string getSearchInsurance()
       {
           return Insurance1;
       }

       public int getPricePerDay()
       {
           return PricePerDay;
       }

    }
    //------------------------------------------------Doctor : Hospital---------------------------------------------
    public class doctor: hospital
    {
        string[,] Doctors = new string[5, 4];
        string DoctorName;
        string DoctorSpeciality;
        string DoctorRecept;
        long DoctorPhone;
        string DoctorID;
        

        public doctor()
        {
            Doctors = new[,] {
                               {"saradar","ghalbi","09122222229","00001","sunday"},
                               {"tavakoli","omomi","09121122339","00002","monday"},
                               { "gholami","maghz va asab","09364455123","00003","thursday"},
                               {"mohammadi","dandan","09394589631","00004","friday"},
                               {"mortazavi","ortoped","09360000001","00005","saterday"}
                             };

        }

        public void setDoctorSpeciality(string Illness)
        {
            
                for (int j = 0; j < 5; j++)
                {
                    if (Illness == Doctors[j, 1])
                    {
                        DoctorName = Doctors[j, 0];
                        DoctorSpeciality = Doctors[j, 1];
                        DoctorPhone =long.Parse(Doctors[j, 2]);
                        DoctorID = Doctors[j, 3];
                        DoctorRecept = Doctors[j, 4];
                        break;

                    }
                    else
                        continue;

                }
            

        }
        public string getDoctorName()
        {
            return DoctorName;
        }
        public string getDoctorSpeciality()
        {
            return DoctorSpeciality;
        }
        public long getDoctorPhone()
        {
            return DoctorPhone;
        }
        public string getDoctorID()
        {
            return DoctorID;
        }
        public string getDoctorRecept()
        {
            return DoctorRecept;
        }

    }
    public class pationt : doctor
    {
        
        Random PationtID1;
 
        string HistoryOfDisease;
        string RecentDisease;
        string TypeOfInsurance;
        string Name;
        long PhoneNumber;
        int PationtID;
        int CuringDay;
        int Age;

        string generation1;

        public void setGeneration(bool Generation)
        {
            if (Generation == true)
                generation1 = "Women";
            else
                generation1 = "Man";
        }

        public string getGeneration()
        {
            return generation1;
        }

        public void setHistoryOfDisease(string HistoryOfDisease)
        {

            this.HistoryOfDisease = HistoryOfDisease;
        }

        public string getHistoryOfDisease()
        {
            return HistoryOfDisease;
        }

        public void setRecentDisease(string RecentDisease) 
        {
           // setPationt(RecentDisease);
            this.RecentDisease = RecentDisease;
        }

        public string getRecentDisease()
        {
            return RecentDisease;
        }

        public void setTypeOfInsurenc(string insurenc)
        {
            TypeOfInsurance = insurenc;
        }

        public string getTypeOfInsurenc()
        {
            return TypeOfInsurance;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return Name;
        }

        public void setPhoneNumber(long PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

        public long getPhoneNumber()
        {
            return PhoneNumber;
        }

        public void setPationtID()
        {
            PationtID1 = new Random();
            PationtID = PationtID1.Next(10000, 20000);
            
        }
        public int getPationtID()
        {
            return PationtID;        
        }

        public void setCuringDay(int CuringDay , string InsuranceResualt)
        {
            if (InsuranceResualt == "Your Insurance Not Be Accepted ...")
            {
                this.CuringDay = getPricePerDay()*CuringDay;
            }
            else
            {
                this.CuringDay = (getPricePerDay()*CuringDay* 50 / 100);
            }
        }

        public int getCuringDay()
        {
            return CuringDay;
        }

        public void setAge(int Age)
        {
            this.Age = Age;
        }

        public int getAge()
        {
            return Age;
        }
    }

    class Program
    {
        static void Main()
        {
            string Diease;
            string RecentDiease;
            string Insurance;
            
            string Name;


            long PhoneNumber;
            int Generation;
            int CuringDay;
            int Age;
            int HumanResualt;
            int pationts;
            int i;

            
            Console.WriteLine("Welcom To My hospital  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ReadKey();
            Console.Clear();

            Console.Write("how many do you have pationt : ");
            pationts=int.Parse(Console.ReadLine());
            string [] Insurances = new string[pationts];
            pationt[] Pationt = new pationt[pationts];
            hospital[] Hospital = new hospital[pationts];
            doctor[] Doctor = new doctor[pationts];
            Console.WriteLine("------------------------------------------------//");
            Console.Write("Welcome to the Reception section : \n");
            Console.WriteLine("------------------------------------------------//");
            for ( i = 0;i<pationts; i++)
            {
                if (i > pationts - 1)
                    break;

                Pationt[i] = new pationt();
                Hospital[i] = new hospital();
                Doctor[i] = new doctor();


                Console.WriteLine("this is Person " + (i + 1));

                Console.WriteLine("------------------------------------------------//");
                Console.Write("Enter Your Name : ");
                Name = Console.ReadLine();
                Pationt[i].setName(Name);

                Console.Write("Enter Your Generation : ");
                Console.Write("       1.Man   ");
                Console.WriteLine("2.Women");
                Generation = int.Parse(Console.ReadLine());
                if (Generation == 1)
                    Pationt[i].setGeneration(false);
                else
                    Pationt[i].setGeneration(true);

                Console.Write("Enter Your Age : ");
                Age = int.Parse(Console.ReadLine());
                Pationt[i].setAge(Age);

                Console.Write("Enter Your Cell Phone Number : ");
                PhoneNumber = long.Parse(Console.ReadLine());
                Pationt[i].setPhoneNumber(PhoneNumber);


                Console.Write("Enter Your History Of Diease : ");
                Diease = Console.ReadLine();
                Pationt[i].setHistoryOfDisease(Diease);

                Console.Write("Enter Your Recent Diease : ");
                RecentDiease = Console.ReadLine();
                Pationt[i].setRecentDisease(RecentDiease);

                Doctor[i].setDoctorSpeciality(RecentDiease);

                Hospital[i].setSearchIll(RecentDiease);
                Console.WriteLine(Hospital[i].getSearchIll());

                if (Hospital[i].getSearchIll() == "(Your pationt be accepted)")
                {
                  
                    Console.Write("Enter Your Type Of Insurance : ");
                    Insurance = Console.ReadLine();
                    Pationt[i].setTypeOfInsurenc(Insurance);

                    Hospital[i].setSearchInsurance(Insurance);
                    Console.WriteLine(Hospital[i].getSearchInsurance());

                    Insurances[i] = Hospital[i].getSearchInsurance();

                    Console.WriteLine("--------------------------------------//");
                    Pationt[i].setPationtID();
                    Console.WriteLine("1.Pationt ID : " + Pationt[i].getPationtID());
                    Console.WriteLine("2.Pationt Name : " + Pationt[i].getName());
                    Console.WriteLine("3.Pationt Age : " + Pationt[i].getAge());
                    Console.WriteLine("4.Pationt phonenumber : " + Pationt[i].getPhoneNumber());
                    Console.WriteLine("5.Pationt History of diease : " + Pationt[i].getHistoryOfDisease());
                    Console.WriteLine("6.Pationt Recent Diease :" + Pationt[i].getRecentDisease());
                    Console.WriteLine("7.Pationt Type of insurance : " + Pationt[i].getTypeOfInsurenc());
                    Console.WriteLine("------------------------------------------------//");
                    Console.WriteLine("Information Of Your Doctors : ");
                    Console.Write("1.Doctor name : " + Doctor[i].getDoctorName() + "\t");
                    Console.Write("2.Doctor speciality : " + Doctor[i].getDoctorSpeciality() + "\t");
                    Console.Write("3.Doctor phone : " + Doctor[i].getDoctorPhone() + "\t");
                    Console.Write("4.Doctor ID : " + Doctor[i].getDoctorID() + "\t");
                    Console.Write("5.Doctor reception :" + Doctor[i].getDoctorRecept() + "\t");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------//");
                    
                    
                    if (pationts == 1)
                        break;
                    if (pationts > 1)
                        continue;

                }
            }
            Console.Write("Welcome to the Clearance section : \n");
            Console.WriteLine("------------------------------------------------//");
            Console.Write("How Many Pationts Do you want to Clearance ? : ");
            int clearance;
            clearance = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------//");
            Console.WriteLine("Each Day in Our Hospital Will Cost 20000 toman");
            Console.WriteLine("If we covraged your Incurance ... you will pay the half of cost");
            Console.WriteLine("------------------------------------------------//");
            for (int k = 0; k < clearance; k++)
            {
                Console.WriteLine("this is Person " + (k + 1));

                Console.WriteLine("------------------------------------------------//");
                Console.Write("enter Name : ");
                string names;
                names = Console.ReadLine();
                for (int j = 0; j < pationts; j++)
                {
                    if (names == Pationt[j].getName())
                    {
                        Console.WriteLine("--------------------------------------//");
                        Console.WriteLine("1.Pationt ID : " + Pationt[j].getPationtID());
                        Console.WriteLine("2.Pationt Name : " + Pationt[j].getName());
                        Console.WriteLine("3.Pationt Age :" + Pationt[j].getAge());
                        Console.WriteLine("4.Pationt PhoneNumbe : " + Pationt[j].getPhoneNumber());
                        Console.WriteLine("5.Pationt History Diease : " + Pationt[j].getHistoryOfDisease());
                        Console.WriteLine("6.Pationt Recdent Diease : " + Pationt[j].getRecentDisease());
                        Console.WriteLine("7.Pationt Type Of Insurance : " + Pationt[j].getTypeOfInsurenc());
                        Console.WriteLine("--------------------------------------------------///");
                        Console.WriteLine("Information Of Your Doctors : ");
                        Console.Write("1.Doctor name : " + Doctor[j].getDoctorName() + "\t");
                        Console.Write("2.Doctor speciality : " + Doctor[j].getDoctorSpeciality() + "\t");
                        Console.Write("3.Doctor phone : " + Doctor[j].getDoctorPhone() + "\t");
                        Console.Write("4.Doctor ID : " + Doctor[j].getDoctorID() + "\t");
                        Console.Write("5.Doctor reception :" + Doctor[j].getDoctorRecept() + "\t");
                        Console.Write("\nEnter Your CursingDay : ");
                        CuringDay = int.Parse(Console.ReadLine());

                        Pationt[j].setCuringDay(CuringDay, Insurances[j]);

                        Console.WriteLine("you have to cost : " + Pationt[j].getCuringDay() + " Toman");
                        Console.WriteLine("--------------------------------------------------///");

                    }
                    else
                        continue;
                }
            }

            Console.WriteLine("Good Luck ... click to Exit : ");
            Console.WriteLine("--------------------------------------------------///");
            Console.WriteLine("Developed by : JR.Y");
            Console.WriteLine("--------------------------------------------------///");
            Console.WriteLine("------>De.coder();");
            Console.ReadKey();

            
        }
    }
}
