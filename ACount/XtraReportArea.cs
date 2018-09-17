using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;

namespace AreaCount
{
    public partial class XtraReportArea : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportArea(List<AreaInfo> areaList, List<PerInAreaInfo> perAreaList)
        {
            InitializeComponent();
            DataSource = perAreaList;

            if(areaList.Count > 0)
            {
                if (areaList[0].Used <= 0)
                {
                    xrTable1.Rows[0].DeleteCell(xrTableCellArea1Header);
                    xrTable2.Rows[0].DeleteCell(xrTableCellArea1Data);
                    xrTable3.Rows[0].DeleteCell(xrTableCellArea1Total);
                }
                else
                {
                    xrTableCellArea1Header.Text = areaList[0].Title;
                }
            }
            if (areaList.Count > 1)
            {
                if (areaList[1].Used <= 0)
                {
                    xrTable1.Rows[0].DeleteCell(xrTableCellArea2Header);
                    xrTable2.Rows[0].DeleteCell(xrTableCellArea2Data);
                    xrTable3.Rows[0].DeleteCell(xrTableCellArea2Total);
                }
                else
                {
                    xrTableCellArea2Header.Text = areaList[1].Title;
                }
            }
            if (areaList.Count > 2)
            {
                if (areaList[2].Used <= 0)
                {
                    xrTable1.Rows[0].DeleteCell(xrTableCellArea3Header);
                    xrTable2.Rows[0].DeleteCell(xrTableCellArea3Data);
                    xrTable3.Rows[0].DeleteCell(xrTableCellArea3Total);
                }
                else
                {
                    xrTableCellArea3Header.Text = areaList[2].Title;
                }
            }
            if (areaList.Count > 3)
            {
                if (areaList[3].Used <= 0)
                {
                    xrTable1.Rows[0].DeleteCell(xrTableCellArea4Header);
                    xrTable2.Rows[0].DeleteCell(xrTableCellArea4Data);
                    xrTable3.Rows[0].DeleteCell(xrTableCellArea4Total);
                }
                else
                {
                    xrTableCellArea4Header.Text = areaList[3].Title;
                }
            }
            if (areaList.Count > 4)
            {
                if (areaList[4].Used <= 0)
                {
                    xrTable1.Rows[0].DeleteCell(xrTableCellArea5Header);
                    xrTable2.Rows[0].DeleteCell(xrTableCellArea5Data);
                    xrTable3.Rows[0].DeleteCell(xrTableCellArea5Total);
                }
                else
                {
                    xrTableCellArea5Header.Text = areaList[4].Title;
                }
            }
            if (areaList.Count > 5)
            {
                if (areaList[5].Used <= 0)
                {
                    xrTable1.Rows[0].DeleteCell(xrTableCellArea6Header);
                    xrTable2.Rows[0].DeleteCell(xrTableCellArea6Data);
                    xrTable3.Rows[0].DeleteCell(xrTableCellArea6Total);
                }
                else
                {
                    xrTableCellArea6Header.Text = areaList[5].Title;
                }
            }
        }

        private void DataBind()
        {
            
            //xrTable1.Rows[0].DeleteCell(xrTableCell5);
            //xrTable2.Rows[0].DeleteCell(xrTableCell10);
            //xrTable3.Rows[0].DeleteCell(xrTableCell12);
        }
    }
}
