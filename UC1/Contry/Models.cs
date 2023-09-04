#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace C1.Country
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;
    using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;
    using N = System.Text.Json.Serialization.JsonIgnoreCondition;

    public partial class Country
    {
        [J("name")] public Name Name { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("tld")] public List<string> Tld { get; set; }
        [J("cca2")] public string Cca2 { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ccn3")] public string Ccn3 { get; set; }
        [J("cca3")] public string Cca3 { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("cioc")] public string Cioc { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("independent")] public bool? Independent { get; set; }
        [J("status")] public Status Status { get; set; }
        [J("unMember")] public bool UnMember { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("currencies")] public Currencies Currencies { get; set; }
        [J("idd")] public Idd Idd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("capital")] public List<string> Capital { get; set; }
        [J("altSpellings")] public List<string> AltSpellings { get; set; }
        [J("region")] public Region Region { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("subregion")] public string Subregion { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("languages")] public Dictionary<string, string> Languages { get; set; }
        [J("translations")] public Dictionary<string, Translation> Translations { get; set; }
        [J("latlng")] public List<double> Latlng { get; set; }
        [J("landlocked")] public bool Landlocked { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("borders")] public List<string> Borders { get; set; }
        [J("area")] public double Area { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("demonyms")] public Demonyms Demonyms { get; set; }
        [J("flag")] public string Flag { get; set; }
        [J("maps")] public Maps Maps { get; set; }
        [J("population")] public long Population { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("gini")] public Dictionary<string, double> Gini { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("fifa")] public string Fifa { get; set; }
        [J("car")] public Car Car { get; set; }
        [J("timezones")] public List<string> Timezones { get; set; }
        [J("continents")] public List<Continent> Continents { get; set; }
        [J("flags")] public Flags Flags { get; set; }
        [J("coatOfArms")] public CoatOfArms CoatOfArms { get; set; }
        [J("startOfWeek")] public StartOfWeek StartOfWeek { get; set; }
        [J("capitalInfo")] public CapitalInfo CapitalInfo { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("postalCode")] public PostalCode PostalCode { get; set; }
    }

    public partial class CapitalInfo
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("latlng")] public List<double> Latlng { get; set; }
    }

    public partial class Car
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("signs")] public List<string> Signs { get; set; }
        [J("side")] public Side Side { get; set; }
    }

    public partial class CoatOfArms
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("png")] public Uri Png { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("svg")] public Uri Svg { get; set; }
    }

    public partial class Currencies
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MRU")] public Aed Mru { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ERN")] public Aed Ern { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("USD")] public Aed Usd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("RON")] public Aed Ron { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("XCD")] public Aed Xcd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AUD")] public Aed Aud { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("COP")] public Aed Cop { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CLP")] public Aed Clp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GHS")] public Aed Ghs { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GIP")] public Aed Gip { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("VES")] public Aed Ves { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("EUR")] public Aed Eur { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BWP")] public Aed Bwp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TZS")] public Aed Tzs { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KMF")] public Aed Kmf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("XOF")] public Aed Xof { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CVE")] public Aed Cve { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("LSL")] public Aed Lsl { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ZAR")] public Aed Zar { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("XAF")] public Aed Xaf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("JOD")] public Aed Jod { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SEK")] public Aed Sek { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("VND")] public Aed Vnd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("QAR")] public Aed Qar { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BRL")] public Aed Brl { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GEL")] public Aed Gel { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KRW")] public Aed Krw { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("STN")] public Aed Stn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GYD")] public Aed Gyd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SRD")] public Aed Srd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KHR")] public Aed Khr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ANG")] public Aed Ang { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MVR")] public Aed Mvr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PYG")] public Aed Pyg { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PEN")] public Aed Pen { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("FKP")] public Aed Fkp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("UZS")] public Aed Uzs { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("EGP")] public Aed Egp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ILS")] public Aed Ils { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KZT")] public Aed Kzt { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MYR")] public Aed Myr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AED")] public Aed Aed { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CZK")] public Aed Czk { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("YER")] public Aed Yer { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MMK")] public Aed Mmk { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("XPF")] public Aed Xpf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("FJD")] public Aed Fjd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ALL")] public Aed All { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GBP")] public Aed Gbp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("IMP")] public Aed Imp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AFN")] public Aed Afn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KGS")] public Aed Kgs { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PHP")] public Aed Php { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("RSD")] public Aed Rsd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SHP")] public Aed Shp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MDL")] public Aed Mdl { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("HKD")] public Aed Hkd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PKR")] public Aed Pkr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SAR")] public Aed Sar { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AOA")] public Aed Aoa { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("DKK")] public Aed Dkk { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KWD")] public Aed Kwd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CHF")] public Aed Chf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TOP")] public Aed Top { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GTQ")] public Aed Gtq { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("UGX")] public Aed Ugx { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GNF")] public Aed Gnf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("NPR")] public Aed Npr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ETB")] public Aed Etb { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KID")] public Aed Kid { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PGK")] public Aed Pgk { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ISK")] public Aed Isk { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MAD")] public Aed Mad { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("IQD")] public Aed Iqd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("DOP")] public Aed Dop { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SLL")] public Aed Sll { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BZD")] public Aed Bzd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BTN")] public Aed Btn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("INR")] public Aed Inr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("IRR")] public Aed Irr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BOB")] public Aed Bob { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TRY")] public Aed Try { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("FOK")] public Aed Fok { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("NIO")] public Aed Nio { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CDF")] public Aed Cdf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AZN")] public Aed Azn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SGD")] public Aed Sgd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CUC")] public Aed Cuc { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CUP")] public Aed Cup { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BDT")] public Aed Bdt { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("HUF")] public Aed Huf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BGN")] public Aed Bgn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SCR")] public Aed Scr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MOP")] public Aed Mop { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MXN")] public Aed Mxn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BND")] public Aed Bnd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TWD")] public Aed Twd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AWG")] public Aed Awg { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TTD")] public Aed Ttd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("VUV")] public Aed Vuv { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("DZD")] public Aed Dzd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CKD")] public Aed Ckd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("NZD")] public Aed Nzd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BIF")] public Aed Bif { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BYN")] public Aed Byn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KPW")] public Aed Kpw { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("WST")] public Aed Wst { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ZWL")] public Aed Zwl { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BMD")] public Aed Bmd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("DJF")] public Aed Djf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("JPY")] public Aed Jpy { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TVD")] public Aed Tvd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SDG")] public Bam Sdg { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MKD")] public Aed Mkd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CAD")] public Aed Cad { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("IDR")] public Aed Idr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GMD")] public Aed Gmd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SOS")] public Aed Sos { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MUR")] public Aed Mur { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("RUB")] public Aed Rub { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("OMR")] public Aed Omr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MNT")] public Aed Mnt { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TJS")] public Aed Tjs { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SBD")] public Aed Sbd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("HTG")] public Aed Htg { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("HNL")] public Aed Hnl { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("NAD")] public Aed Nad { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ARS")] public Aed Ars { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("UYU")] public Aed Uyu { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BBD")] public Aed Bbd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("GGP")] public Aed Ggp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KES")] public Aed Kes { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("JMD")] public Aed Jmd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TND")] public Aed Tnd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("KYD")] public Aed Kyd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MZN")] public Aed Mzn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("LRD")] public Aed Lrd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SSP")] public Aed Ssp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("LYD")] public Aed Lyd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("TMT")] public Aed Tmt { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("NGN")] public Aed Ngn { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("NOK")] public Aed Nok { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BAM")] public Bam Bam { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("LAK")] public Aed Lak { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MGA")] public Aed Mga { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("LKR")] public Aed Lkr { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("RWF")] public Aed Rwf { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("AMD")] public Aed Amd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SYP")] public Aed Syp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("THB")] public Aed Thb { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("UAH")] public Aed Uah { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CNY")] public Aed Cny { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("MWK")] public Aed Mwk { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PAB")] public Aed Pab { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BHD")] public Aed Bhd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("JEP")] public Aed Jep { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("PLN")] public Aed Pln { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("BSD")] public Aed Bsd { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("CRC")] public Aed Crc { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("LBP")] public Aed Lbp { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("ZMW")] public Aed Zmw { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("SZL")] public Aed Szl { get; set; }
    }

    public partial class Aed
    {
        [J("name")] public string Name { get; set; }
        [J("symbol")] public string Symbol { get; set; }
    }

    public partial class Bam
    {
        [J("name")] public string Name { get; set; }
    }

    public partial class Demonyms
    {
        [J("eng")] public Eng Eng { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("fra")] public Eng Fra { get; set; }
    }

    public partial class Eng
    {
        [J("f")] public string F { get; set; }
        [J("m")] public string M { get; set; }
    }

    public partial class Flags
    {
        [J("png")] public Uri Png { get; set; }
        [J("svg")] public Uri Svg { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("alt")] public string Alt { get; set; }
    }

    public partial class Idd
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("root")] public string Root { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("suffixes")] public List<string> Suffixes { get; set; }
    }

    public partial class Maps
    {
        [J("googleMaps")] public Uri GoogleMaps { get; set; }
        [J("openStreetMaps")] public string OpenStreetMaps { get; set; }
    }

    public partial class Name
    {
        [J("common")] public string Common { get; set; }
        [J("official")] public string Official { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("nativeName")] public Dictionary<string, Translation> NativeName { get; set; }
    }

    public partial class Translation
    {
        [J("official")] public string Official { get; set; }
        [J("common")] public string Common { get; set; }
    }

    public partial class PostalCode
    {
        [J("format")] public string Format { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)][J("regex")] public string Regex { get; set; }
    }

    public enum Side { Left, Right };

    public enum Continent { Africa, Antarctica, Asia, Europe, NorthAmerica, Oceania, SouthAmerica };

    public enum Region { Africa, Americas, Antarctic, Asia, Europe, Oceania };

    public enum StartOfWeek { Monday, Saturday, Sunday };

    public enum Status { OfficiallyAssigned, UserAssigned };

    public partial class Welcome
    {
        public static List<Welcome> FromJson(string json) => JsonSerializer.Deserialize<List<Welcome>>(json, C1.Country.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Welcome> self) => JsonSerializer.Serialize(self, C1.Country.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                SideConverter.Singleton,
                ContinentConverter.Singleton,
                RegionConverter.Singleton,
                StartOfWeekConverter.Singleton,
                StatusConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class SideConverter : JsonConverter<Side>
    {
        public override bool CanConvert(Type t) => t == typeof(Side);

        public override Side Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "left":
                    return Side.Left;
                case "right":
                    return Side.Right;
            }
            throw new Exception("Cannot unmarshal type Side");
        }

        public override void Write(Utf8JsonWriter writer, Side value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Side.Left:
                    JsonSerializer.Serialize(writer, "left", options);
                    return;
                case Side.Right:
                    JsonSerializer.Serialize(writer, "right", options);
                    return;
            }
            throw new Exception("Cannot marshal type Side");
        }

        public static readonly SideConverter Singleton = new SideConverter();
    }

    internal class ContinentConverter : JsonConverter<Continent>
    {
        public override bool CanConvert(Type t) => t == typeof(Continent);

        public override Continent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Africa":
                    return Continent.Africa;
                case "Antarctica":
                    return Continent.Antarctica;
                case "Asia":
                    return Continent.Asia;
                case "Europe":
                    return Continent.Europe;
                case "North America":
                    return Continent.NorthAmerica;
                case "Oceania":
                    return Continent.Oceania;
                case "South America":
                    return Continent.SouthAmerica;
            }
            throw new Exception("Cannot unmarshal type Continent");
        }

        public override void Write(Utf8JsonWriter writer, Continent value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Continent.Africa:
                    JsonSerializer.Serialize(writer, "Africa", options);
                    return;
                case Continent.Antarctica:
                    JsonSerializer.Serialize(writer, "Antarctica", options);
                    return;
                case Continent.Asia:
                    JsonSerializer.Serialize(writer, "Asia", options);
                    return;
                case Continent.Europe:
                    JsonSerializer.Serialize(writer, "Europe", options);
                    return;
                case Continent.NorthAmerica:
                    JsonSerializer.Serialize(writer, "North America", options);
                    return;
                case Continent.Oceania:
                    JsonSerializer.Serialize(writer, "Oceania", options);
                    return;
                case Continent.SouthAmerica:
                    JsonSerializer.Serialize(writer, "South America", options);
                    return;
            }
            throw new Exception("Cannot marshal type Continent");
        }

        public static readonly ContinentConverter Singleton = new ContinentConverter();
    }

    internal class RegionConverter : JsonConverter<Region>
    {
        public override bool CanConvert(Type t) => t == typeof(Region);

        public override Region Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Africa":
                    return Region.Africa;
                case "Americas":
                    return Region.Americas;
                case "Antarctic":
                    return Region.Antarctic;
                case "Asia":
                    return Region.Asia;
                case "Europe":
                    return Region.Europe;
                case "Oceania":
                    return Region.Oceania;
            }
            throw new Exception("Cannot unmarshal type Region");
        }

        public override void Write(Utf8JsonWriter writer, Region value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Region.Africa:
                    JsonSerializer.Serialize(writer, "Africa", options);
                    return;
                case Region.Americas:
                    JsonSerializer.Serialize(writer, "Americas", options);
                    return;
                case Region.Antarctic:
                    JsonSerializer.Serialize(writer, "Antarctic", options);
                    return;
                case Region.Asia:
                    JsonSerializer.Serialize(writer, "Asia", options);
                    return;
                case Region.Europe:
                    JsonSerializer.Serialize(writer, "Europe", options);
                    return;
                case Region.Oceania:
                    JsonSerializer.Serialize(writer, "Oceania", options);
                    return;
            }
            throw new Exception("Cannot marshal type Region");
        }

        public static readonly RegionConverter Singleton = new RegionConverter();
    }

    internal class StartOfWeekConverter : JsonConverter<StartOfWeek>
    {
        public override bool CanConvert(Type t) => t == typeof(StartOfWeek);

        public override StartOfWeek Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "monday":
                    return StartOfWeek.Monday;
                case "saturday":
                    return StartOfWeek.Saturday;
                case "sunday":
                    return StartOfWeek.Sunday;
            }
            throw new Exception("Cannot unmarshal type StartOfWeek");
        }

        public override void Write(Utf8JsonWriter writer, StartOfWeek value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case StartOfWeek.Monday:
                    JsonSerializer.Serialize(writer, "monday", options);
                    return;
                case StartOfWeek.Saturday:
                    JsonSerializer.Serialize(writer, "saturday", options);
                    return;
                case StartOfWeek.Sunday:
                    JsonSerializer.Serialize(writer, "sunday", options);
                    return;
            }
            throw new Exception("Cannot marshal type StartOfWeek");
        }

        public static readonly StartOfWeekConverter Singleton = new StartOfWeekConverter();
    }

    internal class StatusConverter : JsonConverter<Status>
    {
        public override bool CanConvert(Type t) => t == typeof(Status);

        public override Status Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "officially-assigned":
                    return Status.OfficiallyAssigned;
                case "user-assigned":
                    return Status.UserAssigned;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Status.OfficiallyAssigned:
                    JsonSerializer.Serialize(writer, "officially-assigned", options);
                    return;
                case Status.UserAssigned:
                    JsonSerializer.Serialize(writer, "user-assigned", options);
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
