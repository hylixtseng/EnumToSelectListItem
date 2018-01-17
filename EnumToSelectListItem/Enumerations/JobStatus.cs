using System.ComponentModel;

namespace EnumToSelectListItem.Enumerations
{
    /// <summary>
    /// 職員在職狀態
    /// </summary>
    public enum JobStatus
    {
        [Description("尚未報到")]
        NotOnBoardYet = 0,
        
        [Description("在職中")]
        TakeOffice,
        
        [Description("已離職")]
        LeaveOffice,
        
        [Description("留職停薪")]
        StayWithoutPay
    }
}
