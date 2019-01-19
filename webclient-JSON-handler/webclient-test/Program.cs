using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace webclienttest
{
    // Firstly add via nuget package manager the newtonsoft.json package.
    // Secondly add using to the top of the code.
    // Then you can use it.
    //
    // Sipos Miklos, 2018
    //




    class Worker
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }


    class FileHandler
    {
        // deserialization
        public List<Worker> CreateWorkerFromJSON()
        {
            string url = "http://users.nik.uni-obuda.hu/siposm/db/people.json";

            WebClient client = new WebClient();
            string s = client.DownloadString(url);

            return JsonConvert.DeserializeObject<List<Worker>>(s); // generic type:  <xy>
        }


        // serialization for 1 object
        public string CreateJSONFromWorker(Worker worker)
        {
            return JsonConvert.SerializeObject(worker);
        }


        // serialization for 'n' objects
        public void CreateJSONFromWorkerList(List<Worker> workers)
        {
            StreamWriter sw = new StreamWriter("workers.json");
            string json = JsonConvert.SerializeObject(workers);
            sw.WriteLine(json);
            sw.Close();
        }

    }

    class MainClass
    {


        public static void Main(string[] args)
        {
            FileHandler fh = new FileHandler();

            Worker w = new Worker()
            {
                Name = "Teszt Elek",
                Age = 33,
                Job = "Student",
                Salary = 10
            };


            string jsonOutput = fh.CreateJSONFromWorker(w);

            Console.WriteLine("JSON output from worker: \n{0}",jsonOutput);


            // ============================================================
            Console.WriteLine("");
            // ============================================================


            List<Worker> wl = fh.CreateWorkerFromJSON();
            foreach (Worker i in wl)
            {
                Console.WriteLine(
                    "    > WORKER: {0} {1} {2}",
                    i.Name, i.Age, i.Job
                                 );
            }

            wl[0].Name = "Sipos Miklos";

            fh.CreateJSONFromWorkerList(wl);
        }
    }
}
