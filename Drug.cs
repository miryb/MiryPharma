using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        TopicalUse,
        Nose,
        Eyes,
        Other
    }

    public enum DrugAgeCategoryEnum
    {
        Babies,
        Kids,
        Adults
    }

    public enum DrugFormatEnum
    {
        PillsSwallow,
        Chewable,
        Sachet,
        ReadyToDrink,
        Ointment,
        Spray,
        Vial,
        ShotVial,
        Suppository,
        Other
    }
    public enum QuantityUnitsEnum
    {
        Pack,
        HalfPack,
        QuarterPack,
        Blister,
        BlisterUnder5,
        Blisterunder10,
        BlisterUnder20,
        BlisterUnder30,
        Box,
        Pieces
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

    class Drug
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
        public QuantityUnitsEnum QuantityUnits { get; set; }
        public DrugFormatEnum DrugFormat  { get; set; }
        public DrugAgeCategoryEnum DrugAgeCategory { get; set; }
        public DrugHowToTakeEnum DrugHowToTake { get; set; }
        public DrugMedTypeEnum DrugMedType { get; set; }
        public DrugScopeEnum DrugScope { get; set; }
        public SymptomsEnum Symptoms { get; set; }
        public string AdditionalComments { get; set; }

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
