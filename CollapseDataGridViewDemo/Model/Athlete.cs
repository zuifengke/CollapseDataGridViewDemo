using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollapseDataGridViewDemo.Model
{
    public class Athlete
    {
        #region Private fields

        private string m_strCountry;
        private string m_strName;
        private string m_strGender;
        private decimal m_nHeight;
        private decimal m_nWeight;
        private string m_strItem;

        #endregion

        #region Public properties
        
        /// <summary>
        /// 国家
        /// </summary>
        public string Country
        {
            get { return m_strCountry; }
            set { m_strCountry = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return m_strName; }
            set { m_strName = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender
        {
            get { return m_strGender; }
            set { m_strGender = value; }
        }

        /// <summary>
        /// 身高
        /// </summary>
        public decimal Height
        {
            get { return m_nHeight; }
            set { m_nHeight = value; }
        }

        /// <summary>
        /// 体重
        /// </summary>
        public decimal Weight
        {
            get { return m_nWeight; }
            set { m_nWeight = value; }
        }

        /// <summary>
        /// 项目
        /// </summary>
        public string Item
        {
            get { return m_strItem; }
            set { m_strItem = value; }
        }

        #endregion
    }

    public class AthleteItemList : List<Athlete>
    {
        #region Private fields

        private string m_strBusNo;
        private string m_strRestRoomNo;
        private string m_strHotel;

        #endregion

        #region Public properties

        /// <summary>
        /// 大巴车牌号
        /// </summary>
        public string BusNo
        {
            get { return m_strBusNo; }
            set { m_strBusNo = value; }
        }

        /// <summary>
        /// 休息室编号
        /// </summary>
        public string RestRoomNo
        {
            get { return m_strRestRoomNo; }
            set { m_strRestRoomNo = value; }
        }

        /// <summary>
        /// 宾馆名称
        /// </summary>
        public string Hotel
        {
            get { return m_strHotel; }
            set { m_strHotel = value; }
        }

        #endregion
    }

    public class AthleteGroupList : List<List<Athlete>>
    { }
}
