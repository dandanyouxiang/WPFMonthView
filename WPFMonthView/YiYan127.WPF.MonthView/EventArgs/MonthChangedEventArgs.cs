using System;

namespace YiYan127.WPF.MonthView.EventArgs
{
    /// <summary>
    /// �·ݸı���¼�����
    /// </summary>
    public struct MonthChangedEventArgs
    {
        /// <summary>
        /// �ɵ��·ݿ�ʼ����
        /// </summary>
        public DateTime OldDisplayStartDate { get; set; }

        /// <summary>
        /// �µ��·ֿ�ʼ����
        /// </summary>
        public DateTime NewDisplayStartDate { get; set; }
    }
}