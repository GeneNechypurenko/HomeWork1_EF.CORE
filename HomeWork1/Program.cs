namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trainService = new TrainService();

            var newTrain = new Train
            {
                TrainNumber = "tr-123",
                DepartureStation = "London",
                ArrivalStation = "Birmingham",
                DepartureTime = DateTime.Now,
                ArrivalTime = DateTime.Now.AddHours(2)
            };

            trainService.AddTrain(newTrain);

            var retrievedTrain = trainService.GetTrain(newTrain.TrainId);
            Console.WriteLine($"Train {retrievedTrain.TrainNumber} from {retrievedTrain.DepartureStation} to {retrievedTrain.ArrivalStation}");

            retrievedTrain.DepartureStation = "Updated Station A";
            trainService.UpdateTrain(retrievedTrain);

            trainService.DeleteTrain(retrievedTrain.TrainId);
        }
    }
}
