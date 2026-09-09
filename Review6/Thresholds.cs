using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
namespace Review_6
{
    public class Thresholds
    {
        //thresholds.json
        //{
        //  "thresholds": 
        //    { "type": "temperature", "min": -10, "max": 45 },
        //    { "type": "humidity", "min": 0, "max": 90 },
        //    { "type": "pressure", "min": 950, "max": 1050 }
        //  ]
        public String Type {  get; set; }
        public float min {  get; set; }
        public float max { get; set; }
       
        public Thresholds()
        {

        }

      public bool Validate_sensor_Value(List<Thresholds> list , Sensor s)
        {
            foreach (Thresholds t in list)
            {
                if(t.Type == s.Type)
                {
                    if(s.Value >= t.min && s.Value <= t.max){
                        return true;
                    }
                }
            }
            string json = JsonSerializer.Serialize(s);
            File.WriteAllText("breaches.json", json);
            return false;
        }

        //Detect 3 consecutive threshold breaches.

        public bool detect_3_Consecutive_threshold(List<Thresholds> list, List<Sensor> sensor)
        {
            int count = 0;
            foreach (Thresholds t in list)
            {

                for (int i = 0; i < sensor.Count-3; i++)
                {
                        if (!Validate_sensor_Value(list , sensor[i]) && !Validate_sensor_Value(list, sensor[i+1]) && !Validate_sensor_Value(list , sensor[i+2]) )
                        {
                        

                        return true;
                        }

                }

            }
            return false;
           
        }

    }

}

