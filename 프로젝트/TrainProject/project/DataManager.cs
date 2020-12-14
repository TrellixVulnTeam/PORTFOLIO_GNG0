using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace project
{
    class DataManager
    {
        public static int test1;
        public static List<MyTrain> Trains = new List<MyTrain>();
        public static List<MyTrain> Search = new List<MyTrain>();
        public static List<Reservation> Reservationing = new List<Reservation>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string trainOutput = File.ReadAllText(@"./Trains.xml");
                XElement trainXElement = XElement.Parse(trainOutput);
                foreach (var item in trainXElement.Descendants("train"))
                {
                    int temptrainnumber = int.Parse(item.Element("trainnumber").Value);
                    string temptrainname = item.Element("trainname").Value;
                    string tempstartroute = item.Element("startroute").Value;
                    string tempendroute = item.Element("endroute").Value;
                    string tempstarttime = item.Element("starttime").Value;
                    string tempendtime = item.Element("endtime").Value;
                    int temppay = int.Parse(item.Element("pay").Value);






                    MyTrain tempTrain = new MyTrain()
                    {
                        trainnumber = temptrainnumber,
                        trainname = temptrainname,
                        startroute = tempstartroute,
                        endroute = tempendroute,
                        starttime = tempstarttime,
                        endtime = tempendtime,
                        pay = temppay

                    };

                    Trains.Add(tempTrain);

                }
            }
            catch (Exception excp)
            {

            }
        }
        public static void Createfile()
        {
            string filename = @"./Trains.xml";
            StreamWriter textwrite = File.CreateText(filename);
            textwrite.Dispose();
        }
        public static void Save()
        {
            string trainOutput = "";
            trainOutput += "<trains>\n";
            if (Trains.Count > 0)
            {
                foreach (var item in Trains)
                {
                    trainOutput += "<train>\n";
                    trainOutput += "<trainnumber>" + item.trainnumber + "</trainnumber>\n";
                    trainOutput += "<trainname>" + item.trainname + "</trainname>\n";
                    trainOutput += "<startroute>" + item.startroute + "</startroute>\n";
                    trainOutput += "<endroute>" + item.endroute + "</endroute>\n";
                    trainOutput += "<starttime>" + item.starttime + "</starttime>\n";
                    trainOutput += "<endtime>" + item.endtime + "</endtime>\n";
                    trainOutput += "<pay>" + item.pay + "</pay>\n";
                    trainOutput += "</train>\n";
                }
            }

            trainOutput += "</trains>";
            File.WriteAllText(@"./Trains.xml", trainOutput);
        }
        public static void Find(string box1, string box2)
        {
            Search.Clear();


            try
            {
                string trainOutput = File.ReadAllText(@"./Trains.xml");
                XElement trainXElement = XElement.Parse(trainOutput);
                foreach (var item in trainXElement.Descendants("train"))
                {
                    int temptrainnumber = int.Parse(item.Element("trainnumber").Value);
                    string temptrainname = item.Element("trainname").Value;
                    string tempstartroute = item.Element("startroute").Value;
                    string tempendroute = item.Element("endroute").Value;
                    string tempstarttime = item.Element("starttime").Value;
                    string tempendtime = item.Element("endtime").Value;
                    int temppay = int.Parse(item.Element("pay").Value);



                    if (tempstartroute == box1 && tempendroute == box2)
                    {




                        MyTrain search = new MyTrain()
                        {
                            trainnumber = temptrainnumber,
                            trainname = temptrainname,
                            startroute = tempstartroute,
                            endroute = tempendroute,
                            starttime = tempstarttime,
                            endtime = tempendtime,
                            pay = temppay

                        };

                        Search.Add(search);
                    }

                }
            }
            catch (Exception excp)
            {
       
            }
        }
        public static void Reserve()
        {
            Reservationing.Clear();
            try
            {
                string trainOutput = File.ReadAllText(@"./Trains.xml");
                XElement trainXElement = XElement.Parse(trainOutput);
                foreach (var item in trainXElement.Descendants("train"))
                {

                    string tempreserve = item.Element("reserve").Value;

                  Reservation reserve = new Reservation()
                    {
                        reserve = tempreserve

                    };

                    Reservationing.Add(reserve);
                }
            }
            catch (Exception excp)
            {
 
            }
        }
        public static void Reserve_Save()
        {
            string reserveoutput = "";
            reserveoutput += "<trains>\n";
            if (Trains.Count > 0)
            {
                //foreach (var item in Reservationing)
                for(int i = 0; i< 18; i++)
                {
                    reserveoutput += "<train>\n";
                    reserveoutput += $"<trainname>{Trains[i].trainname}</trainname>\n";
                    reserveoutput += $"<trainnumber>{Trains[i].trainnumber}</trainnumber>\n";
                    reserveoutput += $"<reserve>{Reservationing[i].reserve}</reserve>\n";
                    reserveoutput += $"<startroute>{Trains[i].startroute}</startroute>\n";
                    reserveoutput += $"<endroute>{Trains[i].endroute}</endroute>\n";
                    reserveoutput += $"<starttime>{Trains[i].starttime}</starttime>\n";
                    reserveoutput += $"<endtime>{Trains[i].endtime}</endtime>\n";
                    reserveoutput += $"<pay>{Trains[i].pay}</pay>\n";
                    reserveoutput += "</train>\n";
                }
            }

            reserveoutput += "</trains>";
            File.WriteAllText(@"./Trains.xml", reserveoutput);
        }
    }
}