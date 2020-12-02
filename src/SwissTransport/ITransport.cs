namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);

        Stations GetStationsCoordinate(double x, double y);

        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStation, string Date, string Time, int isArrivalTime);
        Connections GetConnections(string fromStation, string toStation);
    }
}