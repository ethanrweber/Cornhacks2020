using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornhacksProject.Models
{
    public class DataProviderStatusType
    {
        public bool IsProviderEnabled { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public DataProviderStatusType(bool isProviderEnabled, int iD, string title)
        {
            IsProviderEnabled = isProviderEnabled;
            ID = iD;
            Title = title;
        }
    }

    public class DataProvider
    {
        public string WebsiteURL { get; set; }
        public object Comments { get; set; }
        public DataProviderStatusType DataProviderStatusType { get; set; }
        public bool IsRestrictedEdit { get; set; }
        public bool IsOpenDataLicensed { get; set; }
        public bool IsApprovedImport { get; set; }
        public string License { get; set; }
        public object DateLastImported { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public DataProvider(string websiteURL, object comments, DataProviderStatusType dataProviderStatusType, bool isRestrictedEdit, bool isOpenDataLicensed, bool isApprovedImport, string license, object dateLastImported, int iD, string title)
        {
            WebsiteURL = websiteURL;
            Comments = comments;
            DataProviderStatusType = dataProviderStatusType;
            IsRestrictedEdit = isRestrictedEdit;
            IsOpenDataLicensed = isOpenDataLicensed;
            IsApprovedImport = isApprovedImport;
            License = license;
            DateLastImported = dateLastImported;
            ID = iD;
            Title = title;
        }
    }

    public class OperatorInfo
    {
        public string WebsiteURL { get; set; }
        public object Comments { get; set; }
        public object PhonePrimaryContact { get; set; }
        public object PhoneSecondaryContact { get; set; }
        public object IsPrivateIndividual { get; set; }
        public object AddressInfo { get; set; }
        public object BookingURL { get; set; }
        public object ContactEmail { get; set; }
        public object FaultReportEmail { get; set; }
        public object IsRestrictedEdit { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public OperatorInfo(string websiteURL, object comments, object phonePrimaryContact, object phoneSecondaryContact, object isPrivateIndividual, object addressInfo, object bookingURL, object contactEmail, object faultReportEmail, object isRestrictedEdit, int iD, string title)
        {
            WebsiteURL = websiteURL;
            Comments = comments;
            PhonePrimaryContact = phonePrimaryContact;
            PhoneSecondaryContact = phoneSecondaryContact;
            IsPrivateIndividual = isPrivateIndividual;
            AddressInfo = addressInfo;
            BookingURL = bookingURL;
            ContactEmail = contactEmail;
            FaultReportEmail = faultReportEmail;
            IsRestrictedEdit = isRestrictedEdit;
            ID = iD;
            Title = title;
        }
    }

    public class UsageType
    {
        public bool IsPayAtLocation { get; set; }
        public bool IsMembershipRequired { get; set; }
        public bool IsAccessKeyRequired { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public UsageType(bool isPayAtLocation, bool isMembershipRequired, bool isAccessKeyRequired, int iD, string title)
        {
            IsPayAtLocation = isPayAtLocation;
            IsMembershipRequired = isMembershipRequired;
            IsAccessKeyRequired = isAccessKeyRequired;
            ID = iD;
            Title = title;
        }
    }

    public class StatusType
    {
        public bool IsOperational { get; set; }
        public bool IsUserSelectable { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public StatusType(bool isOperational, bool isUserSelectable, int iD, string title)
        {
            IsOperational = isOperational;
            IsUserSelectable = isUserSelectable;
            ID = iD;
            Title = title;
        }
    }

    public class SubmissionStatus
    {
        public bool IsLive { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public SubmissionStatus(bool isLive, int iD, string title)
        {
            IsLive = isLive;
            ID = iD;
            Title = title;
        }
    }

    public class Country
    {
        public string ISOCode { get; set; }
        public string ContinentCode { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public Country(string iSOCode, string continentCode, int iD, string title)
        {
            ISOCode = iSOCode;
            ContinentCode = continentCode;
            ID = iD;
            Title = title;
        }
    }

    public class AddressInfo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string AddressLine1 { get; set; }
        public object AddressLine2 { get; set; }
        public string Town { get; set; }
        public string StateOrProvince { get; set; }
        public string Postcode { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ContactTelephone1 { get; set; }
        public object ContactTelephone2 { get; set; }
        public object ContactEmail { get; set; }
        public object AccessComments { get; set; }
        public object RelatedURL { get; set; }
        public object Distance { get; set; }
        public int DistanceUnit { get; set; }

        public AddressInfo(int iD, string title, string addressLine1, object addressLine2, string town, string stateOrProvince, string postcode, int countryID, Country country, double latitude, double longitude, string contactTelephone1, object contactTelephone2, object contactEmail, object accessComments, object relatedURL, object distance, int distanceUnit)
        {
            ID = iD;
            Title = title;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Town = town;
            StateOrProvince = stateOrProvince;
            Postcode = postcode;
            CountryID = countryID;
            Country = country;
            Latitude = latitude;
            Longitude = longitude;
            ContactTelephone1 = contactTelephone1;
            ContactTelephone2 = contactTelephone2;
            ContactEmail = contactEmail;
            AccessComments = accessComments;
            RelatedURL = relatedURL;
            Distance = distance;
            DistanceUnit = distanceUnit;
        }
    }

    public class ConnectionType
    {
        public object FormalName { get; set; }
        public bool IsDiscontinued { get; set; }
        public bool IsObsolete { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public ConnectionType(object formalName, bool isDiscontinued, bool isObsolete, int iD, string title)
        {
            FormalName = formalName;
            IsDiscontinued = isDiscontinued;
            IsObsolete = isObsolete;
            ID = iD;
            Title = title;
        }
    }

    public class StatusType2
    {
        public bool IsOperational { get; set; }
        public bool IsUserSelectable { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public StatusType2(bool isOperational, bool isUserSelectable, int iD, string title)
        {
            IsOperational = isOperational;
            IsUserSelectable = isUserSelectable;
            ID = iD;
            Title = title;
        }
    }

    public class Level
    {
        public string Comments { get; set; }
        public bool IsFastChargeCapable { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public Level(string comments, bool isFastChargeCapable, int iD, string title)
        {
            Comments = comments;
            IsFastChargeCapable = isFastChargeCapable;
            ID = iD;
            Title = title;
        }
    }

    public class CurrentType
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public CurrentType(string description, int iD, string title)
        {
            Description = description;
            ID = iD;
            Title = title;
        }
    }

    public class Connection
    {
        public int ID { get; set; }
        public int ConnectionTypeID { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public object Reference { get; set; }
        public int StatusTypeID { get; set; }
        public StatusType2 StatusType { get; set; }
        public int LevelID { get; set; }
        public Level Level { get; set; }
        public object Amps { get; set; }
        public object Voltage { get; set; }
        public double PowerKW { get; set; }
        public int CurrentTypeID { get; set; }
        public CurrentType CurrentType { get; set; }
        public int Quantity { get; set; }
        public object Comments { get; set; }

        public Connection(int iD, int connectionTypeID, ConnectionType connectionType, object reference, int statusTypeID, StatusType2 statusType, int levelID, Level level, object amps, object voltage, double powerKW, int currentTypeID, CurrentType currentType, int quantity, object comments)
        {
            ID = iD;
            ConnectionTypeID = connectionTypeID;
            ConnectionType = connectionType;
            Reference = reference;
            StatusTypeID = statusTypeID;
            StatusType = statusType;
            LevelID = levelID;
            Level = level;
            Amps = amps;
            Voltage = voltage;
            PowerKW = powerKW;
            CurrentTypeID = currentTypeID;
            CurrentType = currentType;
            Quantity = quantity;
            Comments = comments;
        }
    }

    public class OpenChargeResult
    {
        public DataProvider DataProvider { get; set; }
        public OperatorInfo OperatorInfo { get; set; }
        public UsageType UsageType { get; set; }
        public StatusType StatusType { get; set; }
        public SubmissionStatus SubmissionStatus { get; set; }
        public object UserComments { get; set; }
        public object PercentageSimilarity { get; set; }
        public object MediaItems { get; set; }
        public bool IsRecentlyVerified { get; set; }
        public DateTime DateLastVerified { get; set; }
        public int ID { get; set; }
        public string UUID { get; set; }
        public object ParentChargePointID { get; set; }
        public int DataProviderID { get; set; }
        public object DataProvidersReference { get; set; }
        public int OperatorID { get; set; }
        public string OperatorsReference { get; set; }
        public int UsageTypeID { get; set; }
        public object UsageCost { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public List<Connection> Connections { get; set; }
        public int NumberOfPoints { get; set; }
        public string GeneralComments { get; set; }
        public object DatePlanned { get; set; }
        public object DateLastConfirmed { get; set; }
        public int StatusTypeID { get; set; }
        public DateTime DateLastStatusUpdate { get; set; }
        public object MetadataValues { get; set; }
        public int DataQualityLevel { get; set; }
        public DateTime DateCreated { get; set; }
        public int SubmissionStatusTypeID { get; set; }

        public OpenChargeResult(DataProvider dataProvider, OperatorInfo operatorInfo, UsageType usageType, StatusType statusType, SubmissionStatus submissionStatus, object userComments, object percentageSimilarity, object mediaItems, bool isRecentlyVerified, DateTime dateLastVerified, int iD, string uUID, object parentChargePointID, int dataProviderID, object dataProvidersReference, int operatorID, string operatorsReference, int usageTypeID, object usageCost, AddressInfo addressInfo, List<Connection> connections, int numberOfPoints, string generalComments, object datePlanned, object dateLastConfirmed, int statusTypeID, DateTime dateLastStatusUpdate, object metadataValues, int dataQualityLevel, DateTime dateCreated, int submissionStatusTypeID)
        {
            DataProvider = dataProvider;
            OperatorInfo = operatorInfo;
            UsageType = usageType;
            StatusType = statusType;
            SubmissionStatus = submissionStatus;
            UserComments = userComments;
            PercentageSimilarity = percentageSimilarity;
            MediaItems = mediaItems;
            IsRecentlyVerified = isRecentlyVerified;
            DateLastVerified = dateLastVerified;
            ID = iD;
            UUID = uUID;
            ParentChargePointID = parentChargePointID;
            DataProviderID = dataProviderID;
            DataProvidersReference = dataProvidersReference;
            OperatorID = operatorID;
            OperatorsReference = operatorsReference;
            UsageTypeID = usageTypeID;
            UsageCost = usageCost;
            AddressInfo = addressInfo;
            Connections = connections;
            NumberOfPoints = numberOfPoints;
            GeneralComments = generalComments;
            DatePlanned = datePlanned;
            DateLastConfirmed = dateLastConfirmed;
            StatusTypeID = statusTypeID;
            DateLastStatusUpdate = dateLastStatusUpdate;
            MetadataValues = metadataValues;
            DataQualityLevel = dataQualityLevel;
            DateCreated = dateCreated;
            SubmissionStatusTypeID = submissionStatusTypeID;
        }
    }
}
