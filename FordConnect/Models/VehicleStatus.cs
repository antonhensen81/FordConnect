using Newtonsoft.Json;

namespace FordConnect.Models
{
    public class CarStatus
    {
        [JsonProperty("vehiclestatus")]
        public Vehiclestatus Vehiclestatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class Alarm
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Battery
    {
        [JsonProperty("batteryHealth")]
        public BatteryHealth BatteryHealth { get; set; }

        [JsonProperty("batteryStatusActual")]
        public BatteryStatusActual BatteryStatusActual { get; set; }
    }

    public class BatteryChargeStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class BatteryHealth
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class BatteryPerfStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class BatteryStatusActual
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class BatteryTracLowChargeThreshold
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class BattTracLoSocDDsply
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class CcsSettings
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("vehicleConnectivity")]
        public int VehicleConnectivity { get; set; }

        [JsonProperty("vehicleData")]
        public int VehicleData { get; set; }

        [JsonProperty("drivingCharacteristics")]
        public int DrivingCharacteristics { get; set; }

        [JsonProperty("contacts")]
        public int Contacts { get; set; }
    }

    public class ChargeEndTime
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ChargerPowertype
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ChargeStartTime
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ChargingStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DeepSleepInProgress
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DieselSystemStatus
    {
        [JsonProperty("exhaustFluidLevel")]
        public ExhaustFluidLevel ExhaustFluidLevel { get; set; }

        [JsonProperty("filterSoot")]
        public object FilterSoot { get; set; }

        [JsonProperty("ureaRange")]
        public object UreaRange { get; set; }

        [JsonProperty("metricType")]
        public MetricType MetricType { get; set; }

        [JsonProperty("filterRegenerationStatus")]
        public object FilterRegenerationStatus { get; set; }
    }

    public class DoorStatus
    {
        [JsonProperty("rightRearDoor")]
        public RightRearDoor RightRearDoor { get; set; }

        [JsonProperty("leftRearDoor")]
        public LeftRearDoor LeftRearDoor { get; set; }

        [JsonProperty("driverDoor")]
        public DriverDoor DriverDoor { get; set; }

        [JsonProperty("passengerDoor")]
        public PassengerDoor PassengerDoor { get; set; }

        [JsonProperty("hoodDoor")]
        public HoodDoor HoodDoor { get; set; }

        [JsonProperty("tailgateDoor")]
        public TailgateDoor TailgateDoor { get; set; }

        [JsonProperty("innerTailgateDoor")]
        public InnerTailgateDoor InnerTailgateDoor { get; set; }
    }

    public class DriverDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DriverWindowPosition
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DualRearWheel
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ElVehDTE
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ExhaustFluidLevel
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class FirmwareUpgInProgress
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Fuel
    {
        [JsonProperty("fuelLevel")]
        public double FuelLevel { get; set; }

        [JsonProperty("distanceToEmpty")]
        public double DistanceToEmpty { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Gps
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("gpsState")]
        public string GpsState { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class HoodDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class HybridModeStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class IgnitionStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class InnerLeftRearTirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class InnerLeftRearTireStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class InnerRightRearTirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class InnerRightRearTireStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class InnerTailgateDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class LeftFrontTirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class LeftFrontTireStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class LeftRearDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class LifeCycMode
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class LockStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class MetricType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Odometer
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Oil
    {
        [JsonProperty("oilLife")]
        public string OilLife { get; set; }

        [JsonProperty("oilLifeActual")]
        public int OilLifeActual { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class OutandAbout
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class OuterLeftRearTirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class OuterLeftRearTireStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class OuterRightRearTirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class OuterRightRearTireStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class PassengerDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class PassWindowPosition
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class PlugStatus
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class PreCondStatusDsply
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class PrmtAlarmEvent
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RearDriverWindowPos
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RearPassWindowPos
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RecommendedFrontTirePressure
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RecommendedRearTirePressure
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RemoteStart
    {
        [JsonProperty("remoteStartDuration")]
        public int RemoteStartDuration { get; set; }

        [JsonProperty("remoteStartTime")]
        public int RemoteStartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RemoteStartStatus
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RightFrontTirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RightFrontTireStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RightRearDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class TailgateDoor
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class TirePressure
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class TirePressureByLocation
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class TirePressureSystemStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class TPMS
    {
        [JsonProperty("tirePressureByLocation")]
        public TirePressureByLocation TirePressureByLocation { get; set; }

        [JsonProperty("tirePressureSystemStatus")]
        public TirePressureSystemStatus TirePressureSystemStatus { get; set; }

        [JsonProperty("dualRearWheel")]
        public DualRearWheel DualRearWheel { get; set; }

        [JsonProperty("leftFrontTireStatus")]
        public LeftFrontTireStatus LeftFrontTireStatus { get; set; }

        [JsonProperty("leftFrontTirePressure")]
        public LeftFrontTirePressure LeftFrontTirePressure { get; set; }

        [JsonProperty("rightFrontTireStatus")]
        public RightFrontTireStatus RightFrontTireStatus { get; set; }

        [JsonProperty("rightFrontTirePressure")]
        public RightFrontTirePressure RightFrontTirePressure { get; set; }

        [JsonProperty("outerLeftRearTireStatus")]
        public OuterLeftRearTireStatus OuterLeftRearTireStatus { get; set; }

        [JsonProperty("outerLeftRearTirePressure")]
        public OuterLeftRearTirePressure OuterLeftRearTirePressure { get; set; }

        [JsonProperty("outerRightRearTireStatus")]
        public OuterRightRearTireStatus OuterRightRearTireStatus { get; set; }

        [JsonProperty("outerRightRearTirePressure")]
        public OuterRightRearTirePressure OuterRightRearTirePressure { get; set; }

        [JsonProperty("innerLeftRearTireStatus")]
        public InnerLeftRearTireStatus InnerLeftRearTireStatus { get; set; }

        [JsonProperty("innerLeftRearTirePressure")]
        public InnerLeftRearTirePressure InnerLeftRearTirePressure { get; set; }

        [JsonProperty("innerRightRearTireStatus")]
        public InnerRightRearTireStatus InnerRightRearTireStatus { get; set; }

        [JsonProperty("innerRightRearTirePressure")]
        public InnerRightRearTirePressure InnerRightRearTirePressure { get; set; }

        [JsonProperty("recommendedFrontTirePressure")]
        public RecommendedFrontTirePressure RecommendedFrontTirePressure { get; set; }

        [JsonProperty("recommendedRearTirePressure")]
        public RecommendedRearTirePressure RecommendedRearTirePressure { get; set; }
    }

    public class Vehiclestatus
    {
        [JsonProperty("vin")]
        public string Vin { get; set; }

        [JsonProperty("lockStatus")]
        public LockStatus LockStatus { get; set; }

        [JsonProperty("alarm")]
        public Alarm Alarm { get; set; }

        [JsonProperty("PrmtAlarmEvent")]
        public PrmtAlarmEvent PrmtAlarmEvent { get; set; }

        [JsonProperty("odometer")]
        public Odometer Odometer { get; set; }

        [JsonProperty("fuel")]
        public Fuel Fuel { get; set; }

        [JsonProperty("gps")]
        public Gps Gps { get; set; }

        [JsonProperty("remoteStart")]
        public RemoteStart RemoteStart { get; set; }

        [JsonProperty("remoteStartStatus")]
        public RemoteStartStatus RemoteStartStatus { get; set; }

        [JsonProperty("battery")]
        public Battery Battery { get; set; }

        [JsonProperty("oil")]
        public Oil Oil { get; set; }

        [JsonProperty("tirePressure")]
        public TirePressure TirePressure { get; set; }

        [JsonProperty("authorization")]
        public string Authorization { get; set; }

        [JsonProperty("TPMS")]
        public TPMS TPMS { get; set; }

        [JsonProperty("firmwareUpgInProgress")]
        public FirmwareUpgInProgress FirmwareUpgInProgress { get; set; }

        [JsonProperty("deepSleepInProgress")]
        public DeepSleepInProgress DeepSleepInProgress { get; set; }

        [JsonProperty("ccsSettings")]
        public CcsSettings CcsSettings { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("serverTime")]
        public string ServerTime { get; set; }

        [JsonProperty("batteryFillLevel")]
        public object BatteryFillLevel { get; set; }

        [JsonProperty("elVehDTE")]
        public ElVehDTE ElVehDTE { get; set; }

        [JsonProperty("hybridModeStatus")]
        public HybridModeStatus HybridModeStatus { get; set; }

        [JsonProperty("chargingStatus")]
        public ChargingStatus ChargingStatus { get; set; }

        [JsonProperty("plugStatus")]
        public PlugStatus PlugStatus { get; set; }

        [JsonProperty("chargeStartTime")]
        public ChargeStartTime ChargeStartTime { get; set; }

        [JsonProperty("chargeEndTime")]
        public ChargeEndTime ChargeEndTime { get; set; }

        [JsonProperty("preCondStatusDsply")]
        public PreCondStatusDsply PreCondStatusDsply { get; set; }

        [JsonProperty("chargerPowertype")]
        public ChargerPowertype ChargerPowertype { get; set; }

        [JsonProperty("batteryPerfStatus")]
        public BatteryPerfStatus BatteryPerfStatus { get; set; }

        [JsonProperty("outandAbout")]
        public OutandAbout OutandAbout { get; set; }

        [JsonProperty("batteryChargeStatus")]
        public BatteryChargeStatus BatteryChargeStatus { get; set; }

        [JsonProperty("dcFastChargeData")]
        public object DcFastChargeData { get; set; }

        [JsonProperty("windowPosition")]
        public WindowPosition WindowPosition { get; set; }

        [JsonProperty("doorStatus")]
        public DoorStatus DoorStatus { get; set; }

        [JsonProperty("ignitionStatus")]
        public IgnitionStatus IgnitionStatus { get; set; }

        [JsonProperty("batteryTracLowChargeThreshold")]
        public BatteryTracLowChargeThreshold BatteryTracLowChargeThreshold { get; set; }

        [JsonProperty("battTracLoSocDDsply")]
        public BattTracLoSocDDsply BattTracLoSocDDsply { get; set; }

        [JsonProperty("lifeCycMode")]
        public LifeCycMode LifeCycMode { get; set; }

        [JsonProperty("dieselSystemStatus")]
        public DieselSystemStatus DieselSystemStatus { get; set; }
    }

    public class WindowPosition
    {
        [JsonProperty("driverWindowPosition")]
        public DriverWindowPosition DriverWindowPosition { get; set; }

        [JsonProperty("passWindowPosition")]
        public PassWindowPosition PassWindowPosition { get; set; }

        [JsonProperty("rearDriverWindowPos")]
        public RearDriverWindowPos RearDriverWindowPos { get; set; }

        [JsonProperty("rearPassWindowPos")]
        public RearPassWindowPos RearPassWindowPos { get; set; }
    }


}
