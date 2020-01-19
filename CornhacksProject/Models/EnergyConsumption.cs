using System;
namespace CornhacksProject.Models
{
    public class CommercialElectricUse
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class CommercialElectricExpenditure
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class CommercialGasUse
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class CommercialGasExpenditure
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class IndustrialElectricUse
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class IndustrialElectricExpenditure
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class IndustrialGasUse
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class IndustrialGasExpenditure
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class ResidentialElectricUse
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class ResidentialElectricExpenditure
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class ResidentialGasUse
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class ResidentialGasExpenditure
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class CityFuelUseDiesel
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class CityFuelUseGas
    {
        public int min { get; set; }
        public int avg { get; set; }
        public int max { get; set; }
    }

    public class Table
    {
        public CommercialElectricUse commercial_electric_use { get; set; }
        public CommercialElectricExpenditure commercial_electric_expenditure { get; set; }
        public CommercialGasUse commercial_gas_use { get; set; }
        public CommercialGasExpenditure commercial_gas_expenditure { get; set; }
        public IndustrialElectricUse industrial_electric_use { get; set; }
        public IndustrialElectricExpenditure industrial_electric_expenditure { get; set; }
        public IndustrialGasUse industrial_gas_use { get; set; }
        public IndustrialGasExpenditure industrial_gas_expenditure { get; set; }
        public ResidentialElectricUse residential_electric_use { get; set; }
        public ResidentialElectricExpenditure residential_electric_expenditure { get; set; }
        public ResidentialGasUse residential_gas_use { get; set; }
        public ResidentialGasExpenditure residential_gas_expenditure { get; set; }
        public CityFuelUseDiesel city_fuel_use_diesel { get; set; }
        public CityFuelUseGas city_fuel_use_gas { get; set; }
    }

    public class EnergyConsumption
    {
        public Table table { get; set; }
    }
}
