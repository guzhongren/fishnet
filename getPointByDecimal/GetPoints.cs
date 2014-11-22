using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getPointByDecimal
{
    public static class GetPoints
    {
        
        
        public static void GetSmallFramPoint(decimal rows,decimal columns,int rowSpan,int columnSpan)
        {
            string framString = "Row," + "Colum," + "framX," + "framY\r\n";
            decimal row=0;
            decimal column=0;
            decimal smallRow = 0;//遍历变量
            decimal smallColumn = 0;//遍历变量
            int lan = 0;//经纬度
            int lon = 0;//经纬度
            int rowNum=0;//行号
            int columnNum=0;//列号
            for (row = rows; row <rows + rowSpan; row++)
            {
                lan = Convert.ToInt32(row);
                for (column = columns; column < columns + columnSpan; column++)
                {
                    lon = Convert.ToInt32(column);
                    for (smallRow = row; smallRow <= row + 1; smallRow += 0.01m)
                    {
                        rowNum++;
                        for (smallColumn = column; smallColumn <=column + 1; smallColumn += 0.01m)
                        {
                            columnNum++;
                            framString += rowNum.ToString() + "," + columnNum.ToString() + "," + smallColumn.ToString() + "," + smallRow.ToString()+"\r\n";
                        }
                        columnNum = 0;
                    }
                    System.IO.File.WriteAllText(@"G:\RZPU\20141118fishnet\test\" + lan.ToString() + "-" + lon.ToString() + ".csv", framString);
                    framString = "Row," + "Colum," + "framX," + "framY\r\n";
                    rowNum = 0;
                    
                }
                column = columns;
            }
            row = 0;
        }
    }
}
