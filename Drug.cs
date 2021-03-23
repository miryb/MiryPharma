using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MiryPharma
{
    public enum DrugMedTypeEnum
    {
        Allopathic,
        Homeopath,
        Other
    }

    public enum DrugScopeEnum
    {
        Treatment,
        Prevention,
        Beauty,
        VitaminsNutritional,
        Other
    }

    public enum DrugHowToTakeEnum
    {
        Oral,
        Topical,
        Nose,
        Eyes,
        Other
    }

    public enum DrugAgeCategoryEnum
    {
        Adults,
        Babies,
        Kids,
        All,
        Other
    }

    public enum DrugFormatEnum
    {
        Pills,
        Chewable,
        Sachet,
        Drink,
        Ointment,
        Drops,
        Spray,
        Vial,
        ShotVial,
        Suppository,
        Other
    }
    public enum QuantityUnitsEnum
    {
        Pieces,
        Pack,
        HalfPack,
        QuarterPack,
        Blister,
        BlisterUnder5,
        Blisterunder10,
        BlisterUnder20,
        BlisterUnder30,
        Box  
    }

    public enum SymptomsEnum 
    {
        Headache,
        Backaches,
        BodyAches,
        NauseaVomit,
        Constipation,
        Diarrhea,
        AbdominalCramps,
        Dyspepsia,
        GasBloating,
        Anxiety,
        Depression,
        Insomnia,
        Fatigue,
        Chills,
        HotFlashes,
        Itchiness,
        ColdInfluenza,
        SoreThroat,
        Fever,
        Dizziness,
        BacteriaInfection,
        ViralInfection,
        Bleeding,
        LowImmunity,
        LowEnergy,
        VitaminsDeficiency,
        MineralDeficiency,
        Menopause,
        Puberty,
        Infertility,
        Aphrodisiac,
        Cancer,
        BeautyCare,
        Other
    }

    public class Drug
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Allergic { get; set; }
        public bool RequiresPrescription { get; set; }
        public bool PrescriptionAvailable { get; set; }
        public bool FirstTimeUse { get; set; }
        public bool Antibiotic { get; set; }
        public string ActiveIngredient { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public QuantityUnitsEnum QuantityUnits { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DrugFormatEnum DrugFormat  { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DrugAgeCategoryEnum DrugAgeCategory { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DrugHowToTakeEnum DrugHowToTake { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DrugMedTypeEnum DrugMedType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DrugScopeEnum DrugScope { get; set; }
        public SymptomsEnum Symptoms { get; set; }
        public List<SymptomsEnum> symptomsEnumList { get; set; }

        public string symptomsStr { get; set; }
        // public string AdditionalComments { get; set; } //not enough patience

        public Drug(string name, int qty, QuantityUnitsEnum qtyUnits, DateTime expiration) 
        {
            this.Name = name;
            this.Quantity = qty;
            this.QuantityUnits = qtyUnits;
            this.ExpiryDate = expiration;
        }


        public Drug() 
        {

        }
    }
}
