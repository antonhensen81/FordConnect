using FordConnect.Helpers;
using FordConnect.Services;

var username = "yourUsername";
var password = "yourPassowrd";
var VIN = "yourVIN";
var region = Regions.Region.US;

var vehicle = new Vehicle(VIN, username, password, region);
vehicle.Initialize();
var status = vehicle.GetStatus();
// var startResult = vehicle.Start();
// var stopResult = vehicle.Stop();
// var lockResult = vehicle.Lock();
// var unlockResult = vehicle.Unlock();

Console.ReadKey();