using System.Text.Json;

CalculateAverageTemperature();

static void CalculateAverageTemperature()
{
    //Deserialize the json file
    string fileName = "weatherdata.json";
    string jsonString = File.ReadAllText(fileName);
    Root weatherData = JsonSerializer.Deserialize<Root>(jsonString)!;

    //Calculate the average of air temperature
    double averageaAirTemperature = weatherData.observations.data.Average(x => x.air_temp);

    Console.WriteLine("The Average Air Temperature is : {0:0.00}", averageaAirTemperature);

    Console.Read();
}
