using System.ComponentModel;

namespace EnumToSelectListItem.Enumerations
{
    public enum Day
    {
        [Description("星期一")]
        Monday = 1,

        [Description("星期二")]
        Tuesday,

        [Description("星期三")]
        Wednesday,

        [Description("星期四")]
        Thursday,

        [Description("星期五")]
        Friday,

        [Description("星期六")]
        Saturday,

        [Description("星期日")]
        Sunday
    }
}
