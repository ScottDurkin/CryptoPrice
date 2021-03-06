using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPrice.Currencies
{
    //A Full list of supported fiat currencies
    /// <summary>
    /// Fiat contains a full library of fiat currencies.
    /// </summary>
    public class Fiat
    {
        public static String AFN { get { return "AFN"; } }
        public static String EUR { get { return "EUR"; } }
        public static String ALL { get { return "ALL"; } }
        public static String DZD { get { return "DZD"; } }
        public static String USD { get { return "USD"; } }
        public static String AOA { get { return "AOA"; } }
        public static String XCD { get { return "XCD"; } }
        public static String ARS { get { return "ARS"; } }
        public static String AMD { get { return "AMD"; } }
        public static String AWG { get { return "AWG"; } }
        public static String AUD { get { return "AUD"; } }
        public static String AZN { get { return "AZN"; } }
        public static String BHD { get { return "BHD"; } }
        public static String BSD { get { return "BSD"; } }
        public static String BDT { get { return "BDT"; } }
        public static String BBD { get { return "BBD"; } }
        public static String BYN { get { return "BYN"; } }
        public static String BZD { get { return "BZD"; } }
        public static String XOF { get { return "XOF"; } }
        public static String BMD { get { return "BMD"; } }
        public static String INR { get { return "INR"; } }
        public static String BTN { get { return "BTN"; } }
        public static String BOB { get { return "BOB"; } }
        public static String BOV { get { return "BOV"; } }
        public static String BAM { get { return "BAM"; } }
        public static String BWP { get { return "BWP"; } }
        public static String NOK { get { return "NOK"; } }
        public static String BRL { get { return "BRL"; } }
        public static String BND { get { return "BND"; } }
        public static String BGN { get { return "BGN"; } }
        public static String BIF { get { return "BIF"; } }
        public static String CVE { get { return "CVE"; } }
        public static String KHR { get { return "KHR"; } }
        public static String XAF { get { return "XAF"; } }
        public static String CAD { get { return "CAD"; } }
        public static String KYD { get { return "KYD"; } }
        public static String CLP { get { return "CLP"; } }
        public static String CLF { get { return "CLF"; } }
        public static String CNY { get { return "CNY"; } }
        public static String COP { get { return "COP"; } }
        public static String COU { get { return "COU"; } }
        public static String KMF { get { return "KMF"; } }
        public static String CDF { get { return "CDF"; } }
        public static String NZD { get { return "NZD"; } }
        public static String CRC { get { return "CRC"; } }
        public static String HRK { get { return "HRK"; } }
        public static String CUP { get { return "CUP"; } }
        public static String CUC { get { return "CUC"; } }
        public static String ANG { get { return "ANG"; } }
        public static String CZK { get { return "CZK"; } }
        public static String DKK { get { return "DKK"; } }
        public static String DJF { get { return "DJF"; } }
        public static String DOP { get { return "DOP"; } }
        public static String EGP { get { return "EGP"; } }
        public static String SVC { get { return "SVC"; } }
        public static String ERN { get { return "ERN"; } }
        public static String SZL { get { return "SZL"; } }
        public static String ETB { get { return "ETB"; } }
        public static String FKP { get { return "FKP"; } }
        public static String FJD { get { return "FJD"; } }
        public static String XPF { get { return "XPF"; } }
        public static String GMD { get { return "GMD"; } }
        public static String GEL { get { return "GEL"; } }
        public static String GHS { get { return "GHS"; } }
        public static String GIP { get { return "GIP"; } }
        public static String GTQ { get { return "GTQ"; } }
        public static String GBP { get { return "GBP"; } }
        public static String GNF { get { return "GNF"; } }
        public static String GYD { get { return "GYD"; } }
        public static String HTG { get { return "HTG"; } }
        public static String HNL { get { return "HNL"; } }
        public static String HKD { get { return "HKD"; } }
        public static String HUF { get { return "HUF"; } }
        public static String ISK { get { return "ISK"; } }
        public static String IDR { get { return "IDR"; } }
        public static String XDR { get { return "XDR"; } }
        public static String IRR { get { return "IRR"; } }
        public static String IQD { get { return "IQD"; } }
        public static String ILS { get { return "ILS"; } }
        public static String JMD { get { return "JMD"; } }
        public static String JPY { get { return "JPY"; } }
        public static String JOD { get { return "JOD"; } }
        public static String KZT { get { return "KZT"; } }
        public static String KES { get { return "KES"; } }
        public static String KPW { get { return "KPW"; } }
        public static String KRW { get { return "KRW"; } }
        public static String KWD { get { return "KWD"; } }
        public static String KGS { get { return "KGS"; } }
        public static String LAK { get { return "LAK"; } }
        public static String LBP { get { return "LBP"; } }
        public static String LSL { get { return "LSL"; } }
        public static String ZAR { get { return "ZAR"; } }
        public static String LRD { get { return "LRD"; } }
        public static String LYD { get { return "LYD"; } }
        public static String CHF { get { return "CHF"; } }
        public static String MOP { get { return "MOP"; } }
        public static String MKD { get { return "MKD"; } }
        public static String MGA { get { return "MGA"; } }
        public static String MWK { get { return "MWK"; } }
        public static String MYR { get { return "MYR"; } }
        public static String MVR { get { return "MVR"; } }
        public static String MRU { get { return "MRU"; } }
        public static String MUR { get { return "MUR"; } }
        public static String XUA { get { return "XUA"; } }
        public static String MXN { get { return "MXN"; } }
        public static String MXV { get { return "MXV"; } }
        public static String MDL { get { return "MDL"; } }
        public static String MNT { get { return "MNT"; } }
        public static String MAD { get { return "MAD"; } }
        public static String MZN { get { return "MZN"; } }
        public static String MMK { get { return "MMK"; } }
        public static String NAD { get { return "NAD"; } }
        public static String NPR { get { return "NPR"; } }
        public static String NIO { get { return "NIO"; } }
        public static String NGN { get { return "NGN"; } }
        public static String OMR { get { return "OMR"; } }
        public static String PKR { get { return "PKR"; } }
        public static String PAB { get { return "PAB"; } }
        public static String PGK { get { return "PGK"; } }
        public static String PYG { get { return "PYG"; } }
        public static String PEN { get { return "PEN"; } }
        public static String PHP { get { return "PHP"; } }
        public static String PLN { get { return "PLN"; } }
        public static String QAR { get { return "QAR"; } }
        public static String RON { get { return "RON"; } }
        public static String RUB { get { return "RUB"; } }
        public static String RWF { get { return "RWF"; } }
        public static String SHP { get { return "SHP"; } }
        public static String WST { get { return "WST"; } }
        public static String STN { get { return "STN"; } }
        public static String SAR { get { return "SAR"; } }
        public static String RSD { get { return "RSD"; } }
        public static String SCR { get { return "SCR"; } }
        public static String SLL { get { return "SLL"; } }
        public static String SGD { get { return "SGD"; } }
        public static String XSU { get { return "XSU"; } }
        public static String SBD { get { return "SBD"; } }
        public static String SOS { get { return "SOS"; } }
        public static String SSP { get { return "SSP"; } }
        public static String LKR { get { return "LKR"; } }
        public static String SDG { get { return "SDG"; } }
        public static String SRD { get { return "SRD"; } }
        public static String SEK { get { return "SEK"; } }
        public static String CHE { get { return "CHE"; } }
        public static String CHW { get { return "CHW"; } }
        public static String SYP { get { return "SYP"; } }
        public static String TWD { get { return "TWD"; } }
        public static String TJS { get { return "TJS"; } }
        public static String TZS { get { return "TZS"; } }
        public static String THB { get { return "THB"; } }
        public static String TOP { get { return "TOP"; } }
        public static String TTD { get { return "TTD"; } }
        public static String TND { get { return "TND"; } }
        public static String TRY { get { return "TRY"; } }
        public static String TMT { get { return "TMT"; } }
        public static String UGX { get { return "UGX"; } }
        public static String UAH { get { return "UAH"; } }
        public static String AED { get { return "AED"; } }
        public static String USN { get { return "USN"; } }
        public static String UYU { get { return "UYU"; } }
        public static String UYI { get { return "UYI"; } }
        public static String UYW { get { return "UYW"; } }
        public static String UZS { get { return "UZS"; } }
        public static String VUV { get { return "VUV"; } }
        public static String VES { get { return "VES"; } }
        public static String VND { get { return "VND"; } }
        public static String YER { get { return "YER"; } }
        public static String ZMW { get { return "ZMW"; } }
        public static String ZWL { get { return "ZWL"; } }
        public static String XBA { get { return "XBA"; } }
        public static String XBB { get { return "XBB"; } }
        public static String XBC { get { return "XBC"; } }
        public static String XBD { get { return "XBD"; } }
        public static String XTS { get { return "XTS"; } }
        public static String XXX { get { return "XXX"; } }
        public static String XAU { get { return "XAU"; } }
        public static String XPD { get { return "XPD"; } }
        public static String XPT { get { return "XPT"; } }
        public static String XAG { get { return "XAG"; } }
        public static String AFA { get { return "AFA"; } }
        public static String FIM { get { return "FIM"; } }
        public static String ALK { get { return "ALK"; } }
        public static String ADP { get { return "ADP"; } }
        public static String ESP { get { return "ESP"; } }
        public static String FRF { get { return "FRF"; } }
        public static String AOK { get { return "AOK"; } }
        public static String AON { get { return "AON"; } }
        public static String AOR { get { return "AOR"; } }
        public static String ARA { get { return "ARA"; } }
        public static String ARP { get { return "ARP"; } }
        public static String ARY { get { return "ARY"; } }
        public static String RUR { get { return "RUR"; } }
        public static String ATS { get { return "ATS"; } }
        public static String AYM { get { return "AYM"; } }
        public static String AZM { get { return "AZM"; } }
        public static String BYB { get { return "BYB"; } }
        public static String BYR { get { return "BYR"; } }
        public static String BEC { get { return "BEC"; } }
        public static String BEF { get { return "BEF"; } }
        public static String BEL { get { return "BEL"; } }
        public static String BOP { get { return "BOP"; } }
        public static String BAD { get { return "BAD"; } }
        public static String BRB { get { return "BRB"; } }
        public static String BRC { get { return "BRC"; } }
        public static String BRE { get { return "BRE"; } }
        public static String BRN { get { return "BRN"; } }
        public static String BRR { get { return "BRR"; } }
        public static String BGJ { get { return "BGJ"; } }
        public static String BGK { get { return "BGK"; } }
        public static String BGL { get { return "BGL"; } }
        public static String BUK { get { return "BUK"; } }
        public static String HRD { get { return "HRD"; } }
        public static String CYP { get { return "CYP"; } }
        public static String CSJ { get { return "CSJ"; } }
        public static String CSK { get { return "CSK"; } }
        public static String ECS { get { return "ECS"; } }
        public static String ECV { get { return "ECV"; } }
        public static String GQE { get { return "GQE"; } }
        public static String EEK { get { return "EEK"; } }
        public static String XEU { get { return "XEU"; } }
        public static String GEK { get { return "GEK"; } }
        public static String DDM { get { return "DDM"; } }
        public static String DEM { get { return "DEM"; } }
        public static String GHC { get { return "GHC"; } }
        public static String GHP { get { return "GHP"; } }
        public static String GRD { get { return "GRD"; } }
        public static String GNE { get { return "GNE"; } }
        public static String GNS { get { return "GNS"; } }
        public static String GWE { get { return "GWE"; } }
        public static String GWP { get { return "GWP"; } }
        public static String ITL { get { return "ITL"; } }
        public static String ISJ { get { return "ISJ"; } }
        public static String IEP { get { return "IEP"; } }
        public static String ILP { get { return "ILP"; } }
        public static String ILR { get { return "ILR"; } }
        public static String LAJ { get { return "LAJ"; } }
        public static String LVL { get { return "LVL"; } }
        public static String LVR { get { return "LVR"; } }
        public static String LSM { get { return "LSM"; } }
        public static String ZAL { get { return "ZAL"; } }
        public static String LTL { get { return "LTL"; } }
        public static String LTT { get { return "LTT"; } }
        public static String LUC { get { return "LUC"; } }
        public static String LUF { get { return "LUF"; } }
        public static String LUL { get { return "LUL"; } }
        public static String MGF { get { return "MGF"; } }
        public static String MVQ { get { return "MVQ"; } }
        public static String MLF { get { return "MLF"; } }
        public static String MTL { get { return "MTL"; } }
        public static String MTP { get { return "MTP"; } }
        public static String MRO { get { return "MRO"; } }
        public static String MXP { get { return "MXP"; } }
        public static String MZE { get { return "MZE"; } }
        public static String MZM { get { return "MZM"; } }
        public static String NLG { get { return "NLG"; } }
        public static String NIC { get { return "NIC"; } }
        public static String PEH { get { return "PEH"; } }
        public static String PEI { get { return "PEI"; } }
        public static String PES { get { return "PES"; } }
        public static String PLZ { get { return "PLZ"; } }
        public static String PTE { get { return "PTE"; } }
        public static String ROK { get { return "ROK"; } }
        public static String ROL { get { return "ROL"; } }
        public static String STD { get { return "STD"; } }
        public static String CSD { get { return "CSD"; } }
        public static String SKK { get { return "SKK"; } }
        public static String SIT { get { return "SIT"; } }
        public static String RHD { get { return "RHD"; } }
        public static String ESA { get { return "ESA"; } }
        public static String ESB { get { return "ESB"; } }
        public static String SDD { get { return "SDD"; } }
        public static String SDP { get { return "SDP"; } }
        public static String SRG { get { return "SRG"; } }
        public static String CHC { get { return "CHC"; } }
        public static String TJR { get { return "TJR"; } }
        public static String TPE { get { return "TPE"; } }
        public static String TRL { get { return "TRL"; } }
        public static String TMM { get { return "TMM"; } }
        public static String UGS { get { return "UGS"; } }
        public static String UGW { get { return "UGW"; } }
        public static String UAK { get { return "UAK"; } }
        public static String SUR { get { return "SUR"; } }
        public static String USS { get { return "USS"; } }
        public static String UYN { get { return "UYN"; } }
        public static String UYP { get { return "UYP"; } }
        public static String VEB { get { return "VEB"; } }
        public static String VEF { get { return "VEF"; } }
        public static String VNC { get { return "VNC"; } }
        public static String YDD { get { return "YDD"; } }
        public static String YUD { get { return "YUD"; } }
        public static String YUM { get { return "YUM"; } }
        public static String YUN { get { return "YUN"; } }
        public static String ZRN { get { return "ZRN"; } }
        public static String ZRZ { get { return "ZRZ"; } }
        public static String ZMK { get { return "ZMK"; } }
        public static String ZWC { get { return "ZWC"; } }
        public static String ZWD { get { return "ZWD"; } }
        public static String ZWN { get { return "ZWN"; } }
        public static String ZWR { get { return "ZWR"; } }
        public static String XFO { get { return "XFO"; } }
        public static String XRE { get { return "XRE"; } }
        public static String XFU { get { return "XFU"; } }
    }
}
