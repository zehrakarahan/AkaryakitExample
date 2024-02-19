namespace AkaryakitExample
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/Sale.xsd", IsNullable = false)]
    public partial class SaleData
    {

        private SaleDataGlobalParams globalParamsField;

        private SaleDataPump[] pumpTotalizersField;

        private SaleDataTxn[] txnsField;

        /// <remarks/>
        public SaleDataGlobalParams GlobalParams
        {
            get
            {
                return this.globalParamsField;
            }
            set
            {
                this.globalParamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pump", IsNullable = false)]
        public SaleDataPump[] PumpTotalizers
        {
            get
            {
                return this.pumpTotalizersField;
            }
            set
            {
                this.pumpTotalizersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Txn", IsNullable = false)]
        public SaleDataTxn[] Txns
        {
            get
            {
                return this.txnsField;
            }
            set
            {
                this.txnsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    public partial class SaleDataGlobalParams
    {

        private string versionField;

        private ushort companyCodeField;

        private ushort stationCodeField;

        private byte unitPriceDecimalField;

        private byte amountDecimalField;

        private byte totalDecimalField;

        private object fleetListVersionField;

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public ushort CompanyCode
        {
            get
            {
                return this.companyCodeField;
            }
            set
            {
                this.companyCodeField = value;
            }
        }

        /// <remarks/>
        public ushort StationCode
        {
            get
            {
                return this.stationCodeField;
            }
            set
            {
                this.stationCodeField = value;
            }
        }

        /// <remarks/>
        public byte UnitPriceDecimal
        {
            get
            {
                return this.unitPriceDecimalField;
            }
            set
            {
                this.unitPriceDecimalField = value;
            }
        }

        /// <remarks/>
        public byte AmountDecimal
        {
            get
            {
                return this.amountDecimalField;
            }
            set
            {
                this.amountDecimalField = value;
            }
        }

        /// <remarks/>
        public byte TotalDecimal
        {
            get
            {
                return this.totalDecimalField;
            }
            set
            {
                this.totalDecimalField = value;
            }
        }

        /// <remarks/>
        public object FleetListVersion
        {
            get
            {
                return this.fleetListVersionField;
            }
            set
            {
                this.fleetListVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    public partial class SaleDataPump
    {

        private SaleDataPumpNozzle[] nozzlesField;

        private byte pumpNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Nozzle", IsNullable = false)]
        public SaleDataPumpNozzle[] Nozzles
        {
            get
            {
                return this.nozzlesField;
            }
            set
            {
                this.nozzlesField = value;
            }
        }

        /// <remarks/>
        public byte PumpName
        {
            get
            {
                return this.pumpNameField;
            }
            set
            {
                this.pumpNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    public partial class SaleDataPumpNozzle
    {

        private byte nozzleNrField;

        private byte fuelTypeField;

        private uint totalizerField;

        /// <remarks/>
        public byte NozzleNr
        {
            get
            {
                return this.nozzleNrField;
            }
            set
            {
                this.nozzleNrField = value;
            }
        }

        /// <remarks/>
        public byte FuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        /// <remarks/>
        public uint Totalizer
        {
            get
            {
                return this.totalizerField;
            }
            set
            {
                this.totalizerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    public partial class SaleDataTxn
    {

        private SaleDataTxnTagDetails tagDetailsField;

        private SaleDataTxnSaleDetails saleDetailsField;

        /// <remarks/>
        public SaleDataTxnTagDetails TagDetails
        {
            get
            {
                return this.tagDetailsField;
            }
            set
            {
                this.tagDetailsField = value;
            }
        }

        /// <remarks/>
        public SaleDataTxnSaleDetails SaleDetails
        {
            get
            {
                return this.saleDetailsField;
            }
            set
            {
                this.saleDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    public partial class SaleDataTxnTagDetails
    {

        private string fleetCodeField;

        private string fleetNameField;

        private string tagNrField;

        private string plateField;

        private byte engineHourField;

        private byte odometerField;

        /// <remarks/>
        public string FleetCode
        {
            get
            {
                return this.fleetCodeField;
            }
            set
            {
                this.fleetCodeField = value;
            }
        }

        /// <remarks/>
        public string FleetName
        {
            get
            {
                return this.fleetNameField;
            }
            set
            {
                this.fleetNameField = value;
            }
        }

        /// <remarks/>
        public string TagNr
        {
            get
            {
                return this.tagNrField;
            }
            set
            {
                this.tagNrField = value;
            }
        }

        /// <remarks/>
        public string Plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }

        /// <remarks/>
        public byte EngineHour
        {
            get
            {
                return this.engineHourField;
            }
            set
            {
                this.engineHourField = value;
            }
        }

        /// <remarks/>
        public byte Odometer
        {
            get
            {
                return this.odometerField;
            }
            set
            {
                this.odometerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/Sale.xsd")]
    public partial class SaleDataTxnSaleDetails
    {

        private byte txnTypeField;

        private ulong dateTimeField;

        private uint receiptNrField;

        private byte fuelTypeField;

        private ushort unitPriceField;

        private ushort amountField;

        private ushort totalField;

        private byte pumpNrField;

        private byte nozzleNrField;

        private byte paymentTypeField;

        private string eCRPlateField;

        private byte eCRReceiptNrField;

        private string redemptionField;

        private string discountAmountField;

        private byte earnedPointsField;

        private string earnedMoneyField;

        private string loyaltyCardNoField;

        private byte loyaltyCardTypeField;

        private ushort fullUnitPriceField;

        /// <remarks/>
        public byte TxnType
        {
            get
            {
                return this.txnTypeField;
            }
            set
            {
                this.txnTypeField = value;
            }
        }

        /// <remarks/>
        public ulong DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        public uint ReceiptNr
        {
            get
            {
                return this.receiptNrField;
            }
            set
            {
                this.receiptNrField = value;
            }
        }

        /// <remarks/>
        public byte FuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        /// <remarks/>
        public ushort UnitPrice
        {
            get
            {
                return this.unitPriceField;
            }
            set
            {
                this.unitPriceField = value;
            }
        }

        /// <remarks/>
        public ushort Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public ushort Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public byte PumpNr
        {
            get
            {
                return this.pumpNrField;
            }
            set
            {
                this.pumpNrField = value;
            }
        }

        /// <remarks/>
        public byte NozzleNr
        {
            get
            {
                return this.nozzleNrField;
            }
            set
            {
                this.nozzleNrField = value;
            }
        }

        /// <remarks/>
        public byte PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        public string ECRPlate
        {
            get
            {
                return this.eCRPlateField;
            }
            set
            {
                this.eCRPlateField = value;
            }
        }

        /// <remarks/>
        public byte ECRReceiptNr
        {
            get
            {
                return this.eCRReceiptNrField;
            }
            set
            {
                this.eCRReceiptNrField = value;
            }
        }

        /// <remarks/>
        public string Redemption
        {
            get
            {
                return this.redemptionField;
            }
            set
            {
                this.redemptionField = value;
            }
        }

        /// <remarks/>
        public string DiscountAmount
        {
            get
            {
                return this.discountAmountField;
            }
            set
            {
                this.discountAmountField = value;
            }
        }

        /// <remarks/>
        public byte EarnedPoints
        {
            get
            {
                return this.earnedPointsField;
            }
            set
            {
                this.earnedPointsField = value;
            }
        }

        /// <remarks/>
        public string EarnedMoney
        {
            get
            {
                return this.earnedMoneyField;
            }
            set
            {
                this.earnedMoneyField = value;
            }
        }

        /// <remarks/>
        public string LoyaltyCardNo
        {
            get
            {
                return this.loyaltyCardNoField;
            }
            set
            {
                this.loyaltyCardNoField = value;
            }
        }

        /// <remarks/>
        public byte LoyaltyCardType
        {
            get
            {
                return this.loyaltyCardTypeField;
            }
            set
            {
                this.loyaltyCardTypeField = value;
            }
        }

        /// <remarks/>
        public ushort FullUnitPrice
        {
            get
            {
                return this.fullUnitPriceField;
            }
            set
            {
                this.fullUnitPriceField = value;
            }
        }
    }


}
