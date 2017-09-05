using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AreaMaster
    {
        public enum AreaTypeEnum { Country, State, City, District };
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AreaID { get; set; }
        public virtual AreaTypeEnum AreaType { get; set; }
        public static List <AreaMaster> AreaCollection = new List<AreaMaster>();

        //default Constructor
        public AreaMaster()
        {

        }

        //Parametrized Constructor
        public AreaMaster(int id,string code,string name,string description,int areaId,AreaTypeEnum areaType)
        {
            ID = id;
            Code = code.ToUpper();
            Name = name.ToUpper();
            Description = description;
            AreaID = areaId;
            AreaType = areaType;
            AreaCollection.Add(this);
        }

        public int state_id;
        public int country_id;
        public int city_id;

        public void print()
        {
            foreach (var area in AreaCollection)
            {
                Console.WriteLine("ID:  {0}",area.ID);
                Console.WriteLine("Code:  {0}", area.Code);
                Console.WriteLine("Name:  {0}", area.Name);
                Console.WriteLine("Description:  {0}", area.Description);
                Console.WriteLine("AreaType:  {0}", area.AreaType);
                Console.WriteLine("AreaID:  {0}", area.AreaID);
            }
        }
        public void GetAreaMasterByDistrict(string district_name)
        {
     
            Console.WriteLine("Get AreaMaster By District");
            district_name = district_name.ToUpper();

       

            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.District && area.Name == district_name)
                {
                    Console.WriteLine("Name : {0}", area.Name);
                    city_id = area.AreaID;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.City && area.ID == city_id)
                {
                    Console.WriteLine("City : {0}", area.Name);
                    state_id = area.AreaID;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.State && area.ID == state_id)
                {
                    Console.WriteLine("State : {0}", area.Name);
                    country_id = area.AreaID;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.Country && area.ID == country_id)
                {
                    Console.WriteLine("Country : {0}", area.Name);
                }
            }

            Console.WriteLine();

        }



        public void GetAreaMasterByCity(string city_name)
        {
            Console.WriteLine("Get AreaMaster By City");
            city_name = city_name.ToUpper();
            foreach (var area in AreaCollection)
            {
                if(area.AreaType==AreaTypeEnum.City && area.Name==city_name)
                {
                    Console.WriteLine("Name : {0}", area.Name);
                    state_id = area.AreaID;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.State && area.ID == state_id)
                {
                    Console.WriteLine("State : {0}", area.Name);
                    country_id = area.AreaID;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.Country && area.ID == country_id)
                {
                    Console.WriteLine("Country : {0}", area.Name);
                }
            }
            Console.WriteLine();
        }
        public void GetAreaMasterByState(string state_name)
        {
            Console.WriteLine("Get AreaMaster By State");
            state_name = state_name.ToUpper();
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.State && area.Name == state_name)
                {
                    Console.WriteLine("Name : {0}", area.Name);
                    country_id = area.AreaID;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.Country && area.ID == country_id)
                {
                    Console.WriteLine("Country : {0}", area.Name);
                    
                }
            }
            Console.WriteLine();

        }
    }
   
    
}
